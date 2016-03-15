surfaceN = parseInt(readline()); // the number of points used to draw the surface of Mars.
for (var i = 0; i < surfaceN; i++) {
    inputs = readline().split(' ');
    landX = parseInt(inputs[0]); // X coordinate of a surface point. (0 to 6999)
    landY = parseInt(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
}

while (true) {
    inputs  = readline().split(' ');
    X       = parseInt(inputs[0]);
    Y       = parseInt(inputs[1]);
    hSpeed  = parseInt(inputs[2]); // the horizontal speed (in m/s), can be negative.
    vSpeed  = parseInt(inputs[3]); // the vertical speed (in m/s), can be negative.
    fuel    = parseInt(inputs[4]); // the quantity of remaining fuel in liters.
    rotate  = parseInt(inputs[5]); // the rotation angle in degrees (-90 to 90).
    power   = parseInt(inputs[6]); // the thrust power (0 to 4).

    print(vSpeed < -36 ? '0 4' : '0 0');
}