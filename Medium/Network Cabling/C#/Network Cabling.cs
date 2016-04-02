using System;
using System.Linq;
using System.Collections.Generic;

internal class Solution
{
    private static void Main()
    {
        List<int> listXCoordinates = new List<int>();
        List<int> listYCoordinates = new List<int>();

        int numberOfBuildings = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfBuildings; i++)
        {
            string[] coordinatesOfTheBuildings = Console.ReadLine().Split(' ');
            listXCoordinates.Add(int.Parse(coordinatesOfTheBuildings[0]));
            listYCoordinates.Add(int.Parse(coordinatesOfTheBuildings[1]));
        }

        int cableYPosition = (listYCoordinates.Max() - listYCoordinates.Min()) / 2;
        int minimalCableLength = listXCoordinates.Max() - listXCoordinates.Min();

        for (int i = 0; i < numberOfBuildings; i++)
        {
            int distanceFromMainCableToBuilding = Math.Abs(cableYPosition - listYCoordinates[i]);
            minimalCableLength = minimalCableLength + distanceFromMainCableToBuilding;
        }
        Console.WriteLine(minimalCableLength);
    }
}