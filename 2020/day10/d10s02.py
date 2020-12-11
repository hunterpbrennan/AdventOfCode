
inputFile = open("d10input.txt","r")

adapters = inputFile.read().split('\n')

adapterList = sorted(list(map(int,adapters)))
adapterList.append(max(adapterList)+3)

difOne = 0
difThree = 0

currentJoltage = 0
totalOptions = {}
totalOptions[0] = 1

for adapter in adapterList:
    if (adapter-1) not in totalOptions.keys():
        totalOptions[adapter-1] = 0
    if (adapter-2) not in totalOptions.keys():
        totalOptions[adapter-2] = 0
    if (adapter-3) not in totalOptions.keys():
        totalOptions[adapter-3] = 0

    totalOptions[adapter] = totalOptions[adapter-1] + totalOptions[adapter-2] + totalOptions[adapter-3]
    
print(totalOptions[max(adapterList)])

