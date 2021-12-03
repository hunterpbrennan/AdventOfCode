using System;
using System.Collections.Generic;
using AdventOfCode.Y2021.Day01;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving day 01");
            
            var day01Puzzle = new S01();
            var day02Puzzle = new S02();

            var puzzle01Input = GetInput(S01.InputFile);
            day01Puzzle.Solve(puzzle01Input);
            day02Puzzle.Solve(puzzle01Input);

            Console.WriteLine("Day solved");
        }

        public static List<int> GetInput(string inputFile)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),inputFile);
            var result = new List<int>();
            using(var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = int.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}