using System;

class Solution
{
    static void Main()
    {
        int numberOfHorses = int.Parse(Console.ReadLine());

        int[] strenghtsArray = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++)
            strenghtsArray[i] = int.Parse(Console.ReadLine()); // The strength of each horse

        Array.Sort(strenghtsArray);

        int difference = strenghtsArray[1] - strenghtsArray[0];
        for (int i = 0; i < numberOfHorses - 1; i++)
            difference = Math.Min(difference, strenghtsArray[i + 1] - strenghtsArray[i]);
   
        Console.WriteLine(difference);
    }
}