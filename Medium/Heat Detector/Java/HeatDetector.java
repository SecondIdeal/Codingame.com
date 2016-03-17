import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        int buldingWidth = in.nextInt();
        int buldingHeight = in.nextInt();
        in.nextLine();
        int maxTurnsBeforeGameOver = in.nextInt();
        in.nextLine();

        int batmanPositionX = in.nextInt();
        int batmanPositionY = in.nextInt();
        in.nextLine();

        // Coordinates of new window from min to max
        int minX = 0, maxX = buldingWidth - 1, minY = 0, maxY = buldingHeight - 1;

        while (true) {
            String bombDirectionFromCurrentLocation = in.next(); // U, UR, R, DR, D, DL, L or UL
            in.nextLine();

            if (bombDirectionFromCurrentLocation.indexOf('L') >= 0)
                maxX = batmanPositionX - 1;
            else if (bombDirectionFromCurrentLocation.indexOf('R') >= 0)
                minX = batmanPositionX + 1;

            if (bombDirectionFromCurrentLocation.charAt(0) == 'U')
                maxY = batmanPositionY - 1;
            else if (bombDirectionFromCurrentLocation.charAt(0) == 'D')
                minY = batmanPositionY + 1;

            batmanPositionX = (minX + maxX) / 2;
            batmanPositionY = (minY + maxY) / 2;

            System.out.println(batmanPositionX + " " + batmanPositionY);
        }
    }
}