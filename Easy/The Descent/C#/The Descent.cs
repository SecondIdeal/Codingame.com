using System;
using System.Linq;

class Player
{
    static void Main()
    {
        while (true)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int spaceX = inputs[0];
            int spaceY = inputs[1];

            int[] heightsArray = new int[8];

            for (int i = 0; i < 8; i++)
                heightsArray[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.

            Console.WriteLine(spaceX == Array.IndexOf(heightsArray, heightsArray.Max()) ? "Fire" : "Hold");
        }
    }
}