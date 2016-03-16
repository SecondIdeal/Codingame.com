userLON = parseFloat(readline().replace(',', '.'));
userLAT = parseFloat(readline().replace(',', '.'));
numberOfDefib = parseInt(readline());

minDistance = Infinity;
closestDefibName = "";

for (i = 0; i < numberOfDefib; i++) {
    defibArray = readline().split(";");

    defibLON = parseFloat(defibArray[4].replace(',', '.'));
    defibLAT = parseFloat(defibArray[5].replace(',', '.'));

    x = (defibLON - userLON) * Math.cos((userLAT - defibLAT) / 2);
    y = (defibLAT - userLAT);

    distance = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)) * 6371;
    if (distance < minDistance) {
        minDistance = distance;
        closestDefibName = defibArray[1];
    }
}
print(closestDefibName);