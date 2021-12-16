using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day06
{
    class S01
    {
        public void Solve()
        {
            int result = 0;
            ReadInput();
            //PrintAges();
            for(var day = 0; day< 80; day++)
            {
                var adultLanternFish = LanternFish.Count();
                for(var fish = 0; fish<adultLanternFish;fish++)
                {
                    LanternFish[fish] = LanternFish[fish]-1;
                    if(LanternFish[fish]<0)
                    {
                        LanternFish[fish] = 6;
                        LanternFish.Add(8);
                    }
                }
                //PrintAges();
            }

            result = LanternFish.Count();

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
                    LanternFish = line.Split(',').Select(Int32.Parse).ToList();
                }
            }
        }
        public void PrintAges()
        {
            foreach(var fish in LanternFish)
            {
                Console.Write(fish + " ");
            }
            Console.WriteLine();
        }

        public string InputFile = "2021/day06/input.txt";
        public List<int> LanternFish = new List<int>();
    }
}