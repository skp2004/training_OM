namespace MyApp
{
    class Method
    {
        public void PredefinedMethods()
        {
            Console.WriteLine("Uppercase: " + "shashwat".ToUpper());
            Console.WriteLine("Square Root of 25: " + Math.Sqrt(25));
            Console.WriteLine("Current DateTime: " + DateTime.Now);
        }

        public void UserDefined()
        {
            Console.WriteLine("Hello, Welcome to C#!");
        }

        public void methodWithParameter(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }


        public int methodwithReturn(int a, int b)
        {
            return a + b;
        }

        // Method Overloading
        public void PrintValue(int number)
        {
            Console.WriteLine($"Integer: {number}");
        }

        public void PrintValue(double number)
        {
            Console.WriteLine($"Double: {number}");
        }

        public void PrintValue(string text)
        {
            Console.WriteLine($"String: {text}");
        }

        //  Static Method
        public static void Static()
        {
            Console.WriteLine("This is a static method!");
        }

        //  Instance Method
        public int InstanceMethod(int a, int b)
        {
            return a * b;
        }

        // Recursive Method
        public int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        // Extension Method (Separate Static Class Required)
        public void CallExtensionMethod()
        {
            string message = "Hello";
            message.PrintLength();
        }

        // Async Method
        public async Task AsyncExample()
        {
            Console.WriteLine("Task Started...");
            await Task.Delay(2000);
            Console.WriteLine("Task Completed.");
        }
    }
}
static class StringExtensions
{
    public static void PrintLength(this string str)
    {
        Console.WriteLine($"Length of '{str}': {str.Length}");
    }
}