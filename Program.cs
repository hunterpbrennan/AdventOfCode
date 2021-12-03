using System;
using System.Collections.Generic;
using Day01 = AdventOfCode.Y2021.Day01;
using Day02 = AdventOfCode.Y2021.Day02;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // SolveDay01();
            SolveDay02();
        }

        public static List<string> GetInput(string inputFile)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),inputFile);
            var result = new List<string>();
            using(var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    result.Add(line);
                    line = reader.ReadLine();
                }
            }

            return result;
        }

        public static void SolveDay01()
        {
            Console.WriteLine("Solving day 01");
            
            var day01Puzzle = new Day01.S01();
            var day02Puzzle = new Day01.S02();

            var puzzle01Input = GetInput(Day01.S01.InputFile);
            day01Puzzle.Solve(puzzle01Input);
            day02Puzzle.Solve(puzzle01Input);

            Console.WriteLine("Day solved");
        }

        public static void SolveDay02()
        {
            Console.WriteLine("Solving day 01");
            
            var day01Puzzle = new Day02.S01();
            var day02Puzzle = new Day02.S02();

            var puzzle01Input = GetInput(Day02.S01.InputFile);
            day01Puzzle.Solve(puzzle01Input);
            //day02Puzzle.Solve(puzzle01Input);

            Console.WriteLine("Day solved");
        }
    }
}