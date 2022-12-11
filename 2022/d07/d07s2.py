import os
os.chdir('AdventOfCode\\2022\\d07')

with open('d07input.txt') as f:
    lines = f.readlines()

instructions = []
for line in lines:
    instructions.append(line.strip('\n'))

fileSizeDirectory = {"root":0}

result = 0

currentFolder = ["root"]
currentPath = "root"

for line in instructions:
    if "$" in line:
        if line == "$ cd /":
            continue
        elif "$ cd .." in line:
            currentFolder.pop()
            if len(currentFolder) ==0:
                currentPath = ''
            else:
                currentPath = currentFolder[-1]
        elif "$ cd" in line:
            currentPath += line[5:]
            currentFolder.append(currentPath)
        elif "$ ls" in line:
            continue
    elif "dir" in line:
        if currentPath+line[4:] not in fileSizeDirectory:
            fileSizeDirectory[currentPath+line[4:]] = 0
    else:
        print(currentFolder)
        for folder in currentFolder:
            fileSizeDirectory[folder] += int(line.split(" ")[0])

for key, value in fileSizeDirectory.items():
    result = fileSizeDirectory["root"]
    if value > (fileSizeDirectory["root"]-40000000):
        print(value)
        if value < result:
            result = value
    

print(fileSizeDirectory["root"])

print(result)