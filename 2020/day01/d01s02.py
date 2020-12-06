

inputFile = open("d01p01input.txt","r")

entries = inputFile.read().splitlines()

for x in entries:
    numX = int(x)
    for y in entries:
        numY = int(y)
        if (numY+numX)<2020:
            if str(2020-numX-numY) in entries:
                print(x)
                print(y)
                print(2020-numX-numY)
                print(numX*(2020-numX-numY)*numY)
                break

