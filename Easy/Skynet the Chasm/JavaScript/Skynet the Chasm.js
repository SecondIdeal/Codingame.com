road        = parseInt(readline()); // the length of the road before the gap.
gap         = parseInt(readline()); // the length of the gap.
platform    = parseInt(readline()); // the length of the landing platform.

while (true) {
    speed       = parseInt(readline()); // the motorbike's speed.
    position    = parseInt(readline()); // the position on the road of the motorbike.

    print(
        position > road || speed > gap + 1 ? "SLOW" :
        speed < gap + 1 ? "SPEED" :
        position == road - 1 ? "JUMP" : "WAIT");
}