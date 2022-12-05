import os
os.chdir('AdventOfCode\\2022\\d05')

with open('d05input.txt') as f:
    containerBlock, instructionBlock = f.read().split('\n\n')

instructions = instructionBlock.splitlines()
container = containerBlock.splitlines()
numberOfColumns = container.pop()
columns = numberOfColumns.split()

indexOfColumns = []

for col in columns:
    indexOfColumns.append(numberOfColumns.index(col))

shippingMatrix = [[] for x in range(len(indexOfColumns))]

for line in reversed(container):
    linelist = list(line)
    for x in range(len(linelist)):
        if linelist[x].isalpha():
            shippingMatrix[indexOfColumns.index(x)].append(linelist[x])

cratesMoved = []

for instruction in instructions:
    amount, source, destination = [int(s) for s in instruction.split() if s.isdigit()]

    for moves in range(amount):
        cratesMoved.append(shippingMatrix[source-1].pop())
    for moves in range(amount):
        shippingMatrix[destination-1].append(cratesMoved.pop())

result = ""

for rows in shippingMatrix:
    result+=rows.pop()

print(result)