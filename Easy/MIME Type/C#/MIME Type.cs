using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int numberOfElements = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int numberOfFileNames = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

        Dictionary<string, string> typeDictionary = new Dictionary<string, string>();

        for (int i = 0; i < numberOfElements; i++)
        {
            string[] inputs = Console.ReadLine().Split(' '); // file extension, MIME type.
            typeDictionary.Add(inputs[0].ToLower(), inputs[1]);
        }

        for (int i = 0; i < nubmerOfFileNames; i++)
        {
            string fileName = Console.ReadLine(); // One file name per line.
            string extension = "";

            if (fileName.IndexOf(".") != -1) // Checking for a dot
                extension = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower(); // Including a dot

            Console.WriteLine(typeDictionary.ContainsKey(extension) ? typeDictionary[extension] : "UNKNOWN");
        }
    }
}