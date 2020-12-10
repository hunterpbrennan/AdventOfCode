
inputFile = open("d09input.txt","r")

xmas = inputFile.read().split('\n')

preamble = set([])

preambleSize = 25
incorrectNumber = "oops"

for x in range(len(xmas)):
    if len(preamble) == preambleSize:
        sumExists = False
        for y in range(preambleSize):
            if (int(xmas[x])-int(xmas[x-(y+1)])) in preamble:
                sumExists = True
        if not sumExists:
            incorrectNumber = int(xmas[x])
            incorrectIndex = x
        preamble.remove(int(xmas[x-(preambleSize-1)]))
    preamble.add(int(xmas[x]))

for y in range(incorrectIndex-1,0,-1):
    tempSum = []
    z = 0
    while sum(tempSum) < incorrectNumber:
        tempSum.append(int(xmas[y-z]))
        z = z+1
    if sum(tempSum) == incorrectNumber:
        print(min(tempSum)+max(tempSum))

print(incorrectNumber)
