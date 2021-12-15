using System;

namespace AdventOfCode.Y2021.Day05
{
    class Coords
    {
        public Coords(int xStart, int yStart, int xEnd, int yEnd)
        {
            XStarting = xStart;
            XEnding = xEnd;
            YStarting = yStart;
            YEnding = yEnd;
            if(XStarting == XEnding)
            {
                Vertical = true;
            }
            else if(YStarting == YEnding)
            {
                Horizontal = true;
            } else
            {
                Diagonal = true;
            }
        }
        public void PrintCoords()
        {
            Console.WriteLine("X1: " + this.XStarting + " Y1: " + this.YStarting + " X2: " + this.XEnding + " Y2: " + this.YEnding);
        }
        public int XStarting = -1;
        public int XEnding = -1;
        public int YStarting = -1;
        public int YEnding = -1;
        public bool Horizontal = false;
        public bool Vertical = false;
        public bool Diagonal = false;

    }
}