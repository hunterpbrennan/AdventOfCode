import os
os.chdir('AdventOfCode\\2022\\d04')

with open('d04input.txt') as f:
    lines = f.readlines()

freeElf = 0

for line in lines:
    lineStr = str(line)
    elf1start, elf1end, elf2start, elf2end = lineStr.replace('-',',').split(',')

    if(int(elf1start) >= int(elf2start) and int(elf1start) <= int(elf2end)) or (int(elf1end)>= int(elf2start) and int(elf1end)<=int(elf2end)):
        freeElf += 1
    elif(int(elf2start) >= int(elf1start) and int(elf2start) <= int(elf1end)) or (int(elf2end)>= int(elf1start) and int(elf2end)<=int(elf1end)):
        freeElf += 1
    

print(freeElf)