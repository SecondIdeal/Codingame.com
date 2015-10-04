using System;

class Solution
{
    static void Main(string[] args)
    {
        int numerOfValues = int.Parse(Console.ReadLine());
        string stockValues = Console.ReadLine();
        
        string[] row = stockValues.Split();
        int[] values = new int[numerOfValues];

        int up = 0; int down = 0;
        int min = 0; int maxDiff = 0;

        for (int i = 0; i < numerOfValues; i++)
        {
            values[i] = int.Parse(row[i]);
            if (values[i] > values[min])
                min = i;

            int diff = values[i] - values[min];
            if (diff < maxDiff)
            {
                up = min;
                down = i;
                maxDiff = diff;
            }
        }
        if (maxDiff > 0) { maxDiff = 0; }

        Console.WriteLine(maxDiff);
    }
}