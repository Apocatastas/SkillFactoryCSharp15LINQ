using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("\nPlease enter the second word: ");
            string word2 = Console.ReadLine();

            Console.WriteLine(Intersector(word1, word2));
            Console.ReadKey();
        }

        static int Intersector(string word1, string word2)
        {
            var isect = word1.Intersect(word2);
            Console.WriteLine("\nIntersection: ");
            foreach (var item in isect)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nIntersection count: ");
            return isect.Count();
        }
    }
}