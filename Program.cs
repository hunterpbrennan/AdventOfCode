using System;
using System.IO;
using System.Collections.Generic;
using Day01 = AdventOfCode.Y2021.Day01;
using Day02 = AdventOfCode.Y2021.Day02;
using Day03 = AdventOfCode.Y2021.Day03;
using Day04 = AdventOfCode.Y2021.Day04;
using Day05 = AdventOfCode.Y2021.Day05;
using Day06 = AdventOfCode.Y2021.Day06;


namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //SolveDay01();
            //SolveDay02();
            //SolveDay03();
            //SolveDay04();
            //SolveDay05();
            SolveDay06();
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
            Console.WriteLine("Solving day 02");
            
            var day01Puzzle = new Day02.S01();
            var day02Puzzle = new Day02.S02();

            var puzzle01Input = GetInput(Day02.S01.InputFile);
            day01Puzzle.Solve(puzzle01Input);
            day02Puzzle.Solve(puzzle01Input);

            Console.WriteLine("Day solved");
        }

        public static void SolveDay03()
        {
            Console.WriteLine("Solving day 03");
            
            var star1Puzzle = new Day03.S01();
            var star2Puzzle = new Day03.S02();

            var puzzle1Input = GetInput(star1Puzzle.InputFile);
            var puzzle2Input = GetInput(star2Puzzle.InputFile);
            star1Puzzle.Solve(puzzle1Input);
            star2Puzzle.Solve(puzzle2Input);

            Console.WriteLine("Day solved");
        }
        public static void SolveDay04()
        {
            Console.WriteLine("Solving day 04");
            
            var star1Puzzle = new Day04.S01();
            var star2Puzzle = new Day04.S02();

            star1Puzzle.ReadInput();
            star2Puzzle.ReadInput();

            star1Puzzle.Solve();
            star2Puzzle.Solve();

            Console.WriteLine("Day solved");
        }

        public static void SolveDay05()
        {
            Console.WriteLine("Solving day 05");
            
            var star1Puzzle = new Day05.S01();
            var star2Puzzle = new Day05.S02();

            star1Puzzle.Solve();
            star2Puzzle.Solve();

            Console.WriteLine("Day solved");
        }

        public static void SolveDay06()
        {
            Console.WriteLine("Solving day 06");
            
            var star1Puzzle = new Day06.S01();
            var star2Puzzle = new Day06.S02();

            star1Puzzle.Solve();
            star2Puzzle.Solve();

            Console.WriteLine("Day solved");
        }
    }
}