numberOfHorses = parseInt(readline());

strenghtsArray = [];

for (i = 0; i < numberOfHorses ; i++)
    strenghtsArray[i] = parseInt(readline());

strenghtsArray = strenghtsArray.sort(function (a, b) {
    if (a > b) return 1;
    if (a < b) return -1;
})

difference = strenghtsArray[1] - strenghtsArray[0];
for (i = 0; i < numberOfHorses - 1; i++)
    difference = Math.min(difference, strenghtsArray[i + 1] - strenghtsArray[i]);

print(difference);