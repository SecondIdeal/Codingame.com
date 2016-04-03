using System;
using System.Linq;
using System.Collections.Generic;

internal class Solution
{
    private static void Main()
    {
        List<int> xCoordinates = new List<int>();
        List<int> yCoordinates = new List<int>();

        int numberOfBuildings = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfBuildings; i++)
        {
            string[] coordinatesOfTheBuildings = Console.ReadLine().Split(' ');
            xCoordinates.Add(int.Parse(coordinatesOfTheBuildings[0]));
            yCoordinates.Add(int.Parse(coordinatesOfTheBuildings[1]));
        }
        
        yCoordinates.Sort();
        long minimalCableLength = xCoordinates.Max() - xCoordinates.Min();
        int cableYPosition      = yCoordinates[numberOfBuildings % 2 == 0 ? numberOfBuildings / 2 : (numberOfBuildings - 1) / 2];

        for (int i = 0; i < numberOfBuildings; i++)
            minimalCableLength = minimalCableLength + Math.Abs(yCoordinates[i] - cableYPosition);

        Console.WriteLine(minimalCableLength);
    }
}