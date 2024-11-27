using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        /// <summary>
        /// список содержащихся в строке уникальных символов
        /// без пробелов и следующих знаков препинания: , . ; :  ? !.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var punctuation = new List<char>()
            {
                ' ', ',', '.', ';', ':', '?', '!'
            };

            Console.WriteLine("Please enter the text: ");
            var text = Console.ReadLine();

            var result = text.Except(punctuation).ToArray();
            Console.WriteLine("Punctuation-free text: \n");

            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}