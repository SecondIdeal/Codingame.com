import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        int width = in.nextInt(); // width of the building.
        int height = in.nextInt(); // height of the building.
        in.nextLine();
        int maxTurns = in.nextInt(); // maximum number of turns before game over.
        in.nextLine();

        int X0 = in.nextInt();
        int Y0 = in.nextInt();
        in.nextLine();

        // Coordinates of new window from min to max
        int minX = 0, maxX = width - 1, minY = 0, maxY = height - 1;

        while (true) {
            String BOMB_DIR = in.next(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            in.nextLine();

            if (BOMB_DIR.indexOf('L') >= 0)
                maxX = X0 - 1;
            else if (BOMB_DIR.indexOf('R') >= 0)
                minX = X0 + 1;

            if (BOMB_DIR.charAt(0) == 'U')
                maxY = Y0 - 1;
            else if (BOMB_DIR.charAt(0) == 'D')
                minY = Y0 + 1;

            X0 = (minX + maxX) / 2;
            Y0 = (minY + maxY) / 2;

            System.out.println(X0 + " " + Y0);
        }
    }
}