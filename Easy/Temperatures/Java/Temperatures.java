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
            System.out.println("0");
        else
        {
            String[] tempsArray = temps.split(" ");

            int minAbs = Integer.MAX_VALUE;
            int nearestToZero = minAbs;

            for (int i = 0; i < tempsArray.length; i++)
            {
                int temp = Integer.parseInt(tempsArray[i]);
                int tempAbs = Math.abs(temp);

                if (minAbs > tempAbs) {
                    minAbs = tempAbs;
                    nearestToZero = temp; }
                else if (minAbs == tempAbs)
                    nearestToZero = Math.max(temp, nearestToZero);
            }
            System.out.println(nearestToZero);
        }
    }
}