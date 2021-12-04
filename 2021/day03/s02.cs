using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day03
{
    class S02
    {
        public void Solve(List<string> puzzleInput)
        {
            int result = 0;
            var binary = 0;
            var oxygenList = new List<string>(puzzleInput);
            var oxygenTempList = new List<string>();
            var co2List = new List<string>(puzzleInput);
            var co2TempList = new List<string>();
            var co2oxyIndex = 0;

            while(oxygenList.Count > 1)
            {
                binary = 0;
                foreach(string line in oxygenList)
                {
                    if(line[co2oxyIndex] == '1')
                    {
                        binary++;
                    }
                    else
                    {
                        binary--;
                    }
                }
                foreach(string line in oxygenList)
                {
                    if((binary >= 0 && line[co2oxyIndex] == '1') || ((binary < 0 && line[co2oxyIndex] == '0')))
                    {
                        oxygenTempList.Add(line);
                    }
                }
                oxygenList = new List<string>(oxygenTempList);
                oxygenTempList.Clear();
                co2oxyIndex++;
            }
            OxygenGeneratorRating = oxygenList[0];

            co2oxyIndex = 0;
            while(co2List.Count > 1)
            {
                binary = 0;
                foreach(string line in co2List)
                {
                    if(line[co2oxyIndex] == '1')
                    {
                        binary++;
                    }
                    else
                    {
                        binary--;
                    }
                }
                foreach(string line in co2List)
                {
                    if((binary >= 0 && line[co2oxyIndex] == '0') || ((binary < 0 && line[co2oxyIndex] == '1')))
                    {
                        co2TempList.Add(line);
                    }
                }
                co2List = new List<string>(co2TempList);
                co2TempList.Clear();
                co2oxyIndex++;
            }
            CO2ScrubberRating = co2List[0];

            int oxygenDecimal =  Convert.ToInt32(OxygenGeneratorRating,2);
            int co2Decimal =  Convert.ToInt32(CO2ScrubberRating,2);
            result = oxygenDecimal * co2Decimal;

            Console.WriteLine($"{result} is the result and {oxygenDecimal} is the OxygenRating and {co2Decimal} is the CO2Rating");
        }

        public string InputFile = "2021/day03/input.txt";
        public string OxygenGeneratorRating = "";
        public string CO2ScrubberRating = "";
    }
}