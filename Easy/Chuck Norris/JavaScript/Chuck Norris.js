message = readline();

// Example: "C" >> "67"
bArray = [];

for (i = 0; i < message.length; ++i)
    bArray[i] = message.charCodeAt(i);

binary = "";
for (i = 0; i < bArray.length; i++) {
    // The input message consists of ASCII characters (7-bit)!
    temp = bArray[i].toString(2);
    temp = "0000000".substring(0, 7 - temp.length) + temp;
    binary += temp;
}

intArray = []
strArray = binary.split("");

for (i = 0; i < strArray.length ; i++)
    intArray[i] = parseInt(strArray[i]);

// It means the beginning of text
lastPosition = 2;
result = "";

for (i = 0; i < intArray.length; i++) {
    if (intArray[i] == 1)
        result += lastPosition == 1 ? "0" : lastPosition == 0 ? " 0 0" : "0 0";
    else
        result += lastPosition == 0 ? "0" : lastPosition == 1 ? " 00 0" : "00 0";

    lastPosition = intArray[i] == 1 ? 1 : 0; // new last bit
}
print(result);