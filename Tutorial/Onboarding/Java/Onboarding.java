import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        while (true) {
            String enemy1Name   = in.next();
            int enemy1Distance  = in.nextInt();
            String enemy2Name   = in.next();
            int enemy2Distance  = in.nextInt();

            System.out.println(enemy1Distance < enemy2Distance ? enemy1Name: enemy2Name);
        }
    }
}