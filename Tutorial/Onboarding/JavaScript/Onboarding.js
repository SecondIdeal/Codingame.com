while (true) {
    enemy1 = readline(); // name of enemy 1
    dist1 = parseInt(readline()); // distance to enemy 1
    enemy2 = readline(); // name of enemy 2
    dist2 = parseInt(readline()); // distance to enemy 2

    print(dist1 < dist2 ? enemy1 : enemy2); // You have to output a correct ship name to shoot ("Buzz", enemy1, enemy2, ...)
}