using System;

class Solution
{
    static void Main()
    {
        int numerOfValues = int.Parse(Console.ReadLine());
        string[] stockValues = Console.ReadLine().Split();
        int[] values = new int[numerOfValues];

        int maxLoss = 0;
        int lowestVal = int.MaxValue;

        for (int i = 0; i < numerOfValues; i++)
            values[i] = int.Parse(stockValues[i]);

        for (int i = numerOfValues - 1; i > -1; i--)
        {
            if (values[i] < lowestVal)
                lowestVal = values[i];
            else if (lowestVal - values[i] < maxLoss)
                maxLoss = lowestVal - values[i];
        }
        Console.WriteLine(maxLoss);
    }
}