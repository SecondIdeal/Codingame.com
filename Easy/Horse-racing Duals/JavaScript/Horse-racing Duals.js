numberOfHorses = parseInt(readline());

horsesStrenghts = [];

for (i = 0; i < numberOfHorses ; i++)
    horsesStrenghts[i] = parseInt(readline());

horsesStrenghts = horsesStrenghts.sort(function (a, b) {
    if (a > b) return 1;
    if (a < b) return -1;
})

minStrenghtDifference = horsesStrenghts[1] - horsesStrenghts[0];
for (i = 0; i < numberOfHorses - 1; i++)
    minStrenghtDifference = Math.min(minStrenghtDifference, horsesStrenghts[i + 1] - horsesStrenghts[i]);

print(minStrenghtDifference);