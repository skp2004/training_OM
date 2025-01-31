
using System;
using System.Collections.Generic;
namespace MyApp
{
    class List
    {
        public static void ShowListOperations()
        {
            List<string> names = ["shashwat", "yovan", "kirtan", "Jay"];

            Console.WriteLine("List elements:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"My name is {names[0]}");

            names.Remove("yovan");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            if (names.Contains("kirtan"))
            {
                Console.WriteLine("\n'Kirtan' in the list.");
            }
            names.Sort();
            Console.WriteLine("\nSorted List:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"\nTotal elements in list: {names.Count}");
        }
    }
}