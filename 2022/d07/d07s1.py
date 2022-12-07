import os
os.chdir('AdventOfCode\\2022\\d07')

with open('d07input.txt') as f:
    lines = f.readlines()

instructions = []
for line in lines:
    instructions.append(line.strip('\n'))

fileDirectory = {}

result = 0

currentFolder = []
myiter = iter(instructions)

for line in myiter:
    if "$" in line:
        if line == "$ cd /":
            #print("go to root")
            currentFolder.clear()
        elif "$ cd .." in line:
            #print("move out a level")
            currentFolder.pop()
        elif "$ cd" in line:
            #print("move in a level")
            currentFolder.append(line[5:])
            if line[5:] not in fileDirectory:
                fileDirectory[line[5:]] = 0
            #print(currentFolder)
        elif "$ ls" in line:
            while '$' not in line:
                #print("should list")
                next(myiter,None)
    elif "dir" in line:
        if line[4:] not in fileDirectory:
                fileDirectory[line[4:]] = 0
    else:
        for folder in currentFolder:
            print(folder+":"+line.split(" ")[0])
            fileDirectory[folder] += int(line.split(" ")[0])

for key, value in fileDirectory.items():
    #print("directory:"+ key+ " size:"+str(value))
    if value<= 100000:
        result+= value
        
print(fileDirectory)


print(result)