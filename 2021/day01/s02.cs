using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day01
{
    class S02
    {
        public void Solve(List<int> puzzleInput)
        {
            int result = 0;
            int previousSum = puzzleInput[0]+puzzleInput[1]+puzzleInput[2];
            int currentSum = puzzleInput[1]+puzzleInput[2];

            for(int index = 3; index < puzzleInput.Count(); index++) 
            {
                currentSum += puzzleInput[index];

                if(previousSum < currentSum) 
                {
                    result += 1;
                }
                previousSum -= puzzleInput[index-3]; 
                previousSum += puzzleInput[index]; 
                currentSum -= puzzleInput[index-2];
            }
            
            // Console.WriteLine(puzzleInput[puzzleInput.Count-4]);
            // Console.WriteLine(puzzleInput[puzzleInput.Count-3]);
            // Console.WriteLine(puzzleInput[puzzleInput.Count-2]);
            // Console.WriteLine(puzzleInput[puzzleInput.Count-1]);

            
            Console.WriteLine($"There are {result} measurement groups larger than the previous");
        }

        public static string InputFile = "2021/day01/d01input.txt";
    }
}