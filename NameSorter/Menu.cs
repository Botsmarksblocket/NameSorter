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
                {
                    case "add":
                        name = InputMethods.EnterName("Enter the name that you want to add to the list: ");

                        if (!InputMethods.ValidName(name))
                        {
                            Console.WriteLine("Invalid name. Please enter name with only alphabetic characters.");
                        }
                        else
                        {
                            finalName = InputMethods.CapitalizeName(name);
                            InputMethods.AddNameToList(finalName);
                            Console.WriteLine($"You have successully added {finalName} to the list!");
                            break;
                        }
                        break;

                    case "remove":
                        name = InputMethods.EnterName("Enter the name that you want to remove from the list: ");
                        finalName = InputMethods.CapitalizeName(name);
                        InputMethods.RemoveName(finalName);
                        break;

                    case "print":
                        Console.WriteLine("Printed list: ");
                        InputMethods.PrintList();
                        break;

                    case "sort":
                        InputMethods.SortList();
                        break;

                    case "search":
                        name = InputMethods.EnterName("Enter the name that you want to search for: ");
                        finalName = InputMethods.CapitalizeName(name);
                        InputMethods.SearchName(finalName);
                        break;

            } while (userInput != "exit");
        }
    }
}
