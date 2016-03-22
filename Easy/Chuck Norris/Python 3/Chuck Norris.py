message = input()
binary_message = ' '.join(format(ord(every_character), 'b') for every_character in message).zfill(7).replace(" ", "")
print("binary_message = " + binary_message, file=sys.stderr)

binary_message = ' '.join(format(ord(every_character), 'b') for every_character in message)

last_position = 2 # It means the beginning of text
encoded_message = ""

for i in range(len(binary_message)):
    if (int(binary_message[i]) == 1):
        encoded_message += "0" if last_position == 1 else " 0 0" if last_position == 0 else "0 0"
    else:
        encoded_message += "0" if last_position == 0 else " 00 0" if last_position == 1 else "00 0"

    last_position = 1 if int(binary_message[i]) == 1 else 0 # new last bit

print(encoded_message);