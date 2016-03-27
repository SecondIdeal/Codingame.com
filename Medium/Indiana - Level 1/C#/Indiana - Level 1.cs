using System;

class Player
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int numberOfColumns = int.Parse(inputs[0]);
        int numberOfRows    = int.Parse(inputs[1]);

        int[,] map = new int[numberOfRows, numberOfColumns];
        for (int i = 0; i < numberOfRows; i++)
        {
            string[] entranceRoomDirection = Console.ReadLine().Split();

            for (int j = 0; j < numberOfColumns; j++)
                map[i, j] = int.Parse(entranceRoomDirection[j]);
        }
        int exitCoordinates = int.Parse(Console.ReadLine());

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int currentXPosition    = int.Parse(inputs[0]);
            int currentYPosition    = int.Parse(inputs[1]);
            string currentDirection = inputs[2];

            int nextXPosition = currentXPosition; int nextYPosition = currentYPosition;

            switch (map[currentYPosition, currentXPosition])
            {
                case 0:
                case 1:
                    nextYPosition++;
                    break;
                case 2:
                    if (currentDirection[0] == 'L')
                        nextXPosition++; 
                    else
                        nextXPosition--;
                    break;
                case 3:
                    nextYPosition++;
                    break;
                case 4:
                    if (currentDirection[0] == 'T')
                        nextXPosition--;
                    else
                        nextYPosition++;
                    break;
                case 5:
                    if (currentDirection[0] == 'T')
                        nextXPosition++;
                    else
                        nextYPosition++;
                    break;
                case 6:
                    if (currentDirection[0] == 'L')
                        nextXPosition++;
                    else
                        nextXPosition--;
                    break;
                case 7:
                case 8:
                case 9:
                    nextYPosition++;
                    break;
                case 10:
                    nextXPosition--;
                    break;
                case 11:
                    nextXPosition++;
                    break;
                case 12:
                case 13:
                    nextYPosition++;
                    break;
            }
            Console.WriteLine(nextXPosition + " " + nextYPosition);
        }
    }
}