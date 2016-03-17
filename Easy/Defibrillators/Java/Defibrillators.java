import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        double userCoordinateLON = Double.parseDouble(in.next().replace(",", ".")); // in degrees
        in.nextLine();
        double userCoordinateLAT = Double.parseDouble(in.next().replace(",", ".")); // in degrees
        in.nextLine();
        int numberOfDefib = in.nextInt();
        in.nextLine();

        HashMap<Double, String> defibDistanceAndName = new HashMap<Double, String>();

        for (int i = 0; i < numberOfDefib; i++) {
            // ID;Name;Adress;Phone number;Longitude (degrees);Latitude (degrees)
            String[] defibFullInfo = in.nextLine().split(";");

            double defibCoordinateLON = Double.parseDouble(defibFullInfo[4].replace(",", "."));
            double defibCoordinateLAT = Double.parseDouble(defibFullInfo[5].replace(",", "."));

            double x = (defibCoordinateLON - userCoordinateLON) * Math.cos((userCoordinateLAT - defibCoordinateLAT) / 2);
            double y = (defibCoordinateLAT - userCoordinateLAT);
            double distanceBetweenUserAndDefib = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)) * 6371;

            defibDistanceAndName.put(distanceBetweenUserAndDefib, defibFullInfo[1]);
        }

        double minDistanceFromUserToDefib = Double.MAX_VALUE;

        for(Map.Entry<Double, String> pair : defibDistanceAndName.entrySet()) {
            if (pair.getKey() < minDistanceFromUserToDefib)
                minDistanceFromUserToDefib = pair.getKey();
        }
        System.out.println(defibDistanceAndName.containsKey(minDistanceFromUserToDefib) ? defibDistanceAndName.get(minDistanceFromUserToDefib) : "There is no such key in dictionary!");
    }
}