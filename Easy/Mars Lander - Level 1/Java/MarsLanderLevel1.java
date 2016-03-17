import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int numberOfSurfacePoints = in.nextInt(); // used to draw the surface of Mars
        for (int i = 0; i < numberOfSurfacePoints; i++) {
            int surfaceCoordinateX = in.nextInt(); // 0 to 6999
            int surfaceCoordinateY = in.nextInt(); // 0 to 2999
        }
        
        while (true) {
            int landerCoordinateX   = in.nextInt(); // in meters
            int landerCoordinateY   = in.nextInt(); // in meters
            int horizontalSpeed     = in.nextInt(); // in m/s, can be negative
            int verticalSpeed       = in.nextInt(); // in m/s, can be negative
            int fuelRemainig        = in.nextInt(); // in liters
            int rotationAngle       = in.nextInt(); // in degrees (-90 to 90)
            int thrustPower         = in.nextInt(); // 0 to 4

            System.out.println("0 " + ((Math.abs(verticalSpeed) > 39) ? "4" : "0"));
        }
    }
}