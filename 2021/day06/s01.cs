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

        public string InputFile = "2021/day06/example.txt";
        public List<int> LanternFish = new List<int>();
    }
}