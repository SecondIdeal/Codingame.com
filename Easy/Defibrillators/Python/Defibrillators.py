import sys
import math

user_coordinate_LON = float(raw_input().replace(",", ".", 1))
user_coordinate_LAT = float(raw_input().replace(",", ".", 1))
number_of_defib = int(raw_input())

min_distance_from_user_t_defib = 9999999.9999999
closest_to_user_defib_name = ""

for i in range(number_of_defib):
    defib_full_info = raw_input().split(";")
    
    defib_coordinate_LON = float(defib_full_info[4].replace(",", ".", 1))
    defib_coordinate_LAT = float(defib_full_info[5].replace(",", ".", 1))

    x = (defib_coordinate_LON - user_coordinate_LON) * math.cos((user_coordinate_LAT - defib_coordinate_LAT) / 2)
    y = (defib_coordinate_LAT - user_coordinate_LAT)
    distance_between_user_and_defib = math.sqrt(math.pow(x, 2) + math.pow(y, 2)) * 6371
        
    if distance_between_user_and_defib < min_distance_from_user_t_defib:
        min_distance_from_user_t_defib = distance_between_user_and_defib
        closest_to_user_defib_name = defib_full_info[1]

print(closest_to_user_defib_name)