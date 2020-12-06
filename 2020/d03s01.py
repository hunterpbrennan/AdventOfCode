
inputFile = open("d03input.txt","r")

mountain = inputFile.read().splitlines()

treesHit = 0
width = len(mountain[0])
location = 0

for line in mountain:
    if line[location] == "#":
        treesHit = treesHit + 1

    location = location + 3
    location = location % width


print(treesHit)
