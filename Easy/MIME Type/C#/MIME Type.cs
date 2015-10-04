using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int numberOfElements = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int nubmerOfFileNames = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

        Dictionary<string, string> typeDictionary = new Dictionary<string, string>();

        for (int i = 0; i < numberOfElements; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string extension      = inputs[0]; // file extension
            string mimeType       = inputs[1]; // MIME type.

            typeDictionary.Add(extension.ToLower(), mimeType);
        }

        for (int i = 0; i < nubmerOfFileNames; i++)
        {
            string fileName = Console.ReadLine(); // One file name per line.

            if (fileName.IndexOf(".") != -1) // Checking for a dot
            {
                int indexOfSubstring = fileName.LastIndexOf(".");
                string extension = fileName.Substring(indexOfSubstring + 1).ToLower(); // Including a dot

                Console.WriteLine(typeDictionary.ContainsKey(extension) ? typeDictionary[extension] : "UNKNOWN");
            }
            else 
                Console.WriteLine("UNKNOWN");
        }
    }
}