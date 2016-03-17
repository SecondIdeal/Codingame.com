numberOfSurfacePoints = parseInt(readline()); // used to draw the surface of Mars
for (var i = 0; i < numberOfSurfacePoints; i++) {
    inputs = readline().split(' ');
    surfaceCoordinateX = parseInt(inputs[0]); // 0 to 6999
    surfaceCoordinateY = parseInt(inputs[1]); // 0 to 2999
}

while (true) {
    inputs  = readline().split(' ');
    landerCoordinateX   = parseInt(inputs[0]); // in meters
    landerCoordinateY   = parseInt(inputs[1]); // in meters
    horizontalSpeed     = parseInt(inputs[2]); // in m/s, can be negative
    verticalSpeed       = parseInt(inputs[3]); // in m/s, can be negative
    fuelRemainig        = parseInt(inputs[4]); // in liters
    rotationAngle       = parseInt(inputs[5]); // in degrees (-90 to 90)
    thrustPower         = parseInt(inputs[6]); // 0 to 4

    print(verticalSpeed < -36 ? '0 4' : '0 0');
}