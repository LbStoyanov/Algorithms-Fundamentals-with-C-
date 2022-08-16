using System;
using System.Collections.Generic;

namespace _06._8_Queens_Puzzle
{
    internal class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        static void Main(string[] args)
        {
            bool[,] chessBoard = new bool[8, 8];

            PutQueen(chessBoard, 0);
        }

        private static void PutQueen(bool[,] chessBoard, int row)
        {
            if (row >= chessBoard.GetLength(0))
            {
                PrintChessBoard(chessBoard);

                return;
            }
            for (int col = 0; col < chessBoard.GetLength(1); col++)
            {
                if (CanPlaceQueen(row,col)) //If I can place a queen
                {
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLeftDiagonals.Add(row - col);
                    attackedRightDiagonals.Add(row + col);
                    chessBoard[row, col] = true;

                    PutQueen(chessBoard,row + 1);

                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLeftDiagonals.Remove(row - col);
                    attackedRightDiagonals.Remove(row + col);
                    chessBoard[row, col] = false;
                }
            }
        }

        private static void PrintChessBoard(bool[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    if (chessBoard[row,col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !attackedRows.Contains(row) &&
                   !attackedCols.Contains(col) &&
                   !attackedLeftDiagonals.Contains(row - col) &&
                   !attackedRightDiagonals.Contains(row + col);
            
        }
    }
}
