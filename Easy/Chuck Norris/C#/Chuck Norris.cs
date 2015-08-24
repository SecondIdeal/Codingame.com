using System;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();

        // Example: "C" >> "67"
        byte[] bArray = Encoding.ASCII.GetBytes(message);

        string binary = String.Empty;
        foreach (byte bit in bArray)
        {
            // The input message consists of ASCII characters (7-bit)!
            binary += Convert.ToString(bit, 2).PadLeft(7, '0');
        }

        int[] intArray = binary.Select(o => Convert.ToInt32(o)).ToArray();

        // It means the beginning of text
        int lastPosition    = 2;
        string result       = "";

        // ASCII >> 49 = 1; 48 = 0
        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == 49)
            {
                if (lastPosition == 1)
                {
                    result += "0";
                }
                else if (lastPosition == 0)
                {
                    result += " 0 0";
                }
                else // beginning
                {
                    result += "0 0";
                }
                lastPosition = 1; // new last bit
            }
            else
            {
                if (lastPosition == 0)
                {
                    result += "0";
                }
                else if (lastPosition == 1)
                {
                    result += " 00 0";
                }
                else // beginning
                {
                    result += "00 0";
                }
                lastPosition = 0; // new last bit
            }
        }
        Console.WriteLine(result);
    }
}



