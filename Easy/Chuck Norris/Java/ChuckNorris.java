import java.util.*;
import java.io.*;

class Solution {

    public static void main(String args[]) throws UnsupportedEncodingException {
        Scanner in = new Scanner(System.in);
        String message = in.nextLine();

        byte[] bArray = message.getBytes("US-ASCII");

        // Example: "C" >> "67"
        String binary = "";
        for (int i = 0; i < bArray.length; i++)
        {
            binary += String.format("%7s", (Integer.toBinaryString(bArray[i]))).replace(' ', '0');
        }

        char[] chars = binary.toCharArray();

        // It means the beginning of text
        int lastPosition    = 2;
        String result       = "";

        // ASCII >> 49 = 1; 48 = 0
        for (int i = 0; i < chars.length; i++)
        {
            if (chars[i] == '1')
            {
                if (lastPosition == 1)
                    result += "0";
                else if (lastPosition == 0)
                    result += " 0 0";
                else // beginning
                    result += "0 0";
                lastPosition = 1; // new last bit
            }
            else
            {
                if (lastPosition == 0)
                    result += "0";
                else if (lastPosition == 1)
                    result += " 00 0";
                else // beginning
                    result += "00 0";
                lastPosition = 0; // new last bit
            }
        }
        System.out.println(result);
    }
}