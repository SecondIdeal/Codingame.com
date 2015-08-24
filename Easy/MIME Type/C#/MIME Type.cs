using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

        Dictionary<string, string> typeDict = new Dictionary<string, string>();

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT      = inputs[0]; // file extension
            string MT       = inputs[1]; // MIME type.

            typeDict.Add(EXT.ToLower(), MT);
        }

        for (int i = 0; i < Q; i++)
        {
            string fileName = Console.ReadLine(); // One file name per line.

            if (fileName.IndexOf(".") != -1) // Checking for a dot
            {
                int indexOfSubstring = fileName.LastIndexOf(".");
                string extension = fileName.Substring(indexOfSubstring + 1).ToLower(); // Including a dot

                if (typeDict.ContainsKey(extension))
                {
                    Console.WriteLine(typeDict[extension]);
                }
                else { Console.WriteLine("UNKNOWN"); }
            }
            else { Console.WriteLine("UNKNOWN"); }
        }
    }
}