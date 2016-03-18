import sys
import math

count_of_temperatures = int(input())
if (count_of_temperatures == 0):
    print("0");
else:
    temps = input().split(" ")  # the n temperatures expressed as integers ranging from -273 to 5526
    
    nearest_to_zero = 5527;
    for i in range(count_of_temperatures):
        if abs(int(temps[i])) < abs(nearest_to_zero):
            nearest_to_zero = int(temps[i]);
        elif abs(int(temps[i])) == abs(nearest_to_zero):
            nearest_to_zero = max(int(temps[i]), nearest_to_zero);
    
    print(nearest_to_zero)