using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        double userCoordinateLON = double.Parse(Console.ReadLine().Replace(',', '.')); // in degrees
        double userCoordinateLAT = double.Parse(Console.ReadLine().Replace(',', '.')); // in degrees
        int numberOfDefib = int.Parse(Console.ReadLine());

        Dictionary<double, string> defibDistanceAndName = new Dictionary<double, string>();

        for (int i = 0; i < numberOfDefib; i++)
        {
            // ID;Name;Adress;Phone number;Longitude (degrees);Latitude (degrees)
            string[] defibFullInfo = Console.ReadLine().Split(';');

            double defibCoordinateLON = double.Parse(defibFullInfo[4].Replace(',', '.'));
            double defibCoordinateLAT = double.Parse(defibFullInfo[5].Replace(',', '.'));

            double x = (defibCoordinateLON - userCoordinateLON) * Math.Cos((userCoordinateLAT - defibCoordinateLAT) / 2);
            double y = (defibCoordinateLAT - userCoordinateLAT);

            double distanceBetweenUserAndDefib = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) * 6371;

            defibDistanceAndName.Add(distanceBetweenUserAndDefib, defibFullInfo[1]);
        }
        Console.WriteLine(defibDistanceAndName[defibDistanceAndName.Keys.Min()]);
    }
}