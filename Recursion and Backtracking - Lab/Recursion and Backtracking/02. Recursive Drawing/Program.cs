using System;

namespace _02._Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           RecursiveDrawing(n);

        }

        private static void RecursiveDrawing(int row)
        {
            if (row == 0)
            {
                return;
            }
            Console.WriteLine(new string('*',row));

            RecursiveDrawing(row - 1);

            Console.WriteLine(new string('#', row));
        }
    }
}
