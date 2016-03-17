[buldingWidth, buldingHeight] = readline().split(' ');
maxTurnsBeforeGameOver = parseInt(readline());
[batmanPositionX, batmanPositionY] = readline().split(' ');

// Coordinates of new window from min to max
minX = 0, maxX = parseInt(buldingWidth) - 1, minY = 0, maxY = parseInt(buldingHeight) - 1;

while (true) {
    bombDirectionFromCurrentLocation = readline(); // U, UR, R, DR, D, DL, L or UL

    if (bombDirectionFromCurrentLocation.indexOf('L') >= 0)
        maxX = parseInt(batmanPositionX) - 1;
    else if (bombDirectionFromCurrentLocation.indexOf('R') >= 0)
        minX = parseInt(batmanPositionX) + 1;

    if (bombDirectionFromCurrentLocation[0] == 'U')
        maxY = parseInt(batmanPositionY) - 1;
    else if (bombDirectionFromCurrentLocation[0] == 'D')
        minY = parseInt(batmanPositionY) + 1;

    batmanPositionX = (minX + maxX) / 2;
    batmanPositionY = (minY + maxY) / 2;

    print(Math.floor(batmanPositionX) + " " + Math.floor(batmanPositionY));
}