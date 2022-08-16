using System;

namespace _03._Generating_0_1_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var array = new int[n];

            Generate01(array, 0);
        }

        private static void Generate01(int[] array, int index)
        {

            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(string.Empty,array));
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                array[index] = i;

                Generate01(array,index + 1);
            }
        }
    }
}
