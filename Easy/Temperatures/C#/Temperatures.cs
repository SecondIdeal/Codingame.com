using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int countTemp = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526

        if (countTemp == 0)
            Console.WriteLine("0");
        else
        {
            string[] tempArray = temps.Split(' ');

            int minAbs = int.MaxValue;
            int nearestToZero = minAbs;

            for (int i = 0; i < tempArray.Length; i++)
            {
                int temp = int.Parse(tempArray[i]);
                int tempAbs = Math.Abs(temp);

                if (minAbs > tempAbs) {
                    minAbs = tempAbs;
                    nearestToZero = temp; }
                else if (minAbs == tempAbs)
                    nearestToZero = Math.Max(temp, nearestToZero);
            }
            Console.WriteLine(nearestToZero);
        }
    }
}