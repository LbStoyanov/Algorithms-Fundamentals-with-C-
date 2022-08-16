using System;

namespace _07._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFibonacci(num));
        }

        private static long CalculateFibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
        }
    }
}
