using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day03
{
    class S02
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
                //Console.WriteLine(binaries[index]);
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

            var oxygenList = puzzleInput;
            var oxygenTempList = new List<string>();
            var co2List = puzzleInput;
            var co2TempList = new List<string>();
            var co2oxyIndex = 0;

            while(oxygenList.Count > 1)
            {
                foreach(string line in oxygenList)
                {
                    if(GammaRate[co2oxyIndex] == line[co2oxyIndex])
                    {
                        oxygenTempList.Add(line);
                    }
                }
                co2oxyIndex++;
                oxygenList = new List<string>(oxygenTempList);
                oxygenTempList.Clear();
            }
            OxygenGeneratorRating = oxygenList[0];
            Console.WriteLine(GammaRate);
            foreach(var oxygen in oxygenList)
            {
                Console.WriteLine(oxygen);
            }


            co2oxyIndex = 0;
            while(co2List.Count > 1)
            {
                foreach(string line in co2List)
                {
                    if(EpsilonRate[co2oxyIndex] == line[co2oxyIndex])
                    {
                        co2TempList.Add(line);
                    }
                }
                co2oxyIndex++;
                co2List = new List<string>(co2TempList);
                co2TempList.Clear();
            }
            CO2ScrubberRating = co2List[0];
            foreach(var co2 in co2List)
            {
                Console.WriteLine(co2);
            }

            int oxygenDecimal =  Convert.ToInt32(OxygenGeneratorRating,2);
            int co2Decimal =  Convert.ToInt32(CO2ScrubberRating,2);
            result = oxygenDecimal * co2Decimal;

            Console.WriteLine($"{result} is the result and {oxygenDecimal} is the GammaRate and {co2Decimal} is the EpsilonRate");
        }

        public string InputFile = "2021/day03/example.txt";
        public string GammaRate = "";
        public string EpsilonRate = "";
        public string OxygenGeneratorRating = "";
        public string CO2ScrubberRating = "";


    }
}