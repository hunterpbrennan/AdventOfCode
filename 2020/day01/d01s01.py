

inputFile = open("d01p01input.txt","r")

entries = inputFile.read().splitlines()

for x in entries:
    if str(2020-int(x)) in entries:
        print(x)
        print(2020-int(x))
        print(int(x)*(2020-int(x)))

