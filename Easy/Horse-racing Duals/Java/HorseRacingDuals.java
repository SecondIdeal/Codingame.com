import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfHorses = in.nextInt();

        int[] horsesStrenghts = new int[numberOfHorses];

        for (int i = 0; i < numberOfHorses; i++)
            horsesStrenghts[i] = in.nextInt();

        Arrays.sort(horsesStrenghts);

        int minStrenghtDifference = horsesStrenghts[1] - horsesStrenghts[0];

        for (int i = 0; i < numberOfHorses - 1; i++)
            minStrenghtDifference = Math.min(minStrenghtDifference, (horsesStrenghts[i + 1] - horsesStrenghts[i]));

        System.out.println(minStrenghtDifference);
    }
}