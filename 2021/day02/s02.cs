using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day02
{
    class S02
    {
        public void Solve(List<string> puzzleInput)
        {
            int result = 0;
            string direction = "";
            int distance = 0;

            foreach(string instruction in puzzleInput)
            {
                direction = instruction.Split(' ')[0];
                distance = int.Parse(instruction.Split(' ')[1]);
                if(direction == "forward")
                {
                    HorizontalPosition += distance;
                    DepthPosition += Aim*distance;
                } 
                else if(direction == "up")
                {
                    Aim -= distance;
                } 
                else if(direction == "down")
                {
                    Aim += distance;
                }
            }

            result = HorizontalPosition * DepthPosition;


            Console.WriteLine($"{result} is the product of {HorizontalPosition} and {DepthPosition}");
        }

        public static string InputFile = "2021/day02/input.txt";
        public int HorizontalPosition = 0;
        public int DepthPosition = 0;
        public int Aim = 0;
    }
}