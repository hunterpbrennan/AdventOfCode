
with open('d01input.txt') as f:
    lines = f.readlines()

mostCalorieElf = 0
secondCalorieElf = 0
thirdCalorieElf = 0
elfsStash = 0
result = 0

for line in lines:
    if line is not '\n':
        elfsStash += int(line)
    else:
        if elfsStash >= mostCalorieElf:
            thirdCalorieElf = secondCalorieElf
            secondCalorieElf = mostCalorieElf
            mostCalorieElf = elfsStash
        elif elfsStash >= secondCalorieElf:
            thirdCalorieElf = secondCalorieElf
            secondCalorieElf = elfsStash
        elif elfsStash >= thirdCalorieElf:
            thirdCalorieElf = elfsStash
        elfsStash = 0

if elfsStash >= mostCalorieElf:
    thirdCalorieElf = secondCalorieElf
    secondCalorieElf = mostCalorieElf
    mostCalorieElf = elfsStash
elif elfsStash >= secondCalorieElf:
    thirdCalorieElf = secondCalorieElf
    secondCalorieElf = elfsStash
elif elfsStash >= thirdCalorieElf:
    thirdCalorieElf = elfsStash
elfsStash = 0

print(mostCalorieElf+secondCalorieElf+thirdCalorieElf)