using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day01
{
    class S01
    {
        public void Solve(List<string> puzzleInput)
        {
            var result = 0;

            for(int index = 1; index < puzzleInput.Count; index++) 
            {
                if(int.Parse(puzzleInput[index-1]) < int.Parse(puzzleInput[index])) 
                {
                    result += 1;
                }
            }
            Console.WriteLine($"There are {result} measurements larger than the previous");
        }

        public static string InputFile = "2021/day01/input.txt";
    }
}