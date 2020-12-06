
inputFile = open("d06input.txt","r")

customsAnswers = inputFile.read().split('\n\n')

sumYes = 0

for group in customsAnswers:
    groupYes = set({})
    groupsAnswers = group.split('\n')
    groupYes = set(list(groupsAnswers[0]))
    for personAnswers in groupsAnswers:
        groupYes = groupYes.intersection(set(list(personAnswers)))
    sumYes = sumYes+len(groupYes)

print(sumYes)
