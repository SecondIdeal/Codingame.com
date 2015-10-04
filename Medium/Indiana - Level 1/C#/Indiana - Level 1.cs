using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int numberOfColumns = int.Parse(inputs[0]); // number of columns.
        int numberOfRows = int.Parse(inputs[1]); // number of rows.

        int[,] map = new int[numberOfRows, numberOfColumns];
        for (int i = 0; i < numberOfRows; i++)
        {
            string line = Console.ReadLine(); // represents a line in the grid and contains W integers. Each integer represents one room of a given type.
            string[] row = line.Split();

            for (int j = 0; j < numberOfColumns; j++)
            {
                map[i, j] = int.Parse(row[j]);
            }
        }
        int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int XI = int.Parse(inputs[0]);
            int YI = int.Parse(inputs[1]);
            string position = inputs[2];

            int X = 0; int Y = 0;

            switch (map[YI, XI])
            {
                case 0:
                case 1:
                    Y++;
                    break;

                case 2:
                    X = (position[0] == 'L') ? 1 : -1;
                    break;

                case 3:
                    Y++;
                    break;

                case 4:
                    switch (position[0])
                    {
                        case 'T':
                            X--;
                            break;
                        case 'R':
                            Y++;
                            break;
                    }
                    break;

                case 5:
                    switch (position[0])
                    {
                        case 'T':
                            X++;
                            break;
                        case 'L':
                            Y++;
                            break;
                    }
                    break;

                case 6:
                    switch (position[0])
                    {
                        case 'L':
                            X++;
                            break;

                        case 'R':
                            X--;
                            break;
                    }
                    break;

                case 7:
                case 8:
                case 9:
                    Y++;
                    break;

                case 10:
                    X--;
                    break;

                case 11:
                    X++;
                    break;

                case 12:
                case 13:
                    Y++;
                    break;
            }
            Console.WriteLine((XI + X) + " " + (YI + Y)); // One line containing the X Y coordinates of the room in which you believe Indy will be on the next turn.
        }
    }
}