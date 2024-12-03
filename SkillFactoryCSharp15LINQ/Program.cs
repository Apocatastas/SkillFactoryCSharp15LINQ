using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            int osn = Convert.ToInt32(Console.ReadLine());
            List<int> ints = new List<int>();
            for (int i = 1; i <= osn; i++)
            {
                ints.Add(i);
            }
            double result = ints.Aggregate((x, y) => x*y);
            Console.WriteLine("\nFactorial {0} = {1}", osn, result);
            Console.ReadKey();
        }
    }
}