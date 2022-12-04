import os
os.chdir('AdventOfCode\\2022\\d03')

with open('d03input.txt') as f:
    lines = f.read().splitlines()

priority = 0

for index in range(0,len(lines),3):
    line1, line2, line3 = lines[index],lines[index+1],lines[index+2]
    for letter in line1:
        if letter in line2 and letter in line3:
            if letter.islower():
                priority += (ord(letter)-96)
            if letter.isupper():
                priority += (ord(letter)-38)
            break

print(priority)
