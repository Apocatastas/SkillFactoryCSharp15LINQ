using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
            {
                "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
                "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
            foreach (var item in itCompanies)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}