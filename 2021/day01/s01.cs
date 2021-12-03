using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day01
{
    class S01
    {
        public void Solve(List<int> puzzleInput)
        {
            var result = 0;
            int previous = 0;

            foreach( var line in puzzleInput) 
            {
                if(previous != 0 && line > previous) 
                {
                    result += 1;
                }
                previous = line;
            }

            
            Console.WriteLine($"There are {result} measurements larger than the previous");
        }

        public static string InputFile = "2021/day01/d01input.txt";
    }
}