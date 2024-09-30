using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Anna", "John", "Alice", "Bob", "James", "Jenny" };
            Console.WriteLine("Original list: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nSorted list");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
