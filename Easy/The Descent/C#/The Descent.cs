using System;
using System.Linq;

class Player
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int spaceX = int.Parse(inputs[0]);
            int spaceY = int.Parse(inputs[1]);

            int[] heightsArray = new int[8];

            for (int i = 0; i < 8; i++)
            {
                heightsArray[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
            }

            int maxIndex = heightsArray.ToList().IndexOf(heightsArray.Max());

            if (spaceX == maxIndex) { Console.WriteLine("Fire"); } else { Console.WriteLine("Hold"); }
        }
    }
}