using System;

class Player
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int buldingWidth            = inputs[0];
        int buldingHeight           = inputs[1]; 
        int maxTurnsBeforeGameOver  = int.Parse(Console.ReadLine());

        inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int batmanPositionX = inputs[0];
        int batmanPositionY = inputs[1];

        // Coordinates of new window from min to max
        int minX = 0, maxX = buldingWidth - 1, minY = 0, maxY = buldingHeight - 1;

        while (true)
        {
            string bombDirectionFromCurrentLocation = Console.ReadLine(); // U, UR, R, DR, D, DL, L or UL

            if (bombDirectionFromCurrentLocation.IndexOf('L') >= 0)
                maxX = batmanPositionX - 1;
            else if (bombDirectionFromCurrentLocation.IndexOf('R') >= 0)
                minX = batmanPositionX + 1;

            if (bombDirectionFromCurrentLocation[0] == 'U')
                maxY = batmanPositionY - 1;
            else if (bombDirectionFromCurrentLocation[0] == 'D')
                minY = batmanPositionY + 1;

            batmanPositionX = (minX + maxX) / 2;
            batmanPositionY = (minY + maxY) / 2;

            Console.WriteLine(batmanPositionX + " " + batmanPositionY);
        }
    }
}