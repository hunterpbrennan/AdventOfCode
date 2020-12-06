
inputFile = open("d06input.txt","r")

customsAnswers = inputFile.read().split('\n\n')

sumYes = 0

for group in customsAnswers:
    groupYes = set({})
    groupsAnswers = group.split('\n')
    for personAnswers in groupsAnswers:
        groupYes.update(list(personAnswers))
    sumYes = sumYes+len(groupYes)

print(sumYes)
