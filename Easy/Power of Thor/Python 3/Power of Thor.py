import sys

light_x, light_y, initial_tx, initial_ty = [int(i) for i in input().split()]

while 1:

    if light_x > initial_tx:
        initial_tx += 1
        directionX = "E"
    elif light_x < initial_tx:
        initial_tx -= 1
        directionX = "W"
    else:
        directionX = ""
    
    if light_y > initial_ty:
        initial_ty += 1
        directionY = "S"
    elif light_y < initial_ty:
        initial_ty -= 1
        directionY = "N"
    else:
       directionY = ""
        
    print(directionY + directionX)