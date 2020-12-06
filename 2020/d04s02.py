
inputFile = open("d04input.txt","r")

passports = inputFile.read().split('\n\n')
valid = 0
allowedHair = set("abcdef0123456789")
allowedPid = set("0123456789")
allowedEye = {"amb","blu","brn","gry","grn","hzl","oth"}

for passport in passports:
    passport = passport.split()
    passportValid = 0
    '''print('\n\n',passport)'''
    for field in passport:
        field = field.split(':')
        if field[0] == "byr":
            if int(field[1]) >=1920 and int(field[1]) <=2002:
                passportValid = passportValid + 1
        if field[0] == "iyr":
            if int(field[1]) >=2010 and int(field[1]) <=2020:
                passportValid = passportValid + 1
        if field[0] == "eyr":
            if int(field[1]) >=2020 and int(field[1]) <=2030:
                passportValid = passportValid + 1
        if field[0] == "hgt":
            height = field[1].rstrip('incm')
            measure = field[1][len(height):]
            height = int(height)
            if (measure == "in" and height >=59 and height<= 76) or (measure == "cm" and height >=150 and height <=193):
                passportValid = passportValid + 1           
        if field[0] == "hcl":
            if field[1][0]=="#" and len(field[1]) == 7:
                color = field[1][1:]
                if set(color) <= allowedHair:
                    passportValid = passportValid + 1
        if field[0] == "ecl":
            if field[1] in allowedEye:
                passportValid = passportValid + 1
        if field[0] == "pid" and len(field[1]) == 9:
            if set(field[1]) <= allowedPid:
                passportValid = passportValid + 1
    
    if passportValid == 7:
        valid = valid + 1
        
print(valid)
