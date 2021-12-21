using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day09
{
    class S02
    {
        public void Solve()
        {
            int result = 0;
            ReadInput();
            foreach(var row in HeightMap)
            {
                foreach(var height in row)
                {
                    Console.Write(height+ " ");
                }
                Console.WriteLine();
            }

            for(int columnIndex = 0; columnIndex <HeightMap.Count();columnIndex++)
            {
                for(int rowIndex = 0; rowIndex <HeightMap[columnIndex].Count();rowIndex++)
                {
                    if(columnIndex<=0 || HeightMap[columnIndex-1][rowIndex]>HeightMap[columnIndex][rowIndex])
                    {
                        if(columnIndex>=HeightMap.Count()-1 || HeightMap[columnIndex+1][rowIndex]>HeightMap[columnIndex][rowIndex])
                        {
                            if(rowIndex<=0 || HeightMap[columnIndex][rowIndex-1]>HeightMap[columnIndex][rowIndex])
                            {
                                if(rowIndex>=HeightMap[columnIndex].Count()-1 || HeightMap[columnIndex][rowIndex+1]>HeightMap[columnIndex][rowIndex])
                                {
                                    result+= HeightMap[columnIndex][rowIndex]+1;
                                }
                            }
                        }
                    }
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
                while(line is not null)
                {
                    List<int> temp = new List<int>();
                    foreach(var value in line.ToList())
                    {
                        temp.Add(value-'0');
                    }
                    HeightMap.Add(new List<int>(temp));
                    temp.Clear();
                    line = reader.ReadLine();
                }
            }
        }

        public string InputFile = "2021/day09/example.txt";
        public List<List<int>> HeightMap = new List<List<int>>();
    }
}