using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day03
{
    class S01
    {
        public void Solve(List<string> puzzleInput)
        {
            int result = 0;
            List<int> binaries = new List<int>(new int[puzzleInput[0].Length]);

            foreach(string line in puzzleInput)
            {
                for(int index = 0; index < line.Length; index++)
                {
                    if(line[index] == '1')
                    {
                        binaries[index]++;
                    }
                    else
                    {
                        binaries[index]--;
                    }
                }
            }
            for(int index = 0; index<binaries.Count; index++)
            {
                Console.WriteLine(binaries[index]);
                if (binaries[index] > 0)
                {
                    GammaRate += "1";
                    EpsilonRate += "0";
                }
                else
                {
                    GammaRate += "0";
                    EpsilonRate += "1";
                }
            }

            int gammaDecimal =  Convert.ToInt32(GammaRate,2);
            int epsilonDecimal =  Convert.ToInt32(EpsilonRate,2);
            result = gammaDecimal * epsilonDecimal;

            Console.WriteLine($"{result} is the result and {gammaDecimal} is the GammaRate and {epsilonDecimal} is the EpsilonRate");
        }

        public string InputFile = "2021/day03/input.txt";
        public string GammaRate = "";
        public string EpsilonRate = "";

    }
}