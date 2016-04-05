numberOfBuildings = parseInt(readline());
xCoordinates = new Array();
yCoordinates = new Array();

for (var i = 0; i < numberOfBuildings; i++) {
    var coords = readline().split(' ');
    xCoordinates.push(parseInt(coords[0].valueOf()));
    yCoordinates.push(parseInt(coords[1].valueOf()));
}

yCoordinates.sort(function (a, b) { return a - b });
minimalCableLength = Math.max.apply(null, xCoordinates) - Math.min.apply(null, xCoordinates);
cableYPosition = yCoordinates[numberOfBuildings % 2 == 0 ? numberOfBuildings / 2 : (numberOfBuildings - 1) / 2];

for (var i = 0; i < numberOfBuildings; i++)
    minimalCableLength += Math.abs(yCoordinates[i] - cableYPosition);

print(minimalCableLength);
