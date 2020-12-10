
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
        preamble.remove(int(xmas[x-(preambleSize-1)]))
    preamble.add(int(xmas[x]))


print(incorrectNumber)
