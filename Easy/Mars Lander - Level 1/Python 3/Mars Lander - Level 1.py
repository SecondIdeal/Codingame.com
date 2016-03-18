import sys
import math

number_of_surface_points = int(input())  # used to draw the surface of Mars
for i in range(number_of_surface_points):
    surface_coordinate_X, surface_coordinate_Y = [int(j) for j in input().split()] # 0 to 6999 and  0 to 2999

while 1:
    # in meters, in meters, in m/s, can be negative, in m/s, can be negative, in liters, in degrees (-90 to 90), 0 to 4
    lander_coordinate_X, lander_coordinate_Y, horizontal_speed, vertical_speed, fuel_remainig, rotation_angle, thrust_power = [int(i) for i in input().split()]
    
    print("0 " + ("4" if abs(vertical_speed) > 39 else "0")); 