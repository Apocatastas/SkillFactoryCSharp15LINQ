using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 3, 2, 0, 9, 56, 4, 23, 88, 12, 123, 9, 0, 4, 5 };

            Console.WriteLine(Average(numbers).ToString());
            Console.ReadKey();
        }

        static double Average(int[] numbers)
        {
            return numbers.Sum() / (double)numbers.Length;
        }
    }
}

