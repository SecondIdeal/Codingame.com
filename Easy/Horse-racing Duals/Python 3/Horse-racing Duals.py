import sys
import math

number_of_horses = int(input())

horses_strenghts = []

for i in range(number_of_horses):
    horses_strenghts.append(int(input()))

horses_strenghts.sort();

min_strenght_difference = horses_strenghts[1] - horses_strenghts[0];

for i in range(number_of_horses - 1):
    min_strenght_difference = min(min_strenght_difference, horses_strenghts[i + 1] - horses_strenghts[i])

print(min_strenght_difference)