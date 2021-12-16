using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day06
{
    class S02
    {
        public void Solve()
        {
            long result = 0;
            ReadInput();
            //PrintCycleCount();

            for(var day = 0; day< 256; day++)
            {
                var oldFish = LanternFishAgeGroups[0];
                for(var age = 1; age<9;age++)
                {
                    LanternFishAgeGroups[age-1] = LanternFishAgeGroups[age];
                }
                LanternFishAgeGroups[8] = oldFish;
                LanternFishAgeGroups[6] += oldFish;
                //PrintCycleCount();

            }

            result = LanternFishAgeGroups.Sum();

            Console.WriteLine($"{result} is the result");
        }
        public void ReadInput()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),InputFile);
            using(var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                if(line is not null)
                {
                    foreach(var fish in line.Split(',').Select(Int32.Parse).ToList())
                    {
                        LanternFishAgeGroups[fish]++;
                    }
                }
            }
        }
        public void PrintCycleCount()
        {
            foreach(var age in LanternFishAgeGroups)
            {
                Console.Write(age + " ");
            }
            Console.WriteLine();
        }

        public string InputFile = "2021/day06/input.txt";
        public long[] LanternFishAgeGroups = new long[9];
    }
}