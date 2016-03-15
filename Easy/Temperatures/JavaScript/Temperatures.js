numberOfTemps = parseInt(readline()); // the number of temperatures to analyse
if (numberOfTemps == 0)
    print(0);
else {
    temps = readline().split(' ').map(Number); // the n temperatures expressed as integers ranging from -273 to 5526

    nearestToZero = 5527;
    for (i = 0; i < numberOfTemps; i++)
        nearestToZero =
            Math.abs(temps[i]) < Math.abs(nearestToZero) ? temps[i] :
            Math.abs(temps[i]) > Math.abs(nearestToZero) ? nearestToZero :
            Math.max(temps[i], nearestToZero);

    print(nearestToZero);
}