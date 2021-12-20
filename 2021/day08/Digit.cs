using System;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day08
{
    class Signal
    {
        public Signal(List<string> signalPattern, List<string> outputValue)
        {
            SignalPattern = signalPattern;
            OutputValue = outputValue;
        }
        public void PrintSignal()
        {
            Console.Write("Input: ");
            foreach(var code in this.SignalPattern)
            {
                Console.Write(code + " ");
            }
            Console.WriteLine();
            Console.Write("Output: ");
            foreach(var code in this.OutputValue)
            {
                Console.Write(code + " ");
            }
            Console.WriteLine();
        }
        public List<string> SignalPattern = new List<string>();
        public List<string> OutputValue = new List<string>();
    }
}