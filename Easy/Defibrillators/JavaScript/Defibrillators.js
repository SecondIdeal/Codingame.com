userCoordinateLON = parseFloat(readline().replace(',', '.')); // in degrees
userCoordinateLAT = parseFloat(readline().replace(',', '.')); // in degrees
numberOfDefib = parseInt(readline());

minDistanceFromUserToDefib = Infinity;
closestToUserDefibName = "";

for (i = 0; i < numberOfDefib; i++) {
    defibFullInfo = readline().split(";");

    defibCoordinateLON = parseFloat(defibFullInfo[4].replace(',', '.'));
    defibCoordinateLAT = parseFloat(defibFullInfo[5].replace(',', '.'));

    x = (defibCoordinateLON - userCoordinateLON) * Math.cos((userCoordinateLAT - defibCoordinateLAT) / 2);
    y = (defibCoordinateLAT - userCoordinateLAT);

    distanceBetweenUserAndDefib = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)) * 6371;
    if (distanceBetweenUserAndDefib < minDistanceFromUserToDefib) {
        minDistanceFromUserToDefib = distanceBetweenUserAndDefib;
        closestToUserDefibName = defibFullInfo[1];
    }
}
print(closestToUserDefibName);