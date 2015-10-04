import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int lightX = in.nextInt(); // the X position of the light of power
        int lightY = in.nextInt(); // the Y position of the light of power
        int thorX = in.nextInt(); // Thor's starting X position
        int thorY = in.nextInt(); // Thor's starting Y position

        while (true) {

            String directionX = "";
            if (lightX > thorX) { thorX++; directionX = "E"; } else if (lightX < thorX) { thorX--; directionX = "W"; }

            String directionY = "";
            if (lightY > thorY) { thorY++; directionY = "S"; } else if (lightY < thorY) { thorY--; directionY = "N"; }

            System.out.println((directionY) + (directionX));
        }
    }
}