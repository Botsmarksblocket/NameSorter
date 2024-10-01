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

