using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day08
{
    class S01
    {
        public void Solve()
        {
            int result = int.MaxValue;
            ReadInput();
            for(var middleDistance = NearestCrab; middleDistance<FarthestCrab; middleDistance++)
            {
                var fuelSpent = 0;
                foreach(var crab in CrabLocations)
                {
                    fuelSpent += Math.Abs(middleDistance - crab);
                }
                if(fuelSpent<result)
                {
                    result = fuelSpent;
                }
            }

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
                    CrabLocations = line.Split(',').Select(Int32.Parse).ToList();
                }
            }
            NearestCrab = CrabLocations.Min();
            FarthestCrab = CrabLocations.Max();
        }
        public void PrintLocations()
        {
            foreach(var fish in CrabLocations)
            {
                Console.Write(fish + " ");
            }
            Console.WriteLine();
        }

        public string InputFile = "2021/day08/example.txt";
        public List<int> CrabLocations = new List<int>();
        public int NearestCrab = int.MaxValue;
        public int FarthestCrab = int.MinValue;
    }
}