using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    static class Menu
    {
        public static void Run()
        {
            string name;
            string finalName;
            string userInput;
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("------------------\n");
                Console.WriteLine("Add: Add a name to the list.");
                Console.WriteLine("Remove: Remove a name from the list.");
                Console.WriteLine("Print: Print the list.");
                Console.WriteLine("Sort: Sort the list.");
                Console.WriteLine("Search: Search the list for a specific name.");
                Console.WriteLine("Exit: Exit the program.");

                userInput = Console.ReadLine().ToLower();

                Console.Clear();
                switch (userInput)
            } while (userInput != "exit");
        }
    }
}
