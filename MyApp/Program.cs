// written in console 
// Console.WriteLine("Hello, World!");
// // get userInput from console
// string userName = Console.ReadLine();
// // variable in C#
// int age = 25;
// string name = "John";
// double salary = 5000.50;
// bool isEmployed = true;

// // datatypes in C#
// // 1.Value Types (Stored in Stack)
// // 2.Reference Types (Stored in Heap)

// // (A) Value Types
// //  byte
// //  shotrt
// //  ushort
// //  int
// //  uint
// //  long
// //  ulong
// //  float
// //  double 
// //  decimal
// //  char
// //  bool

// int num = 100;
// float pi = 3.14f;
// char grade = 'A';
// bool isPassed = true;

// // (B) Reference Types
// // string	Stores a sequence of characters
// // object	Can store any data type (base class of all types)
// // dynamic	Type determined at runtime (not recommended for performance)
// string message = "Hello, World!";
// object obj = 42;
// dynamic dynVar = "I can change";

// int x = 5, y = 6, z = 50;
// Console.WriteLine(x + y + z);
// float myNum = 5.75F;
// Console.WriteLine(myNum);
// double myNum = 19.99D;
// Console.WriteLine(myNum);

// // Implicit Casting
// int myInt = 9;
// double myDouble = myInt;

// Console.WriteLine(myInt);
// Console.WriteLine(myDouble);


// // Explicit Casting

// double myDouble = 9.78;
// int myInt = (int)myDouble;

// Console.WriteLine(myDouble);
// Console.WriteLine(myInt);


// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// // type conversion method 
// Console.WriteLine(Convert.ToString(myInt));
// Console.WriteLine(Convert.ToDouble(myInt));
// Console.WriteLine(Convert.ToInt32(myDouble));
// Console.WriteLine(Convert.ToString(myBool));


// // (A) Constants (const)
// // Value must be assigned at declaration.
// // Cannot be changed later.

// const double PI = 3.14159;
// // (B) Readonly (readonly)
// // Can be assigned in constructor (unlike const).
// // Value cannot change after initialization.

// class Example
// {
//     public readonly int maxLimit;

//     public Example(int limit)
//     {
//         maxLimit = limit; // Allowed inside constructor
//     }
// }



// OOPS 
// Encapsulation
// 1.Data Hiding – Prevents direct access to data.
// 2.Access Modifiers – Uses private, public, protected, etc.
// 3.Getter & Setter Methods – Controls access to private fields.
// 4.Improves Security & Code Maintainability.

// Inheritence
//  that allows a class to inherit properties and methods from another class
// eusability and establishes a relationship between classes.
using System;

class Program
{
    static void Main(string[] args)
    {
        PerformOprators();
        PerformMathOperations();
        PerformStringOperations();
        PerformAllLoops();
        Animal myAnimal = new Dog("sheru");
        Animal myDog = new Dog("tommy");
        Animal myCat = new Cat("Billo");
        myAnimal.Speak();
        myDog.Speak();
        myCat.Speak();

        myDog.SetName("Golu");
        Console.WriteLine($"The dog name is: {myDog.GetName()}");
    }
    static void PerformOprators()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Modulus: {a % b}");

        // Assignment Operators
        a += 5;  // a = a + 5
        Console.WriteLine($"After +=: {a}");
        a *= 2;  // a = a * 2
        Console.WriteLine($"After *=: {a}");

        // Comparison Operators
        Console.WriteLine($"Equal: {a == b}");
        Console.WriteLine($"Not Equal: {a != b}");
        Console.WriteLine($"Greater than: {a > b}");
        Console.WriteLine($"Less than: {a < b}");

        // Logical Operators
        bool condition1 = (a > b);
        bool condition2 = (b < 2);
        Console.WriteLine($"AND: {condition1 && condition2}");
        Console.WriteLine($"OR: {condition1 || condition2}");

        // Bitwise Operators
        Console.WriteLine($"Bitwise AND: {a & b}");
        Console.WriteLine($"Bitwise OR: {a | b}");
        Console.WriteLine($"Bitwise XOR: {a ^ b}");
        Console.WriteLine($"Bitwise Left Shift: {a << 1}");
        Console.WriteLine($"Bitwise Right Shift: {a >> 1}");

        // Unary Operators
        int c = 10;
        Console.WriteLine($"Increment: {++c}");
        Console.WriteLine($"Decrement: {--c}");


        // Type Check Operators
        object obj = "Hello";
        Console.WriteLine($"Is obj a string? {obj is string}");


        // max value 
        int max = int.MaxValue;
        // min value
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}");
    }
    static void PerformMathOperations()
    {
        double num1 = 25, num2 = 4, num4 = 10.75;

        // Power and Root
        Console.WriteLine($"Square Root: {Math.Sqrt(num1)}");
        Console.WriteLine($"Power: {Math.Pow(num1, num2)}");

        // Rounding Functions
        Console.WriteLine($"Ceiling: {Math.Ceiling(num4)}");
        Console.WriteLine($"Floor: {Math.Floor(num4)}");
        Console.WriteLine($"Round: {Math.Round(num4)}");

        // Min, Max
        Console.WriteLine($"Min: {Math.Min(num1, num2)}");
        Console.WriteLine($"Max: {Math.Max(num1, num2)}");

        // Random Number
        Random rand = new Random();
        Console.WriteLine($"Random Number (1-100): {rand.Next(1, 101)}");
    }

    static void PerformStringOperations()
    {
        string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine($"The length of the txt string is: {txt.Length}");
        string firstName = "John";
        string lastName = "Doe";
        // Uppercase and Lowercase
        Console.WriteLine($"Uppercase: {firstName.ToUpper()}");
        Console.WriteLine($"Lowercase: {lastName.ToLower()}");

        // String Concatenation
        string fullName = firstName + lastName;
        Console.WriteLine($"Concatenation (+ operator): {fullName}");

        string fullName2 = string.Concat(firstName, lastName);
        Console.WriteLine($"Concatenation (Concat method): {fullName2}");

        // String Interpolation
        string interpolatedName = $"My full name is: {firstName.Trim()} {lastName.Trim()}";
        Console.WriteLine(interpolatedName);

        // Finding Index and Substring
        string name = "John Doe";
        int charPos = name.IndexOf("D");
        string extractedLastName = name.Substring(charPos);
        Console.WriteLine($"Extracted Last Name: {extractedLastName}");
    }

    static void PerformAllLoops()
    {
        int a = 5;
        int b = 3;
        if (a + b > 10)
            Console.WriteLine("The answer is greater than 10");
        else
            Console.WriteLine("The answer is not greater than 10");

        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Jai swaminarayan {i}");
        }

        Console.WriteLine("\nWhile Loop:");
        int j = 1;
        while (j <= 3)
        {
            Console.WriteLine($"Jai swaminarayan {j}");
            j++;
        }

        Console.WriteLine("\nDo-While Loop:");
        int k = 1;
        do
        {
            Console.WriteLine($"Jai swaminarayan {k}");
            k++;
        } while (k <= 3);

        Console.WriteLine("\nForeach Loop:");
        string[] colors = { "R", "G", "B" };
        foreach (string color in colors)
        {
            Console.WriteLine($"Color: {color}");
        }
    }
    //Inheritence
    abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        // Abstract method
        public abstract void Speak();

        // Encapsulation -
        public string GetName() => name;
        public void SetName(string name) => this.name = name;
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        // Override Speak method
        public override void Speak()
        {
            Console.WriteLine($"{name} barks.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        // Override Speak method
        public override void Speak()
        {
            Console.WriteLine($"{name} meows.");
        }
    }

}




