using System;
using System.Linq;
using System.Text;

class Solution
{
    static void Main()
    {
        string message = Console.ReadLine();

        // Example: "C" >> "67"
        byte[] bArray = Encoding.ASCII.GetBytes(message);

        string binary = String.Empty;
        foreach (byte bit in bArray)
            // The input message consists of ASCII characters (7-bit)!
            binary += Convert.ToString(bit, 2).PadLeft(7, '0');

        int[] intArray = binary.Select(o => Convert.ToInt32(o)).ToArray();

        // It means the beginning of text
        int lastPosition    = 2;

        // ASCII >> 49 = 1; 48 = 0
        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == 49)
                Console.Write(lastPosition == 1 ? "0" : lastPosition == 0 ? " 0 0" : "0 0");
            else
                Console.Write(lastPosition == 0 ? "0" : lastPosition == 1 ? " 00 0" : "00 0");

            lastPosition = intArray[i] == 49 ? 1 : 0; // new last bit
        }
    }
}