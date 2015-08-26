using System;

class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

        int[,] gridArray = new int[width, height];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .

            for (int k = 0; k < width; k++)
            {
                if (line[k] == '0') 
                { gridArray[k, i] = 0; }
                else 
                { gridArray[k, i] = -1; }
            }
        }

        // From left to right
        for (int coordY = 0; coordY < height; coordY++)
        {
            for (int coodinX = 0; coodinX < width; coodinX++)
            {
                if (gridArray[coodinX, coordY] == 0)
                {
                    //Horizontal
                    int coordXR = -1; int coordYR = -1; // Coordinate of the node on the right
                    int n = coodinX + 1;
                    while (n < width)
                    {
                        if (coordXR == -1 && coordYR == -1) 
                        {
                            if (gridArray[n, coordY] == 0)
                            { coordXR = n; coordYR = coordY; }
                        }
                        n++;
                    }

                    // Vertical
                    int coordXB = -1; int coordYB = -1; // Coordinate of the node at the bottom
                    int m = coordY + 1;
                    while (m < height)
                    {
                        if (coordXB == -1 && coordYB == -1)
                        {
                            if (gridArray[coodinX, m] == 0)
                            { coordXB = coodinX; coordYB = m; }
                        }
                        m++;
                    }
                    Console.WriteLine(coodinX + " " + coordY + " " + coordXR + " " + coordYR + " " + coordXB + " " + coordYB);
                }
            }
        }
    }
}