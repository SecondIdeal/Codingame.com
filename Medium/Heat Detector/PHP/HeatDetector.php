<?php
fscanf(STDIN, "%d %d", $buldingWidth, $buldingHeight);
fscanf(STDIN, "%d", $maxTurnsBeforeGameOver);
fscanf(STDIN, "%d %d", $batmanPositionX, $batmanPositionY);

// Coordinates of new window from min to max
$minX = 0;
$maxX = $buldingWidth - 1;
$minY = 0;
$maxY = $buldingHeight - 1;

while (TRUE)
{
    fscanf(STDIN, "%s", $bombDirectionFromCurrentLocation); // U, UR, R, DR, D, DL, L or UL

    if (substr_count($bombDirectionFromCurrentLocation, 'L') > 0)
        $maxX = $batmanPositionX - 1;
    else if (substr_count($bombDirectionFromCurrentLocation, 'R') > 0)
        $minX = $batmanPositionX + 1;

    if ($bombDirectionFromCurrentLocation[0] == 'U')
        $maxY = $batmanPositionY - 1;
    else if ($bombDirectionFromCurrentLocation[0] == 'D')
        $minY = $batmanPositionY + 1;

    $batmanPositionX = round(($minX + $maxX) / 2);
    $batmanPositionY = round(($minY + $maxY) / 2);

    echo($batmanPositionX . " " . "$batmanPositionY\n");
}
?>