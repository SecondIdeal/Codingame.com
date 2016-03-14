using System;

class Player
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int width       = inputs[0]; // Width of the building.
        int height      = inputs[1]; // Height of the building.
        int maxTurns    = int.Parse(Console.ReadLine()); // Maximum number of turns before game over.

        inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int X0 = inputs[0];
        int Y0 = inputs[1];

        // Coordinates of new window from min to max
        int minX = 0, maxX = width - 1, minY = 0, maxY = height - 1;

        while (true)
        {
            string bombDirection = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            if (bombDirection.IndexOf('L') >= 0)
                maxX = X0 - 1;
            else if (bombDirection.IndexOf('R') >= 0)
                minX = X0 + 1;

            if (bombDirection[0] == 'U')
                maxY = Y0 - 1;
            else if (bombDirection[0] == 'D')
                minY = Y0 + 1;

            X0 = (minX + maxX) / 2;
            Y0 = (minY + maxY) / 2;

            Console.WriteLine(X0 + " " + Y0);
        }
    }
}