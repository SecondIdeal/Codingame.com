import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        while (true) {
            int spaceX = in.nextInt();
            int spaceY = in.nextInt();

            int[] heightsArray = new int[8];
            int maxValue = 0; int indexOfMax = 0;

            for (int i = 0; i < 8; i++) {
                heightsArray[i] = in.nextInt(); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.

                if (heightsArray[i] > maxValue)
                {
                    maxValue = heightsArray[i];
                    indexOfMax = i;
                }
            }
            System.out.println(spaceX == indexOfMax ? "Fire" : "Hold");
        }
    }
}