using System;

class Solution
{
    static void Main()
    {
        int numerOfValues = int.Parse(Console.ReadLine());
        int[] stockValues = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxLoss = 0;
        int lowestVal = int.MaxValue;

        for (int i = numerOfValues - 1; i > -1; i--)
        {
            if (stockValues[i] < lowestVal)
                lowestVal = stockValues[i];
            else if (lowestVal - stockValues[i] < maxLoss)
                maxLoss = lowestVal - stockValues[i];
        }
        Console.WriteLine(maxLoss);
    }
}