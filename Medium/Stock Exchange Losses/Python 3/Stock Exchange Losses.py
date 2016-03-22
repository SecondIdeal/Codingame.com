max_loss = 0
lowest_value = 999999
numer_of_values = int(input())
stock_values = []

for i in input().split():
    stock_values.append(int(i))

for i in range((numer_of_values - 1), -1, -1):
    if (stock_values[i] < lowest_value):
        lowest_value = stock_values[i]
    elif (lowest_value - stock_values[i] < max_loss):
        max_loss = lowest_value - stock_values[i];

print(max_loss)