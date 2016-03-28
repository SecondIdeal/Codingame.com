<?php
fscanf(STDIN, "%d", $lenghtOfRoad);
fscanf(STDIN, "%d", $lenghtOfGap);
fscanf(STDIN, "%d", $lenghtOfPlatform);

while (TRUE)
{
    fscanf(STDIN, "%d", $motorbikeSpeed);
    fscanf(STDIN, "%d", $motorbikePosition);

    if ($motorbikePosition > $lenghtOfRoad || $motorbikeSpeed > $lenghtOfGap + 1) {
        echo "SLOW\n";
    } elseif ($motorbikeSpeed < $lenghtOfGap + 1) {
        echo "SPEED\n";
    } elseif ($motorbikePosition == $lenghtOfRoad - 1) {
        echo "JUMP\n";
    } else {
        echo "WAIT\n";
    }
}
?>