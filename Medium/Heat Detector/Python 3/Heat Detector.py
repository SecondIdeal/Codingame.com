import sys

bulding_width, bulding_height           = [int(i) for i in input().split()]
max_turns_before_game_over              = int(input())
batman_position_X, batman_position_Y    = [int(i) for i in input().split()]

# Coordinates of new window from min to max
min_X = 0
min_Y = 0
max_X = bulding_width - 1
max_Y = bulding_height - 1

while True:
    bomb_direction_from_current_location = input()  # U, UR, R, DR, D, DL, L or UL

    if bomb_direction_from_current_location.find('L') >= 0:
        max_X = batman_position_X - 1
    elif bomb_direction_from_current_location.find('R') >= 0:
        min_X = batman_position_X + 1

    if bomb_direction_from_current_location[0] == 'U':
        max_Y = batman_position_Y - 1
    elif bomb_direction_from_current_location[0] == 'D':
        min_Y = batman_position_Y + 1

    batman_position_X = int((min_X + max_X) / 2)
    batman_position_Y = int((min_Y + max_Y) / 2)

    print(str(batman_position_X) + " " + str(batman_position_Y))