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
            int result = 0;
            ReadInput();
            BuildGrid();

            foreach(var coordPair in CoordsList)
            {
                if(coordPair.Horizontal)
                {
                    var start = Math.Min(coordPair.XStarting,coordPair.XEnding);
                    var end = Math.Max(coordPair.XStarting,coordPair.XEnding);
                    for(var vent = start; vent <= end; vent++)
                    {
                        Grid[coordPair.YStarting][vent] += 1;
                    }
                }
                if(coordPair.Vertical)
                {
                    var start = Math.Min(coordPair.YStarting,coordPair.YEnding);
                    var end = Math.Max(coordPair.YStarting,coordPair.YEnding);
                    for(var vent = start; vent <= end; vent++)
                    {
                        Grid[vent][coordPair.XStarting] += 1;
                    }
                }
                if(coordPair.Diagonal)
                {
                    var xDirection = coordPair.XStarting-coordPair.XEnding;
                    var yDirection = coordPair.YStarting-coordPair.YEnding;
                    var j = coordPair.YStarting;
                    if(xDirection<0 && yDirection<0)
                    {
                        for(var i = coordPair.XStarting; i<=coordPair.XEnding; i++,j++)
                        {
                            Grid[j][i] += 1;
                        }
                    }
                    if(xDirection<0 && yDirection>0)
                    {
                        for(var i = coordPair.XStarting; i<=coordPair.XEnding; i++,j--)
                        {
                            Grid[j][i] += 1;
                        }
                    }
                    if(xDirection>0 && yDirection<0)
                    {
                        for(var i = coordPair.XStarting; i>=coordPair.XEnding; i--,j++)
                        {
                            Grid[j][i] += 1;
                        }
                    }
                    if(xDirection>0 && yDirection>0)
                    {
                        for(var i = coordPair.XStarting; i>=coordPair.XEnding; i--,j--)
                        {
                            Grid[j][i] += 1;
                        }
                    }
                }
            }
            result = CountDangerSpots();

            Console.WriteLine($"{result} is the result");
        }
        public void ReadInput()
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
                    var y1 = Int32.Parse(insideInput.Split(new char[0])[0]);
                    var x2 = Int32.Parse(insideInput.Split(new char[0])[2]);
                    CoordsList.Add(new Coords(x1,y1,x2,y2));
                    line = reader.ReadLine();
                }
            }
        }
        public void BuildGrid()
        {
            var width = Math.Max(CoordsList.Max(x => x.XStarting),CoordsList.Max(x=> x.XEnding))+1;
            var height = Math.Max(CoordsList.Max(y => y.YStarting),CoordsList.Max(y=> y.YEnding))+1;

            for(int y = 0; y< height; y++)
            {
                Grid.Add(new List<int>(new int[width]));
            }
            
        }
        public void PrintCoordList()
        {
            foreach(var pair in CoordsList)
            {
                pair.PrintCoords();
            }
            
        }
        public void PrintGrid()
        {
            foreach(var row in Grid)
            {
                foreach(var col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public int CountDangerSpots()
        {
            var dangerSpots = 0;
            foreach(var row in Grid)
            {
                foreach(var col in row)
                {
                    if(col > 1)
                    {
                        dangerSpots ++;
                    }
                }
            }
            return dangerSpots;
        }

        public string InputFile = "2021/day05/input.txt";
        public List<Coords> CoordsList = new List<Coords>();
        public List<List<int>> Grid = new List<List<int>>();

    }
}