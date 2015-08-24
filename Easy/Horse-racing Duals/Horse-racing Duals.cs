using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of horses

        int[] strenghtArray = new int[N];

        for (int i = 0; i < N; i++)
        {
            strenghtArray[i] = int.Parse(Console.ReadLine()); // The strength of each horse
        }

        Array.Sort(strenghtArray);

        int diff = int.MaxValue; // The difference between the two closest strengths.
        
        for (int i = strenghtArray.Length - 1; i >= 0; i--)
        {
            if (i != 0) // Cannot compare first element with previous
            {
                if (strenghtArray[i] - strenghtArray[i - 1] < diff)
                {
                    diff = strenghtArray[i] - strenghtArray[i - 1];
                }
            }
        }
        Console.WriteLine(diff);
    }
}