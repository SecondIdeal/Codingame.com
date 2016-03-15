import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfFloors       = in.nextInt();
        int areaWidth            = in.nextInt();
        int maxNumberOfRounds    = in.nextInt();
        int exitFloor            = in.nextInt();
        int exitPosition         = in.nextInt();
        int totalClones          = in.nextInt();
        int additionalElevators  = in.nextInt();
        int numberOfElevators    = in.nextInt();

        int[] exitsArray = new int[numberOfFloors]; // Array of elevator/exit positions
        exitsArray[exitFloor] = exitPosition;

        for (int i = 0; i < numberOfElevators; i++) {
            int elevatorFloor        = in.nextInt();
            int elevatorPosition     = in.nextInt();

            exitsArray[elevatorFloor] = elevatorPosition;
        }

        while (true) {
            int leadingCloneFloor         = in.nextInt();
            int leadingClonePosition      = in.nextInt();
            String leadingCloneDirection  = in.next(); // direction of the leading clone: LEFT or RIGHT

            if (leadingCloneFloor == -1) // If is no clone to handle
            {
                System.out.println("WAIT");
                continue;
            }

            System.out.println(
                    leadingCloneDirection.equals("RIGHT") && leadingClonePosition > exitsArray[leadingCloneFloor] ||
                    leadingCloneDirection.equals("LEFT") && leadingClonePosition < exitsArray[leadingCloneFloor] ?
                    "BLOCK" : "WAIT");
        }
    }
}