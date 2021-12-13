using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day01
{
    class S02
    {
        public void Solve(List<string> puzzleInput)
        {
            int result = 0;

            for(int index = 3; index < puzzleInput.Count; index++) 
            {
                if(int.Parse(puzzleInput[index-3]) < int.Parse(puzzleInput[index])) 
                {
                    result += 1;
                }
            }
            Console.WriteLine($"There are {result} measurement groups larger than the previous");
        }

        public static string InputFile = "2021/day01/input.txt";
    }
}