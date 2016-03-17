while (true) {
    mountainsHeights = []

    for (var i = 0; i < 8; i++)
        mountainsHeights[i] = parseInt(readline()); // from 9 to 0

    print(mountainsHeights.indexOf(Math.max.apply(null, mountainsHeights)));
}