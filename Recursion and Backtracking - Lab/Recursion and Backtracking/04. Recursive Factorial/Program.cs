using System;

namespace _04._Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            long factorial = 1;
            Console.WriteLine(CalculateFactorial(num));
        }

        private static long CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * CalculateFactorial(num - 1);
        }
    }
}
