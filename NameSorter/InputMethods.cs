using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NameSorter
{
    class InputMethods
    {
        static List<string> names = new List<string>() { "Anna", "John", "Alice", "Bob", "James", "Jenny" }; //Creates a list that contains a few names

        public static string EnterName(string prompt) //Allows user to enter a name
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim(); //Removes all white-space before and after the string
            Console.Clear();

            return input;            
        }

        public static bool ValidName(string name)//Checks that the name only contains alphabetic characters
        {
            return Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ]+$");
        }

        public static string CapitalizeName(string name)//Makes the first letter in the name to uppercase and the subsequent lowercase
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                return string.Empty;
            }
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        public static void AddNameToList(string formattedName)//Adds the formatted name to the names.list
        {
            names.Add(formattedName);
        }

        public static void PrintList()//Prints all the names from the list
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public static void SortList()//Sorts the list and prints it
        {
            names.Sort();
            Console.WriteLine("Sorted list:");
            PrintList();
        }

        public static void RemoveName(string name)//Removes a name from the list
        {
            Console.Clear();
            if (names.Contains(name))
            {
                names.Remove(name);
                Console.WriteLine($"{name} was removed from the list.");
            }
            else
            {
                Console.WriteLine($"{name} does not exist in the list.");
            }
        }

        public static void SearchName(string name)//Searchs for a name from the list
        {
            Console.Clear();
            if (names.Contains(name))
            {
                Console.WriteLine($"{name} is in the list.");
            }
            else
            {
                Console.WriteLine($"{name} does not exist in the list.");
            }
        }
    }
}
