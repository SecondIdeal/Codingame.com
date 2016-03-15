import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfHorses = in.nextInt();

        int[] strenghtsArray = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++)
            strenghtsArray[i] = in.nextInt();

        Arrays.sort(strenghtsArray);

        int difference = strenghtsArray[1] - strenghtsArray[0];

        for (int i = 0; i < numberOfHorses - 1; i++)
            difference = Math.min(difference, (strenghtsArray[i + 1] - strenghtsArray[i]));

        System.out.println(difference);
    }
}