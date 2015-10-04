import java.util.*;
import java.io.*;
import java.math.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numerOfValues = in.nextInt();
        in.nextLine();
        String stockValues = in.nextLine();

        String[] row = stockValues.split(" ");
        int[] values = new int[numerOfValues];

        int up = 0; int down = 0;
        int min = 0; int maxDiff = 0;

        for (int i = 0; i < numerOfValues; i++)
        {
            values[i] = Integer.parseInt(row[i]);
            if (values[i] > values[min])
                min = i;

            int diff = values[i] - values[min];
            if (diff < maxDiff)
            {
                up = min;
                down = i;
                maxDiff = diff;
            }
        }
        if (maxDiff > 0) { maxDiff = 0; }

        System.out.println(maxDiff);
    }
}