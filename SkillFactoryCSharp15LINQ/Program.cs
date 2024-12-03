using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var vwcars = new List<string>() { "Golf", "Bora", "Passat", "Sirocco", "Beetle", "Transporter", "Atlas", "Up", "Lupo" };
            var delayed = vwcars.Where(name => name.Length>4);
            vwcars.Remove("Beetle");
            vwcars.Remove("Atlas");

            Console.WriteLine("Delayed run, Beetle and Atlas was removed after declaring:\n");
            foreach (var item in delayed)
            {
                Console.WriteLine(item);
            }

            var vwcars2 = new List<string>() { "Golf", "Bora", "Passat", "Sirocco", "Beetle", "Transporter", "Atlas", "Up", "Lupo" };
            var onthego = vwcars2.Where(name => name.Length > 4).ToArray();
            vwcars2.Remove("Beetle");
            vwcars2.Remove("Atlas");

            Console.WriteLine("Run on-the-go, Beetle and Atlas was removed after declaring:\n");
            foreach (var item in onthego)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}



