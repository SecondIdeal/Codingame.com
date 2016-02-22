using System;

class Solution
{
    static void Main(string[] args)
    {
        int countOfTemperatures = int.Parse(Console.ReadLine());
        if (countOfTemperatures == 0)
            Console.WriteLine("0");
        else
        {
            int[] temps = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            int nearestToZero = int.MaxValue;
            for (int i = 0; i < temps.Length; i++)
                nearestToZero = 
                Math.Abs(temps[i]) < Math.Abs(nearestToZero) ? temps[i] :
                Math.Abs(temps[i]) > Math.Abs(nearestToZero) ? nearestToZero : 
                Math.Max(temps[i], nearestToZero);
            
            Console.WriteLine(nearestToZero);
        }
    }
}