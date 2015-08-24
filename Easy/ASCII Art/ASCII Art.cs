using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int tLenght = int.Parse(Console.ReadLine());
        int tHeight = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        Dictionary<string, string[]> characters = new Dictionary<string, string[]>();
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?";

        for (int l = 0; l < alphabet.Length; l++)
        { 
            characters.Add(alphabet.Substring(l, 1), new string[tHeight]); 
        }

        string result = "";
        for (int i = 0; i < tHeight; i++)
        {
            string ROW = Console.ReadLine();

            int position = 0;
            while (ROW.Length > 0)
            {
                string letter = alphabet.Substring(position, 1);
                characters[letter][i] = ROW.Substring(0, tLenght);
                ROW = ROW.Substring(tLenght);

                position++;
            }

            for (int x = 0; x < text.Length; x++)
            {
                string letter = text.Substring(x, 1).ToUpper();
                if (characters.ContainsKey(letter))
                {
                    result += characters[letter][i].ToString();
                }
                else
                {
                    result += characters["?"][i].ToString();
                }
            }
            result += Environment.NewLine;
        }
        Console.WriteLine(result);
    }
}