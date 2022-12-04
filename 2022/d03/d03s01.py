import os
os.chdir('AdventOfCode\\2022\\d03')

with open('d03input.txt') as f:
    lines = f.read().splitlines()

priority = 0

for line in lines:
    halfOne, halfTwo = line[:len(line)//2],line[len(line)//2:]
    for letter in halfOne:
        if letter in halfTwo:
            if letter.islower():
                priority += (ord(letter)-96)
            if letter.isupper():
                priority += (ord(letter)-38)
            break

print(priority)
