using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day08
{
    class S02
    {
        public void Solve()
        {
            int result = 0;
            ReadInput();

            foreach(var signal in Signals)
            {
                result+= signal.ReadoutCount;
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
                    Signals.Add(new Signal(line.Split('|')[0].Trim().Split(' ').ToList(),line.Split('|')[1].Trim().Split(' ').ToList()));
                    line = reader.ReadLine();
                }
            }
        }
        public void PrintSignals()
        {
            foreach(var signal in Signals)
            {
                signal.PrintSignal();
            }
        }

        public string InputFile = "2021/day08/input.txt";
        public List<Signal> Signals = new List<Signal>();
    }
}