using System;
using System.Linq;

class Player
{
    static void Main()
    {
        while (true)
        {
            int[] mountainsHeights = new int[8];

            for (int i = 0; i < 8; i++)
                mountainsHeights[i] = int.Parse(Console.ReadLine()); // from 9 to 0

            Console.WriteLine(Array.IndexOf(mountainsHeights, mountainsHeights.Max()));
        }
    }
}