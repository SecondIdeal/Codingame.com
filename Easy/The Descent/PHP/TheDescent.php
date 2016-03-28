<?php
while (TRUE)
{
    $mountainHeights = array();
    for ($i = 0; $i < 8; $i++)
        fscanf(STDIN, "%d", $mountainHeights[$i]);

    $maxValueIndex = array_search(max($mountainHeights), $mountainHeights);
    echo("$maxValueIndex\n");
}
?>