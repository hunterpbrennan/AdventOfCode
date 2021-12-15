using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AdventOfCode.Y2021.Day05
{
    class S01
    {
        public void Solve()
        {
            int result = 0;

            Console.WriteLine($"{result} is the result");
        }
        public List<string> ReadInput()
        {
            var puzzleInput = new List<string>();

            var path = Path.Combine(Directory.GetCurrentDirectory(),InputFile);
            var result = new List<string>();
            using(var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var x1 = Int32.Parse(line.Split(',')[0]);
                    var y2 = Int32.Parse(line.Split(',')[2]);
                    var insideInput = line.Split(',')[1];
                    var x2 = Int32.Parse(insideInput.Split(new char[0])[0]);
                    var y1 = Int32.Parse(insideInput.Split(new char[0])[2]);
                    CoordsList.Add(new Coords(x1,y1,x2,y2));
                    line = reader.ReadLine();
                }
            }
            foreach(var pair in CoordsList)
            {
                Console.WriteLine(pair.XStarting+" "+pair.XEnding+" "+pair.YStarting+" "+pair.YEnding);
            }

            return puzzleInput;
        }

        public string InputFile = "2021/day05/example.txt";
        public List<Coords> CoordsList = new List<Coords>();

    }
    class Coords
    {
        public Coords(int xStart, int yStart, int xEnd, int yEnd)
        {
            XStarting = xStart;
            XEnding = xEnd;
            YStarting = yStart;
            YEnding = yEnd;
        }
        public int XStarting = -1;
        public int XEnding = -1;
        public int YStarting = -1;
        public int YEnding = -1;
    }
}