using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int widthOfBoard = int.Parse(inputs[0]); // width of the board
        int heightOfBoard = int.Parse(inputs[1]); // height of the board
        int playerCount = int.Parse(inputs[2]); // number of players (2 or 3)
        int myId = int.Parse(inputs[3]); // id of my player (0 = 1st player, 1 = 2nd player, ...)

        int counterForStartPositions = 0;
        string[] playerStartPositions = new string[playerCount];

        while (true)
        {
            // Заполняем нашу карту
            string[,] wallsMapV = new string[widthOfBoard, heightOfBoard];
            string[,] wallsMapH = new string[widthOfBoard, heightOfBoard];

            // Текущее местоположение каждого из игроков
            int[] allPlayersX = new int[playerCount];
            int[] allPlayersY = new int[playerCount];

            // По количеству стен = -1 мы можем определить, что игрок больше не играет, это необходимо, чтобы правильно расчитывать сколько кому осталось до финиша
            int[] playerWallsLeft = new int[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int playerX = int.Parse(inputs[0]); // x-coordinate of the player
                int playerY = int.Parse(inputs[1]); // y-coordinate of the player
                int wallsLeft = int.Parse(inputs[2]); // number of walls available for the player

                // Запишем текущее местоположение игрока
                allPlayersX[i] = playerX;
                allPlayersY[i] = playerY;

                playerWallsLeft[i] = wallsLeft;

                // Определим стартовую сторону каждого игрока 
                if (i == 0)
                    playerStartPositions[i] = "L";
                else if (i == 1)
                    playerStartPositions[i] = "R";
                else
                    playerStartPositions[i] = "U";             
            }

            int wallsOnBoard = int.Parse(Console.ReadLine()); // number of walls on the board

            for (int i = 0; i < wallsOnBoard; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int wallX = int.Parse(inputs[0]); // x-coordinate of the wall
                int wallY = int.Parse(inputs[1]); // y-coordinate of the wall
                string wallOrientation = inputs[2]; // wall orientation ('H' or 'V')

                // Разместим стену на карте             
                if (wallOrientation == "H")
                {
                    wallsMapH[wallX, wallY] = wallOrientation;
                    wallsMapH[wallX + 1, wallY] = wallOrientation; // Клетка справа тоже занимается стеной
                }
                else if (wallOrientation == "V")
                {
                    wallsMapV[wallX, wallY] = wallOrientation;
                    wallsMapV[wallX, wallY + 1] = wallOrientation; // Клетка снизу тоже занимается стеной  
                }
            }

            // Если стен нет на карте, то и путь свободен
            bool pathIsClear = isPathClear(wallsMapV, wallsMapH, playerStartPositions, wallsOnBoard, myId, allPlayersX[myId], allPlayersY[myId]);

            // Кто первый успеет дойти  
            int[] pathLenghtsForPlayers = calculatePathsLenghts(allPlayersX, allPlayersY, playerWallsLeft, playerStartPositions, playerCount, myId, widthOfBoard, heightOfBoard);

            int targetEnemy = 0;
            int targetEnemyPathLenght = int.MaxValue;

            for (int i = 0; i < playerCount; i++)
            {
                if (i != myId && playerWallsLeft[i] != -1)
                    if (pathLenghtsForPlayers[i] < targetEnemyPathLenght)
                        targetEnemy = i;
                targetEnemyPathLenght = pathLenghtsForPlayers[targetEnemy];
            }
            bool shoot = (pathLenghtsForPlayers[myId] > targetEnemyPathLenght && targetEnemy != myId) ? true : false;

            string newDirection = directionToExit(wallsMapV, wallsMapH, wallsOnBoard, playerStartPositions, pathIsClear, allPlayersX, allPlayersY, heightOfBoard, widthOfBoard, myId);
            bool enemyPathIsClear = isPathClear(wallsMapV, wallsMapH, playerStartPositions, wallsOnBoard, targetEnemy, allPlayersX[targetEnemy], allPlayersY[targetEnemy]);
            string newWallPosition = (playerWallsLeft[myId] != 0) ? calculateNewWallPositionAndDirection(wallsMapV, wallsMapH, allPlayersX, allPlayersY, playerStartPositions, wallsOnBoard, targetEnemy, widthOfBoard, heightOfBoard) : "";

            if (pathIsClear && !shoot)
                Console.WriteLine(newDirection);
            else if (pathIsClear && shoot)
            {
                if (enemyPathIsClear)
                    Console.WriteLine(newWallPosition != "" ? newWallPosition : newDirection);
                else if (!enemyPathIsClear)
                    Console.WriteLine(newDirection);
                else
                    Console.WriteLine("Module pathIsClear && shoot.");
            }
            else if (!pathIsClear && !shoot)
                Console.WriteLine(newDirection);
            else if (!pathIsClear && shoot)
            {
                if (enemyPathIsClear)
                    Console.WriteLine(newWallPosition != "" ? newWallPosition : newDirection);
                else if (!enemyPathIsClear)
                    Console.WriteLine(newDirection);
                else
                    Console.WriteLine("Module !pathIsClear && shoot.");
            }
            counterForStartPositions++; // Необходима для самого первого хода, чтобы собрать начальные позиции игроков.
        }
    }

    static bool isPathClear(string[,] wallsMapV, string[,] wallsMapH, string[] playerStartPositions, int wallsOnBoard, int playerId, int playerXPos, int playerYPos)
    {
        bool pathIsClear = true;

        if (wallsOnBoard != 0)
        {
            if (playerStartPositions[playerId] == "L")
                pathIsClear = (wallsMapV[playerXPos + 1, playerYPos] == "V") ? false : true;
            else if (playerStartPositions[playerId] == "R")
                pathIsClear = (wallsMapV[playerXPos, playerYPos] == "V") ? false : true;
            else if (playerStartPositions[playerId] == "U")
                pathIsClear = (wallsMapH[playerXPos, playerYPos + 1] == "H") ? false : true;
            else
                Console.WriteLine("In module isPathClear - problems...");
        }
        return pathIsClear;
    }

    static int[] calculatePathsLenghts(int[] allPlayersX, int[] allPlayersY, int[] playerWallsLeft, string[] playerStartPositions, int playerCount, int myId, int widthOfBoard, int heightOfBoard)
    {
        // Высчитываем чистую длину пути. Например, решаем удивить игрока стеной, ибо он быстрее нас дотопает, но перед ним стена нужного направления, тогда ничего не делаем. 
        int[] pathLenghtsForPlayers = new int[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            if (playerStartPositions[i] == "L")
                pathLenghtsForPlayers[i] = (widthOfBoard - 1) - allPlayersX[i];
            else if (playerStartPositions[i] == "R")
                pathLenghtsForPlayers[i] = allPlayersX[i];
            else if (playerStartPositions[i] == "U")
                pathLenghtsForPlayers[i] = (heightOfBoard - 1) - allPlayersY[i];
            else
                Console.WriteLine("Module calculatePathsLenghts.");

            // Если игрок проиграл, то не надо на него ориентироваться
            if (playerWallsLeft[i] == -1)
                pathLenghtsForPlayers[i] = int.MaxValue;
        }

        // Делаем нас менее агрессивными...
        if (myId == 0)
        {
            if (playerCount == 2)
                pathLenghtsForPlayers[1]++;
            else //if (playerCount == 3)
            {
                pathLenghtsForPlayers[1]++;
                pathLenghtsForPlayers[2]++; //= pathLenghtsForPlayers[2] + 2;
            }
        }
        else if (myId == 1)
        {
            //pathLenghtsForPlayers[0]++;
            //pathLenghtsForPlayers[2]++;
        }
        else if (myId == 2)
        {
            //pathLenghtsForPlayers[0]++;
            //pathLenghtsForPlayers[1]++; 
        }

        // Ситуация: Два игрока, я второй, я иду справа налево, он - слева направо, он успевает дойти первым, так как начинает ход первым.
        // Оказалось, что нет необходимости, тебе даются текущего местоположения, если походил уже - то походил.
        //if (myId == 1) // То есть я справа
        //    pathLenghtsForPlayers[0]--;
        //if (myId == 2) // Я сверху, хожу последним
        //{
        //    pathLenghtsForPlayers[0] = pathLenghtsForPlayers[0] - 2;
        //    pathLenghtsForPlayers[1]--;
        //}
        return pathLenghtsForPlayers;
    }

    static string calculateNewWallPositionAndDirection(string[,] wallsMapV, string[,] wallsMapH, int[] allPlayersX, int[] allPlayersY, string[] playerStartPositions, int wallsOnBoard, int targetEnemy, int widthOfBoard, int heightOfBoard)
    {
        // Cюда мы попали потому что, перед врагом на пути нет стены нужного направления - надо её поставить.
        string newWallOrientation = (playerStartPositions[targetEnemy] == "U") ? "H" : "V";

        int newWallXPos = 0;
        int newWallYPos = 0;

        int enemyPosX = allPlayersX[targetEnemy];
        int enemyPosY = allPlayersY[targetEnemy];

        if (playerStartPositions[targetEnemy] == "L")
        {
            if (enemyPosY != (heightOfBoard - 1))
            {
                if (wallsMapV[(enemyPosX + 1), (enemyPosY + 1)] != "V")
                {
                    newWallXPos = enemyPosX + 1;
                    newWallYPos = enemyPosY;
                }
                else if (wallsMapV[(enemyPosX + 1), (enemyPosY + 1)] == "V")
                {
                    if (enemyPosY != 0)
                    {
                        if (wallsMapV[(enemyPosX + 1), (enemyPosY - 1)] != "V")
                        {
                            newWallXPos = enemyPosX + 1;
                            newWallYPos = enemyPosY - 1;
                        }
                        else if (wallsMapV[(enemyPosX + 1), (enemyPosY - 1)] == "V")
                        {
                            newWallXPos = int.MaxValue;
                            newWallYPos = int.MaxValue;
                        }
                    }
                    else if (enemyPosY == 0)
                    {
                        newWallXPos = int.MaxValue;
                        newWallYPos = int.MaxValue;
                    }
                }
            }
            else if (enemyPosY == (heightOfBoard - 1))
            {
                if (wallsMapV[(enemyPosX + 1), (enemyPosY - 1)] != "V")
                {
                    newWallXPos = enemyPosX + 1;
                    newWallYPos = enemyPosY - 1;
                }
                else if (wallsMapV[(enemyPosX + 1), (enemyPosY - 1)] == "V")
                {
                    newWallXPos = int.MaxValue;
                    newWallYPos = int.MaxValue;
                }
            }
        }
        else if (playerStartPositions[targetEnemy] == "R")
        {
            if (enemyPosY != (heightOfBoard - 1))
            {
                if (wallsMapV[enemyPosX, (enemyPosY + 1)] != "V")
                {
                    newWallXPos = enemyPosX;
                    newWallYPos = enemyPosY;
                }
                else if (wallsMapV[enemyPosX, (enemyPosY + 1)] == "V")
                {
                    if (enemyPosY != 0)
                    {
                        if (wallsMapV[enemyPosX, (enemyPosY - 1)] != "V")
                        {
                            newWallXPos = enemyPosX;
                            newWallYPos = enemyPosY - 1;
                        }
                        else if (wallsMapV[enemyPosX, (enemyPosY - 1)] == "V")
                        {
                            newWallXPos = int.MaxValue;
                            newWallYPos = int.MaxValue;
                        }
                    }
                    else if (enemyPosY == 0)
                    {
                        newWallXPos = int.MaxValue;
                        newWallYPos = int.MaxValue;
                    }
                }
            }
            else if (enemyPosY == (heightOfBoard - 1))
            {
                if (wallsMapV[enemyPosX, (enemyPosY - 1)] != "V")
                {
                    newWallXPos = enemyPosX;
                    newWallYPos = enemyPosY - 1;
                }
                else if (wallsMapV[enemyPosX, (enemyPosY - 1)] == "V")
                {
                    newWallXPos = int.MaxValue;
                    newWallYPos = int.MaxValue;
                }
            }
        }
        else if (playerStartPositions[targetEnemy] == "U")
        {
            if (enemyPosX != (widthOfBoard - 1))
            {
                if (wallsMapH[(enemyPosX + 1), (enemyPosY + 1)] != "H")
                {
                    newWallXPos = enemyPosX;
                    newWallYPos = enemyPosY + 1;
                }
                else if (wallsMapH[(enemyPosX + 1), (enemyPosY + 1)] == "H")
                {
                    if (enemyPosX != 0)
                    {
                        if (wallsMapH[(enemyPosX - 1), (enemyPosY + 1)] != "H")
                        {
                            newWallXPos = enemyPosX - 1;
                            newWallYPos = enemyPosY + 1;
                        }
                        else if (wallsMapH[(enemyPosX - 1), (enemyPosY + 1)] == "H")
                        {
                            newWallXPos = int.MaxValue;
                            newWallYPos = int.MaxValue;
                        }
                    }
                    else if (enemyPosX == 0)
                    {
                        newWallXPos = int.MaxValue;
                        newWallYPos = int.MaxValue;
                    }
                }
            }
            else if (enemyPosX == (widthOfBoard - 1))
            {
                if (wallsMapH[(enemyPosX - 1), (enemyPosY + 1)] != "H")
                {
                    newWallXPos = enemyPosX - 1;
                    newWallYPos = enemyPosY + 1;
                }
                else if (wallsMapH[(enemyPosX - 1), (enemyPosY + 1)] == "H")
                {
                    newWallXPos = int.MaxValue;
                    newWallYPos = int.MaxValue;
                }
            }
        }
        else
            Console.WriteLine("Module calculateNewWallPositionAndDirection.");

        // Если  стена не влезет, то мы отправим пустую строку, что будет означать, что надо просто сходить далее.
        return (newWallXPos == int.MaxValue && newWallYPos == int.MaxValue) ? "" : (newWallXPos.ToString() + " " + newWallYPos.ToString() + " " + newWallOrientation);
    }

    static string directionToExit(string[,] wallsMapV, string[,] wallsMapH, int wallsOnBoard, string[] playerStartPositions, bool pathIsClear, int[] allPlayersX, int[] allPlayersY, int heightOfBoard, int widthOfBoard, int myId)
    {
        // Много кода, плохого кода, надо всё поправить.
        
        // Когда pathLenghtUp == pathLenghtDown всему придет хана, то что уже написано -  не решит эту проблему.
        
        // Проверить не выходим ли мы за границы карты. Например, мы в самой верхней точке, явно стену обойти ещё выше не сможем.
        string desiredDirection = "";

        if (pathIsClear)
            desiredDirection = playerStartPositions[myId] == "L" ? "RIGHT" : playerStartPositions[myId] == "R" ? "LEFT" : "DOWN";
        else// if (!pathIsClear)
        {
            int pathLenghtUp = 0; // Left for U
            int pathLenghtDown = 0; // Right for U

            if (playerStartPositions[myId] == "L")
            {
                // Здесь узкое место! Если например, справа стена, сверху, например, край, то, иди, мол, вниз, а там горизонтальная стена...Правильно было бы пойти назад.
                if (allPlayersY[myId] == 0)
                    desiredDirection = "DOWN";
                else if (allPlayersY[myId] == (heightOfBoard - 1))
                    desiredDirection = "UP";
                else
                {
                    int xPosition = allPlayersX[myId];
                    int yPosition = allPlayersY[myId];

                    while (yPosition > 0)
                    {
                        if (wallsMapH[allPlayersX[myId] + 1, yPosition] != "H")
                        {
                            if (wallsMapV[allPlayersX[myId] + 1, yPosition] == "V")
                            {
                                pathLenghtUp++;
                                yPosition--;

                                if (yPosition <= 0 && wallsMapV[allPlayersX[myId] + 1, yPosition] == "V")
                                {
                                    pathLenghtUp = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtUp = int.MaxValue;
                            break;
                        }
                    }

                    xPosition = allPlayersX[myId];
                    yPosition = allPlayersY[myId];

                    while (yPosition < (heightOfBoard - 1))
                    {
                        if (wallsMapH[allPlayersX[myId] + 1, yPosition + 1] != "H")
                        {
                            if (wallsMapV[allPlayersX[myId] + 1, yPosition] == "V")
                            {
                                pathLenghtDown++;
                                yPosition++;

                                if (yPosition >= (heightOfBoard - 1) && wallsMapV[allPlayersX[myId] + 1, yPosition] == "V")
                                {
                                    pathLenghtDown = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtDown = int.MaxValue;
                            break;
                        }
                    }
                    desiredDirection = (pathLenghtUp > pathLenghtDown) ? "DOWN" : "UP";
                }
            }
            else if (playerStartPositions[myId] == "R")
            {
                if (allPlayersY[myId] == 0)
                    desiredDirection = "DOWN";
                else if (allPlayersY[myId] == (heightOfBoard - 1))
                    desiredDirection = "UP";
                else
                {
                    int xPosition = allPlayersX[myId];
                    int yPosition = allPlayersY[myId];

                    while (yPosition > 0)
                    {
                        if (wallsMapH[allPlayersX[myId], yPosition] != "H")
                        {
                            if (wallsMapV[allPlayersX[myId], yPosition] == "V")
                            {
                                pathLenghtUp++;
                                yPosition--;

                                if (yPosition <= 0 && wallsMapV[allPlayersX[myId], yPosition] == "V")
                                {
                                    pathLenghtUp = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtUp = int.MaxValue;
                            break;
                        }
                    }

                    xPosition = allPlayersX[myId];
                    yPosition = allPlayersY[myId];

                    while (yPosition < (heightOfBoard - 1))
                    {
                        if (wallsMapH[allPlayersX[myId], (yPosition + 1)] != "H")
                        {
                            if (wallsMapV[allPlayersX[myId], yPosition] == "V")
                            {
                                pathLenghtDown++;
                                yPosition++;

                                if (yPosition >= (heightOfBoard - 1) && wallsMapV[allPlayersX[myId], yPosition] == "V")
                                {
                                    pathLenghtDown = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtDown = int.MaxValue;
                            break;
                        }
                    }
                    desiredDirection = (pathLenghtUp > pathLenghtDown) ? "DOWN" : "UP";
                }
            }
            else if (playerStartPositions[myId] == "U")
            {
                if (allPlayersX[myId] == 0)
                    desiredDirection = "RIGHT";
                else if (allPlayersX[myId] == (widthOfBoard - 1))
                    desiredDirection = "LEFT";
                else
                {
                    int xPosition = allPlayersX[myId];
                    int yPosition = allPlayersY[myId];

                    //pathLenghtUp - Left
                    //pathLenghtDown - Right

                    while (yPosition > 0)
                    {
                        if (wallsMapV[allPlayersX[myId], (yPosition + 1)] != "V")
                        {
                            if (wallsMapH[allPlayersX[myId], (yPosition + 1)] == "H")
                            {
                                pathLenghtUp++;
                                yPosition--;

                                if (yPosition <= 0 && wallsMapH[allPlayersX[myId], (yPosition + 1)] == "H")
                                {
                                    pathLenghtUp = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtUp = int.MaxValue;
                            break;
                        }
                    }

                    xPosition = allPlayersX[myId];
                    yPosition = allPlayersY[myId];

                    while (yPosition < heightOfBoard - 1)
                    {
                        if (wallsMapV[(allPlayersX[myId] + 1), (yPosition + 1)] != "V")
                        {
                            if (wallsMapH[allPlayersX[myId], (yPosition + 1)] == "H")
                            {
                                pathLenghtDown++;
                                yPosition++;

                                if (yPosition >= (heightOfBoard - 1) && wallsMapH[allPlayersX[myId], (yPosition + 1)] == "H")
                                {
                                    pathLenghtDown = int.MaxValue;
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            pathLenghtDown = int.MaxValue;
                            break;
                        }
                    }
                    desiredDirection = (pathLenghtUp > pathLenghtDown) ? "RIGHT" : "LEFT";
                }
            }
        }
        return desiredDirection;
    }
}