
inputFile = open("d03input.txt","r")

mountain = inputFile.read().splitlines()

treesHit, product = 0,1
depth, width = len(mountain),len(mountain[0])

slopeList = [[1,1],[3,1],[5,1],[7,1],[1,2]]

for slope in slopeList:
    acrossSlope,downSlope = slope
    location, line = 0,0
    treesHit = 0
    while line < depth:
        if mountain[line][location] == "#":
            treesHit = treesHit + 1
        location = location + acrossSlope
        location = location % width
        line = line + downSlope
    product = product*treesHit


print(product)
