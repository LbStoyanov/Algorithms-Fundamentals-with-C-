using System;
using System.Collections.Generic;

namespace _05._Paths_in_Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            for (int r = 0; r < row; r++)
            {
                var rowElements = Console.ReadLine();
                for (int c = 0; c < rowElements.Length; c++)
                {
                    matrix[r, c] = rowElements[c];
                }
            }

            FindPaths(matrix, 0, 0,new List<string>(),string.Empty);
        }

        private static void FindPaths(int[,] matrix, int row, int col,List<string> directions,string direction)
        {
            //Validate row and coll
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return; 
            }

            //Check for walls or already visited cells

            if (matrix[row,col] == '*' || matrix[row,col] == 'v')
            {
                return;
            }

            directions.Add(direction);

            //Check for exit
            if (matrix[row,col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty,directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            matrix[row, col] = 'v';
           

            FindPaths(matrix, row - 1,col,directions,"U");
            FindPaths(matrix, row + 1,col,directions,"D");
            FindPaths(matrix, row,col - 1,directions,"L");
            FindPaths(matrix, row,col + 1,directions,"R");

            matrix[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}
