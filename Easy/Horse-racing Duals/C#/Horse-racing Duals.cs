using System;

class Solution
{
    static void Main(string[] args)
    {
        int numberOfHorses = int.Parse(Console.ReadLine());

        int[] strenghtsArray = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++)
        {
            strenghtsArray[i] = int.Parse(Console.ReadLine()); // The strength of each horse
        }

        Array.Sort(strenghtsArray);

        int difference = int.MaxValue; // The difference between the two closest strengths.

        for (int i = strenghtsArray.Length - 1; i >= 0; i--)
        {
            if (i != 0) // Cannot compare first element with previous
            {
                if (strenghtsArray[i] - strenghtsArray[i - 1] < difference)
                    difference = strenghtsArray[i] - strenghtsArray[i - 1];
            }
        }
        Console.WriteLine(difference);
    }
}