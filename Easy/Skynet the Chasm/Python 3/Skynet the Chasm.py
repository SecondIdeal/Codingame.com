import sys

lenght_of_road        = int(input())
lenght_of_gap         = int(input())  
lenght_of_platform    = int(input())  

while True:
    motorbike_speed     = int(input())  
    motorbike_position  = int(input()) 
    
    if motorbike_position > lenght_of_road or motorbike_speed > lenght_of_gap + 1:
        answer = "SLOW"
    elif motorbike_speed < lenght_of_gap + 1:
        answer = "SPEED"
    elif motorbike_position == lenght_of_road - 1:
        answer = "JUMP"
    else:
        answer = "WAIT"
    
    print(answer)