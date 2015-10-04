import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int road = in.nextInt(); // the length of the road before the gap.
        int gap = in.nextInt(); // the length of the gap.
        int platform = in.nextInt(); // the length of the landing platform.

        boolean hasJumped = false;

        while (true) {
            int speed = in.nextInt(); // the motorbike's speed.
            int position = in.nextInt(); // the position on the road of the motorbike.

            if (hasJumped || speed > (gap + 1))
                System.out.println("SLOW");
            else if (position == (road - 1)) {
                hasJumped = true;
                System.out.println("JUMP"); }
            else if (speed == (gap + 1))
                System.out.println("WAIT");
            else
                System.out.println("SPEED");
        }
    }
}