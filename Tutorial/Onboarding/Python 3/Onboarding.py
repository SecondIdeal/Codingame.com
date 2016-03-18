import sys

while 1:
    enemy_1_name        = input()  
    enemy_1_distance    = int(input())  
    enemy_2_name        = input()  
    enemy_2_distance    = int(input()) 
    
    print (enemy_1_name if enemy_1_distance < enemy_2_distance else enemy_2_name)