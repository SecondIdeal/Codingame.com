import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int road        = in.nextInt(); // the length of the road before the gap.
        int gap         = in.nextInt(); // the length of the gap.
        int platform    = in.nextInt(); // the length of the landing platform.

        while (true) {
            int speed       = in.nextInt(); // the motorbike's speed.
            int position    = in.nextInt(); // the position on the road of the motorbike.

            System.out.println(
                    position > road || speed > gap + 1 ? "SLOW" :
                    speed < gap + 1 ? "SPEED" :
                    position == road - 1 ? "JUMP" : "WAIT");
        }
    }
}