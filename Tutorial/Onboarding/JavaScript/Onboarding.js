while (true) {
    enemy1Name      = readline(); 
    enemy1Distance  = parseInt(readline()); 
    enemy2Name      = readline(); 
    enemy2Distance  = parseInt(readline()); 

    print(enemy1Distance < enemy2Distance ? enemy1Name : enemy2Name);
}