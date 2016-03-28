<?php
while (TRUE)
{
    fscanf(STDIN, "%s", $enemy1Name);
    fscanf(STDIN, "%d", $enemy1Distance);
    fscanf(STDIN, "%s", $enemy2Name);
    fscanf(STDIN, "%d", $enemy2Distance);
    echo ($enemy1Distance < $enemy2Distance) ? $enemy1Name."\n" : $enemy2Name."\n";
}
?>