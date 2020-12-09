
inputFile = open("d07input.txt","r")

baggageRules = inputFile.read().split('\n')

contentsOfShinyGold = []

numberOfBags = []

ruleGraph = {}

for rule in baggageRules:
    rule = rule.replace(' bag.','').replace(' bags.','').replace(' bags','').replace(' bag','').replace('  ',' ')
    
    node = rule.split(" contain ")
    contents = node[1].split(",")
    for i,s in enumerate(contents):
        contents[i] = s.strip().split(" ",1)
        contents[i].reverse()
    ruleGraph[node[0].strip()] = contents

def dfs(graph,node,multiplier,count):
    for n in graph[node[0]]:
        if n[0] != 'other':
            multiplier = multiplier*int(n[1])
            count = count + multiplier
            count = dfs(graph,n,multiplier,count)
            multiplier = multiplier//int(n[1])
    return count

totalBags = dfs(ruleGraph,["shiny gold",1],1,0)

print(totalBags)
