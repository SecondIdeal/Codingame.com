while (true) {
    mountainsHeights = []

    for (var i = 0; i < 8; i++)
        mountainsHeights[i] = parseInt(readline()); // represents the height of one mountain, from 9 to 0.

    print(mountainsHeights.indexOf(Math.max.apply(null, mountainsHeights))); // The number of the mountain to fire on.
}