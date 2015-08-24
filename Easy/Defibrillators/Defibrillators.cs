using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string LON = Console.ReadLine(); // User's longitude (in degrees)
        string LAT = Console.ReadLine(); // User's latitude (in degrees)
        int N = int.Parse(Console.ReadLine()); // The number N of defibrillators located in the streets of Montpellier

        Dictionary<double, string> defibDictionary = new Dictionary<double, string>();

        for (int i = 0; i < N; i++)
        {
            // ID;Name;Adress;Phone number;Longitude (degrees);Latitude (degrees)
            string defibInfo = Console.ReadLine();

            string[] defibArray = defibInfo.Split(';');

            string dName = defibArray[1];

            // Turning the comma [,] into point [.]
            double dLON = Convert.ToDouble(defibArray[defibArray.Length - 2].Replace(",", "."));
            double dLAT = Convert.ToDouble(defibArray[defibArray.Length - 1].Replace(",", "."));

            // The latitudes and longitudes are expressed in radians
            dLON = dLON * (180 / Math.PI);
            dLAT = dLAT * (180 / Math.PI);

            double uLON = Convert.ToDouble(LON.Replace(",", ".")) * (180 / Math.PI);
            double uLAT = Convert.ToDouble(LAT.Replace(",", ".")) * (180 / Math.PI);

            double distance = Math.Sqrt(((uLON - dLON) * (uLON - dLON)) + ((uLAT - dLAT) * (uLAT - dLAT)));  // Distance between user position and defibrillator;

            defibDictionary.Add(distance, dName);
        }

        double minDistance = double.MaxValue;
        foreach (var pair in defibDictionary)
        {
            if (pair.Key < minDistance) { minDistance = pair.Key; }
        }

        // The name of the defibrillator located the closest to the user’s position.
        if (defibDictionary.ContainsKey(minDistance)) 
        { 
            Console.WriteLine(defibDictionary[minDistance]); 
        }
        else { Console.WriteLine("There is no such key in dictionary!"); }
    }
}