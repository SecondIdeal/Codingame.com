import sys
import math

while True:

    mountain_heights = []

    for i in range(8):
        mountain_heights.append(int(input())) # from 9 to 0.
    print(mountain_heights.index(max(mountain_heights)))
