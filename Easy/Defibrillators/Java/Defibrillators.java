import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        String LON = in.next(); // User's longitude (in degrees)
        in.nextLine();
        String LAT = in.next(); // User's latitude (in degrees)
        in.nextLine();
        int numberOfDefib = in.nextInt(); // The number N of defibrillators located in the streets of Montpellier
        in.nextLine();
        
        HashMap<Double, String> defibDictionary = new HashMap<Double, String>();

        for (int i = 0; i < numberOfDefib; i++) {
            // ID;Name;Adress;Phone number;Longitude (degrees);Latitude (degrees)
            String defibInfo = in.nextLine();

            String[] defibArray = defibInfo.split(";");

            String dName = defibArray[1];

            // Turning the comma [,] into point [.]
            double dLON = Double.parseDouble(defibArray[defibArray.length - 2].replace(",", "."));
            double dLAT = Double.parseDouble(defibArray[defibArray.length - 1].replace(",", "."));

            // The latitudes and longitudes are expressed in radians
            dLON = dLON * (180 / Math.PI);
            dLAT = dLAT * (180 / Math.PI);

            double uLON = Double.parseDouble(LON.replace(",", ".")) * (180 / Math.PI);
            double uLAT = Double.parseDouble(LAT.replace(",", ".")) * (180 / Math.PI);

            double distance = Math.sqrt(((uLON - dLON) * (uLON - dLON)) + ((uLAT - dLAT) * (uLAT - dLAT)));  // Distance between user position and defibrillator;

            defibDictionary.put(distance, dName);
        }

        double minDistance = Double.MAX_VALUE;

        for(Map.Entry<Double, String> pair : defibDictionary.entrySet()) {
            if (pair.getKey() < minDistance)
                minDistance = pair.getKey();
        }

        // The name of the defibrillator located the closest to the user’s position.
        System.out.println(defibDictionary.containsKey(minDistance) ? defibDictionary.get(minDistance) : "There is no such key in dictionary!");
    }
}