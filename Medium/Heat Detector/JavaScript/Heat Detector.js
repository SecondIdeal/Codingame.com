[width, height] = readline().split(' ');
maxTurns = parseInt(readline());
[X0, Y0] = readline().split(' ');

// Coordinates of new window from min to max
minX = 0, maxX = parseInt(width) - 1, minY = 0, maxY = parseInt(height) - 1;

while (true) {
    bombDirection = readline(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

    if (bombDirection.indexOf('L') >= 0)
        maxX = parseInt(X0) - 1;
    else if (bombDirection.indexOf('R') >= 0)
        minX = parseInt(X0) + 1;

    if (bombDirection[0] == 'U')
        maxY = parseInt(Y0) - 1;
    else if (bombDirection[0] == 'D')
        minY = parseInt(Y0) + 1;

    X0 = (minX + maxX) / 2;
    Y0 = (minY + maxY) / 2;

    print(Math.floor(X0) + " " + Math.floor(Y0));
}