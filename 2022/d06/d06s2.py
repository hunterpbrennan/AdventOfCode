import os
os.chdir('AdventOfCode\\2022\\d06')

with open('d06input.txt') as f:
    characters = f.read()

endOfSequenceIndex = 0

dupeCheck = []

for index, letter in enumerate(characters):
    if len(dupeCheck) == 14:
        dupeCheck.pop(0)
    dupeCheck.append(letter)
    if len(set(dupeCheck)) == 14:
        print(index+1)
        break