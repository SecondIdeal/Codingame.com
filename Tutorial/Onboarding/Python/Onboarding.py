import sys

while 1:
    enemy_1_name        = raw_input()  
    enemy_1_distance    = int(raw_input())  
    enemy_2_name        = raw_input()  
    enemy_2_distance    = int(raw_input()) 
    
    print (enemy_1_name if enemy_1_distance < enemy_2_distance else enemy_2_name)