
inputFile = open("d02input.txt","r")

passwords = inputFile.read().splitlines()

validPasswords = 0

for line in passwords:
    rule,password = line.split(': ')
    length,letter = rule.split(' ')
    mini,maxi = length.split('-')
    positionOne = int(mini)
    positionTwo = int(maxi)
    
    if password[positionOne-1] == letter and password[positionTwo-1] != letter:
        validPasswords = validPasswords+1
    if password[positionOne-1] != letter and password[positionTwo-1] == letter:
        validPasswords = validPasswords+1
            
    
    
print(validPasswords)

