
inputFile = open("d02input.txt","r")

passwords = inputFile.read().splitlines()

validPasswords = 0

for line in passwords:
    rule,password = line.split(': ')
    length,letter = rule.split(' ')
    mini,maxi = length.split('-')
    mini = int(mini)
    maxi = int(maxi)

    count = 0
    for character in password:
        if character == letter:
            count = count+1
    if mini <= count and count <= maxi:
        validPasswords = validPasswords+1
            
    
    
print(validPasswords)

