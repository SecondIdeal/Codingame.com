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
                mountainsHeights[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.

            Console.WriteLine(Array.IndexOf(mountainsHeights, mountainsHeights.Max()));
        }
    }
}