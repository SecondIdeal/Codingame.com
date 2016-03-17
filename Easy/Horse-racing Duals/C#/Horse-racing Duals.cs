using System;

class Solution
{
    static void Main()
    {
        int numberOfHorses = int.Parse(Console.ReadLine());

        int[] horsesStrenghts = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++)
            horsesStrenghts[i] = int.Parse(Console.ReadLine()); // The strength of each horse

        Array.Sort(horsesStrenghts);

        int minStrenghtDifference = horsesStrenghts[1] - horsesStrenghts[0];
        for (int i = 0; i < numberOfHorses - 1; i++)
            minStrenghtDifference = Math.Min(minStrenghtDifference, horsesStrenghts[i + 1] - horsesStrenghts[i]);

        Console.WriteLine(minStrenghtDifference);
    }
}