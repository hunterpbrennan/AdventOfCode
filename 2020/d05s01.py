
inputFile = open("d05input.txt","r")

flight = inputFile.read().split()
maxSeatId = 0

for boardingPass in flight:
    rows = boardingPass[0:7]
    halfRow = 64
    rowMax = 127
    rowMin = 0
    for j in range(len(rows)):
        if rows[j] == "F":
            rowMax = rowMax - halfRow
        else:
            rowMin = rowMin + halfRow
        halfRow = halfRow//2
        
    columns = boardingPass[7:10]
    halfColumn = 4
    columnMax = 7
    columnMin = 0
    for k in range(len(columns)):
        if columns[k] == "L":
            columnMax = columnMax - halfColumn
        else:
            columnMin = columnMin + halfColumn
        halfColumn = halfColumn//2

    seatId = rowMin*8+columnMin
    
    if seatId > maxSeatId:
        maxSeatId = seatId
        
print(maxSeatId)
