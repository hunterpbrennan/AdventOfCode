
inputFile = open("d08input.txt","r")

inputLines = inputFile.read().split('\n')

def formatter(opCodes):
    for line in range(len(opCodes)):
        code = opCodes[line].split()
        opCodes[line] = code
        opCodes[line][1] = int(code[1])
    return opCodes

def acc(nextInstructions, total, adder, codeLength):
    return nextInstructions+1,total+adder

def jmp(nextInstructions, total, adder, codeLength):
    return nextInstructions+adder,total

def nop(nextInstructions, total, adder, codeLength):
    return nextInstructions+1,total

operations = { "acc": acc,
               "jmp": jmp,
               "nop": nop,
               }

def runCode(opCodes):
    totalSum = 0
    previouslyRunOpCodes = set([])
    op = 0
    while op in range(len(opCodes)-1):
        previouslyRunOpCodes.add(op)
        op, totalSum = operations[opCodes[op][0]](op,totalSum,opCodes[op][1],len(opCodes))
        if op in previouslyRunOpCodes:
            return(False,totalSum)
    return(True,totalSum)
        
inputLines = formatter(inputLines)

for code in range(len(inputLines)):
    if inputLines[code][0] == "jmp":
        inputLines[code][0] = "nop"
    elif inputLines[code][0] == "nop":
        inputLines[code][0] = "jmp"
    solved, total = runCode(inputLines)
    if inputLines[code][0] == "jmp":
        inputLines[code][0] = "nop"
    elif inputLines[code][0] == "nop":
        inputLines[code][0] = "jmp"
    if solved:
        print(total)
