import os
os.chdir('AdventOfCode\\2022\\d01')

with open('d01input.txt') as f:
    lines = f.readlines()

mostCalorieElf = 0
elfsStash = 0
result = 0

for line in lines:
    if line != '\n':
        elfsStash += int(line)
    else:
        if elfsStash > mostCalorieElf:
            mostCalorieElf = elfsStash
        elfsStash = 0

print(mostCalorieElf)