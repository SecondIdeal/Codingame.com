import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numerOfValues = in.nextInt();
        in.nextLine();
        String[] stockValues = in.nextLine().split(" ");

        int[] values = new int[numerOfValues];
        for (int i = 0; i < numerOfValues; i++)
            values[i] = Integer.parseInt(stockValues[i]);

        int maxLoss = 0;
        int lowestVal = Integer.MAX_VALUE;

        for (int i = numerOfValues - 1; i > -1; i--)
        {
            if (values[i] < lowestVal)
                lowestVal = values[i];
            else if (lowestVal - values[i] < maxLoss)
                maxLoss = lowestVal - values[i];
        }
        System.out.println(maxLoss);
    }
}