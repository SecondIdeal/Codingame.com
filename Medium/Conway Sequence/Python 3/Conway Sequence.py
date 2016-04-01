next_line = input()
number_of_line_to_output = int(input()) # The index of the first line is 1.

for i in range (1, number_of_line_to_output):
    previous_line = next_line
    
    next_line_list = []
    previous_line_array = str(previous_line).replace("[", "").replace("]", "").replace(",", "").replace("\'", "").split(" ")

    for j in range(0, len(previous_line_array)):
        if (len(next_line_list) == 0):
            next_line_list.append("1")
            next_line_list.append(previous_line_array[j])
        else:
            if (previous_line_array[j] == next_line_list[len(next_line_list) - 1]):
                next_line_list[len(next_line_list) - 2] = str(int(next_line_list[len(next_line_list) - 2]) + 1)
            else:
                next_line_list.append("1")
                next_line_list.append(previous_line_array[j])
    next_line = next_line_list
print(str(next_line).replace("[", "").replace("]", "").replace(",", "").replace("\'", ""))