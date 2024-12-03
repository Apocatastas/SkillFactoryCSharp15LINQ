using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 72345678901 },
               new Contact() { Name = "Сергей", Phone = 72345678901 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            int result = contacts.Count(s => (s.Phone.ToString().Length != 11)||!s.Phone.ToString().StartsWith('7'));
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

