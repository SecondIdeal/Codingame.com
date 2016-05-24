using System;
using System.Collections.Generic;

internal class Solution
{
    private static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int numberOfPlaces = int.Parse(inputs[0]);
        int numberOfRuns = int.Parse(inputs[1]);
        ushort numberOfGroups = ushort.Parse(inputs[2]);

        int[] groups = new int[numberOfGroups];
        for (int i = 0; i < numberOfGroups; i++)
            groups[i] = int.Parse(Console.ReadLine());

        long money = 0;
        int positionCounter = 0;

        for (int i = 0; i < numberOfRuns; i++)
        {
            int capacity = numberOfPlaces;
            int numberOfGroupsIn = 0;

            while (capacity >= groups[positionCounter])
            {
                numberOfGroupsIn++;
                if (numberOfGroupsIn > numberOfGroups)
                    break;

                int currentCountOfPeopleInGroup = groups[positionCounter];
                money = money + currentCountOfPeopleInGroup;
                capacity = capacity - currentCountOfPeopleInGroup;

                positionCounter++;

                if (positionCounter >= numberOfGroups)
                    positionCounter = 0;
            }
        }
        Console.WriteLine(money);
    }
}