import java.util.*;
import java.io.*;
import java.math.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfTemps = in.nextInt(); // the number of temperatures to analyse
        in.nextLine();
        String temps = in.nextLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        if (numberOfTemps == 0)
            System.out.println(0);
        else
        {
            String[] tempsArray = temps.split(" ");

            int nearestToZero = Integer.MAX_VALUE;

            for (int i = 0; i < tempsArray.length; i++)
            {
                int temp = Integer.parseInt(tempsArray[i]);

                nearestToZero =
                        Math.abs(temp) < Math.abs(nearestToZero) ? temp :
                        Math.abs(temp) > Math.abs(nearestToZero) ? nearestToZero :
                        Math.max(temp, nearestToZero);
            }
            System.out.println(nearestToZero);
        }
    }
}