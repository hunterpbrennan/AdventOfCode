import os
os.chdir('AdventOfCode\\2022\\d02')

with open('d02input.txt') as f:
    lines = f.read().splitlines()

score = 0

for line in lines:
    choice = line.split(' ')
    if choice[1] == 'X':
        score += 0
        if choice[0] == 'A':
            score += 3
        elif choice[0] == 'B':
            score += 1
        elif choice[0] == 'C':
            score += 2
    elif choice[1] == 'Y':
        score += 3
        if choice[0] == 'A':
            score += 1
        elif choice[0] == 'B':
            score += 2
        elif choice[0] == 'C':
            score += 3
    elif choice[1] == 'Z':
        score += 6
        if choice[0] == 'A':
            score += 2
        elif choice[0] == 'B':
            score += 3
        elif choice[0] == 'C':
            score += 1

print(score)