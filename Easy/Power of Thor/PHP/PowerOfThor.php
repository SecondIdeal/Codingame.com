<?php
fscanf(STDIN, "%d %d %d %d", $lightX, $lightY, $thorX, $thorY);

while (TRUE)
{
    $direction = "";
    if ($lightY > $thorY) {
        $thorY++;
        $direction = $direction . "S";
    } else if ($lightY < $thorY) {
        $thorY--;
        $direction = $direction . "N";
    }

     if ($lightX > $thorX) {
         $thorX++;
         $direction = $direction . "E";
     } else if ($lightX < $thorX) {
         $thorX--;
         $direction = $direction . "W";
     }
    echo("$direction\n");
}
?>