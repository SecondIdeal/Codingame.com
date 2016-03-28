<?php
fscanf(STDIN, "%d", $numberOfSurfacePoints); # used to draw the surface of Mars
for ($i = 0; $i < $numberOfSurfacePoints ; $i++)
    fscanf(STDIN, "%d %d",
        $surfaceCoordinateX , // 0 to 6999
        $surfaceCoordinateY // 0 to 2999
    );

while (TRUE)
{
    fscanf(STDIN, "%d %d %d %d %d %d %d",
        $landerCoordinateX, // in meters
        $landerCoordinateY, // in meters
        $horizontalSpeed, // in m/s, can be negative
        $verticalSpeed, // in m/s, can be negative
        $fuelRemainig, // in liters
        $rotationAngle, // in degrees (-90 to 90)
        $thrustPower // 0 to 4
    );
    $thrustPower = (abs($verticalSpeed) > 39) ? "4" : "0";
    echo("0 $thrustPower\n");
}
?>