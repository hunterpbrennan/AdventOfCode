
inputFile = open("d07input.txt","r")

baggageRules = inputFile.read().split('\n')

containsShinyGoldBag = set([])

ruleGraph = {}

for rule in baggageRules:
    rule = ''.join(i for i in rule if not i.isdigit())

    rule = rule.replace(' bag.','').replace(' bags.','').replace(' bags','').replace(' bag','').replace('  ',' ')
    
    node = rule.split(" contain ")
    for innerBag in node[1].split(","):
        if innerBag.strip() in ruleGraph:
            ruleGraph[innerBag.strip()].append(node[0].strip())
        else:
            ruleGraph[innerBag.strip()] = [node[0].strip()]

bagsToCheck = ["shiny gold"]

while len(bagsToCheck) != 0:
    if bagsToCheck[0] in ruleGraph.keys():
        for bag in ruleGraph[bagsToCheck[0]]:
            if bag not in containsShinyGoldBag:
                bagsToCheck.append(bag)
                containsShinyGoldBag.add(bag)
    bagsToCheck.pop(0)

print(len(containsShinyGoldBag))
