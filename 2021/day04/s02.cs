using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2021.Day04
{
    class S02
    {
        public void Solve()
        {
            int result = 0;

            result = findResult(result);

            Console.WriteLine($"{result} is the result ");
        }

        private int findResult(int result)
        {
            foreach (var bingoNumber in NumberOrder)
            {
                (int, int) spot = (0, 0);
                var board = new List<List<(string, int)>>();
                var b = 0;
                while (b < BingoBoards.Count())
                {
                    board = BingoBoards[b];
                    spot = FindNumber(board, bingoNumber);
                    if(spot.Item1 <6)
                    {
                        //Console.WriteLine(spot.Item1 + " " +spot.Item2);

                        if (CheckForBingo(board, spot.Item1, spot.Item2))
                        {
                            if(BingoBoards.Count()>1)
                            {
                                PrintBoard(board);
                                BingoBoards.RemoveAt(b);
                            }
                            else
                            {
                                result = CountScore(board);
                                PrintBoards();
                                PrintBoard(board);
                                Console.WriteLine(result +" * "+ bingoNumber);
                                return(result * Int32.Parse(bingoNumber));
                            }
                        }else
                        {
                            b++;
                        }   
                    } else
                    {
                        b++;
                    }
                }
            }

            return result;
        }

        public List<string> ReadInput()
        {
            var puzzleInput = new List<string>();

            var path = Path.Combine(Directory.GetCurrentDirectory(),InputFile);
            var result = new List<string>();
            using(var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                NumberOrder = line.Split(',').ToList();
                line = reader.ReadLine();
                var bingoBoardLine = new List<string>();
                while(line != null)
                {
                    
                    for( int i =0; i<5; i++)
                    {
                        bingoBoardLine = System.Text.RegularExpressions.Regex.Split( reader.ReadLine().Trim() ,@"\s+").ToList();
                        foreach(var number in bingoBoardLine)
                        {
                            BingoBoardRow.Add((number, 0));
                        }
                        BingoBoard.Add(BingoBoardRow.ToList());
                        BingoBoardRow.Clear();
                    }
                    BingoBoards.Add(BingoBoard.ToList());
                    BingoBoard.Clear();
                    line = reader.ReadLine();
                }
            }

            return puzzleInput;
        }

        public string InputFile = "2021/day04/input.txt";
        public List <string> NumberOrder = new List<string>();
        public List<List<List<(string,int)>>> BingoBoards = new  List<List<List<(string,int)>>>();
        public List<List<(string,int)>> BingoBoard = new List<List<(string,int)>>();
        public List<(string,int)> BingoBoardRow = new List<(string,int)>();

        public void PrintBoards()
        {
            foreach(var board in BingoBoards)
            {
                foreach(var row in board)
                {
                    foreach(var number in row)
                    {
                        Console.Write("("+number.Item1 + "," + number.Item2+") ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public void PrintBoard(List<List<(string,int)>> board)
        {
            foreach(var row in board)
            {
                foreach(var number in row)
                {
                    Console.Write("("+number.Item1 + "," + number.Item2+") ");
                }
                Console.WriteLine();
            }
        }
        public bool CheckForBingo(List<List<(string,int)>> board, int row, int column)
        {
            var winningVertical = true;
            var winningHorizontal = true;
            var i = 0;
            var j = 0;
            while(winningVertical && (i<5))
            {
                if (board[row][i].Item2 == 0)
                {
                    winningVertical = false;
                    break;
                }
                i++;
            }
            while(winningHorizontal && (j<5))
            {
                if (board[j][column].Item2 == 0)
                {
                    winningHorizontal = false;
                    break;
                }
                j++;
            }
            return (winningHorizontal || winningVertical);
        }
        public (int,int) FindNumber(List<List<(string,int)>> board,string bingoNumber)
        {
            (int,int) coord = (6,6);

            for(var i =0; i<board.Count(); i++)
            {
                for(var j =0; j<board[i].Count(); j++)
                {
                    if(board[i][j].Item1 == bingoNumber)
                    {
                        board[i][j]= (board[i][j].Item1,1);
                        coord = (i,j);
                    }
                }
            }

            return coord; 
        }
        public int CountScore(List<List<(string,int)>> board)
        {
            var total = 0;

            foreach(var row in board)
            {
                foreach(var number in row)
                {
                    if(number.Item2==0)
                    {
                        total += Int32.Parse(number.Item1);
                    }
                }
            }
            return total;
        }
    }
}