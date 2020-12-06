
inputFile = open("d04input.txt","r")

passports = inputFile.read().split('\n\n')
valid = 0

for passport in passports:
    if passport.count(':')==8 or (passport.count(':')==7 and passport.count("cid")==0):
        valid = valid + 1

print(valid)
