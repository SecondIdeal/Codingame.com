lenghtOfRoad        = parseInt(readline()); 
lenghtOfGap         = parseInt(readline()); 
lenghtOfPlatform    = parseInt(readline()); 

while (true) {
    motorbikeSpeed       = parseInt(readline()); 
    motorbikePosition    = parseInt(readline()); 

    print(
        motorbikePosition > lenghtOfRoad || motorbikeSpeed > lenghtOfGap + 1 ? "SLOW" :
        motorbikeSpeed < lenghtOfGap + 1 ? "SPEED" :
        motorbikePosition == lenghtOfRoad - 1 ? "JUMP" : "WAIT");
}