import os
os.chdir('AdventOfCode\\2022\\d02')

with open('d02input.txt') as f:
    lines = f.read().splitlines()

score = 0

for line in lines:
    choice = line.split(' ')
    if choice[1] == 'X':
        score += 1
        if choice[0] == 'A':
            score += 3
        elif choice[0] == 'C':
            score += 6
    elif choice[1] == 'Y':
        score += 2
        if choice[0] == 'B':
            score += 3
        elif choice[0] == 'A':
            score += 6
    elif choice[1] == 'Z':
        score += 3
        if choice[0] == 'C':
            score += 3
        elif choice[0] == 'B':
            score += 6

print(score)