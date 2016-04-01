using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string nextLine = Console.ReadLine();
        int numberOfLineToOutPut = int.Parse(Console.ReadLine()); // The index of the first line is 1.

        for (int i = 1; i < numberOfLineToOutPut; i++)
        {
            string previousLine = nextLine;

            List<string> nextLineList = new List<string>();
            string[] previousLineArray = previousLine.Split(' ');

            for (int j = 0; j < previousLineArray.Length; j++)
            {
                if (nextLineList.Count == 0)
                {
                    nextLineList.Add("1");
                    nextLineList.Add(previousLineArray[j]);
                }
                else
                {
                    if (previousLineArray[j] == nextLineList[nextLineList.Count - 1])
                        nextLineList[nextLineList.Count - 2] = (int.Parse(nextLineList[nextLineList.Count - 2]) + 1).ToString();
                    else
                    {
                        nextLineList.Add("1");
                        nextLineList.Add(previousLineArray[j]);
                    }
                }
            }
            nextLine = string.Join(" ", nextLineList.ToArray());
        }
        Console.WriteLine(nextLine);
    }
}