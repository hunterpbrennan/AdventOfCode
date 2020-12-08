
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

bagsToCheck = [["shiny gold","1"]]


def dfs(graph,node,visited,multiplier,count):
    print(node,graph[node])
    if node not in visited:
        visited.append(node)
        for n in graph[node]:
            if n[0] != 'other':
                print(n[0])
                multiplier = multiplier*int(n[1])
                count.append(multiplier)
                print(count)
                dfs(graph,n[0],visited,multiplier,count)
                multiplier = multiplier//int(n[1])
    print()
    return visited,count

x,y = dfs(ruleGraph,"shiny gold",[],1,[])

print(sum(y))
