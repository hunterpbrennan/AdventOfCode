
inputFile = open("d08input.txt","r")

inputLines = inputFile.read().split('\n')

def formatter(opCodes):
    for line in range(len(opCodes)):
        code = opCodes[line].split()
        opCodes[line] = code
        opCodes[line][1] = int(code[1])
    return opCodes

def acc(nextInstructions, total, adder):
    return nextInstructions+1,total+adder

def jmp(nextInstructions, total, adder):
    return nextInstructions+adder,total

def nop(nextInstructions, total, adder):
    return nextInstructions+1,total

operations = { "acc": acc,
               "jmp": jmp,
               "nop": nop,
               }



def runCode(opCodes):
    totalSum = 0
    previouslyRunOpCodes = set([])
    op = 0
    while op in range(len(opCodes)):
        previouslyRunOpCodes.add(op)
        op, totalSum = operations[opCodes[op][0]](op,totalSum,opCodes[op][1])
        if op in previouslyRunOpCodes:
            return(totalSum)
        
inputLines = formatter(inputLines)
print(runCode(inputLines))
