using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.Y2021.Day08
{
    class Signal
    {
        public Signal(List<string> signalPattern, List<string> readout)
        {
            SignalPattern = signalPattern;
            Readout = readout;
            Digits = SignalPattern.Concat(Readout).ToList();
            FindOne();
            FindFour();
            FindSeven();
            FindEight();
            FindTwo();
            FindThree();
            FindFive();
            FindSix();
            FindNine();
            FindZero();
            for(var x=0; x<10;x++)
            {
                DecodedDigits[x] = String.Concat(DecodedDigits[x].OrderBy(c=>c));
            }
            CombineReadoutToNumber();
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
            foreach(var code in this.Readout)
            {
                Console.Write(code + " ");
            }
            Console.WriteLine();
        }
        public void FindZero()
        {
            if(DecodedDigits[1] != null && DecodedDigits[4] != null)
            {
                DecodedDigits[0] = Digits.Where(x=> x.Length==6 && x.Intersect(DecodedDigits[1]).Count() == 2 && x.Intersect(DecodedDigits[4]).Count() == 3).First();
            }
        }
        public void FindOne()
        {    
            DecodedDigits[1] = Digits.Where(x=>x.Length==2).First();
        }
        public void FindTwo()
        {
            if(DecodedDigits[1] != null && DecodedDigits[4] != null)
            {
                DecodedDigits[2] = Digits.Where(x=> x.Length==5 && x.Intersect(DecodedDigits[1]).Count() == 1 && x.Intersect(DecodedDigits[4]).Count() == 2).First();
            }
        }
        public void FindThree()
        {
            if(DecodedDigits[1] != null && DecodedDigits[4] != null)
            {
                DecodedDigits[3] = Digits.Where(x=> x.Length==5 && x.Intersect(DecodedDigits[1]).Count() == 2 && x.Intersect(DecodedDigits[4]).Count() == 3).First();
            }
        }
        public void FindFour()
        {
            DecodedDigits[4] = Digits.Where(x=>x.Length==4).First();
        }
        public void FindFive()
        {
            if(DecodedDigits[1] != null && DecodedDigits[4] != null)
            {
                DecodedDigits[5] = Digits.Where(x=> x.Length==5 && x.Intersect(DecodedDigits[1]).Count() == 1 && x.Intersect(DecodedDigits[4]).Count() == 3).First();
            }
        }
        public void FindSix()
        {
            DecodedDigits[6] = Digits.Where(x=>x.Length==6 && x.Intersect(DecodedDigits[1]).Count() == 1 && x.Intersect(DecodedDigits[4]).Count() == 3).First();
        }
        public void FindSeven()
        {
            DecodedDigits[7] = Digits.Where(x=>x.Length==3).First();
        }
        public void FindEight()
        {
            DecodedDigits[8] = Digits.Where(x=>x.Length==7).First();
        }
        public void FindNine()
        {
            if(Digits is not null&&Digits.Count>0)
            {
                DecodedDigits[9] = Digits.Where(x=>x.Length==6 && x.Intersect(DecodedDigits[1]).Count() == 2 && x.Intersect(DecodedDigits[4]).Count() == 4).First();
            }
        }
        public void CombineReadoutToNumber()
        {
            var digits = "";
            foreach( var digit in Readout)
            {
                digits+=(Array.IndexOf(this.DecodedDigits,String.Concat(digit.OrderBy(c=>c))).ToString());
            }
            ReadoutCount = Int32.Parse(digits);
        }
        public List<string> SignalPattern = new List<string>();
        public List<string> Readout = new List<string>();
        public List<string> Digits = new List<string>();
        public int ReadoutCount = 0;
        public string[] DecodedDigits = new string[10];
    }
}