using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {

        double LON = double.Parse(Console.ReadLine().Replace(',', '.')); // User's longitude (in degrees)
        double LAT = double.Parse(Console.ReadLine().Replace(',', '.')); // User's latitude (in degrees)
        int numberOfDefib = int.Parse(Console.ReadLine()); // The number N of defibrillators located in the streets of Montpellier

        Dictionary<double, string> defibDictionary = new Dictionary<double, string>();

        for (int i = 0; i < numberOfDefib; i++)
        {
            // ID;Name;Adress;Phone number;Longitude (degrees);Latitude (degrees)
            string[] defibArray = Console.ReadLine().Split(';');

            double dLON = double.Parse(defibArray[4].Replace(',', '.'));
            double dLAT = double.Parse(defibArray[5].Replace(',', '.'));

            double x = (dLON - LON) * Math.Cos((LAT - dLAT) / 2);
            double y = (dLAT - LAT);

            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) * 6371;

            defibDictionary.Add(distance, defibArray[1]);
        }
        Console.WriteLine(defibDictionary[defibDictionary.Keys.Min()]);
    }
}