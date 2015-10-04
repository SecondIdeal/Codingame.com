import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfHorses = in.nextInt();

        int[] strenghtsArray = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++) {
            strenghtsArray[i] = in.nextInt();
        }

        Arrays.sort(strenghtsArray);

        int difference = Integer.MAX_VALUE; // The difference between the two closest strengths.

        for (int i = strenghtsArray.length - 1; i >= 0; i--)
        {
            if (i != 0) // Cannot compare first element with previous
            {
                if (strenghtsArray[i] - strenghtsArray[i - 1] < difference)
                    difference = strenghtsArray[i] - strenghtsArray[i - 1];
            }
        }
        System.out.println(difference);
    }
}