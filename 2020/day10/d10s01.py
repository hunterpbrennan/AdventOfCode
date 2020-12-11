
inputFile = open("d10input.txt","r")

adapters = inputFile.read().split('\n')

adapterSet = [0]+sorted(list(map(int,adapters)))
adapterSet.append(max(adapterSet)+3)

difOne = 0
difThree = 0

currentJoltage = 0

for adapter in range(len(adapterSet)):
    if currentJoltage+1 in adapterSet:
        difOne = difOne + 1
        currentJoltage = currentJoltage + 1
    elif currentJoltage+2 in adapterSet:
        currentJoltage = currentJoltage + 2
    elif currentJoltage+3 in adapterSet:
        difThree = difThree + 1
        currentJoltage = currentJoltage + 3

print(difOne*difThree)

