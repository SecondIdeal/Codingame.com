[numberOfFloors, areaWidth, maxNumberOfRounds, exitFloor, exitPosition, totalClones, additionalElevators, numberOfElevators] = readline().split(' ');

exitsArray = [];
exitsArray[exitFloor] = parseInt(exitPosition);

for (i = 0; i < numberOfElevators; i++) {
    [elevatorFloor, elevatorPosition] = readline().split(' ');

    exitsArray[elevatorFloor] = parseInt(elevatorPosition);
}

while (true) {
    [leadingCloneFloor, leadingClonePosition, leadingCloneDirection] = readline().split(' ');

    print(
        (leadingCloneFloor == -1) ? 'WAIT' :
        (leadingCloneDirection == 'RIGHT' && leadingClonePosition > exitsArray[leadingCloneFloor] ||
        leadingCloneDirection == 'LEFT' && leadingClonePosition < exitsArray[leadingCloneFloor]) ?
        'BLOCK' : 'WAIT');
}