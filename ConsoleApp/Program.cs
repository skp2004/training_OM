using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the My Console Application!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your country: ");
        string country = Console.ReadLine();

        Console.WriteLine("\n User Information .....");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Country: {country}");

    }
}
