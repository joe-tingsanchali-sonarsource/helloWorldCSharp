using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World2222");

            int a = 5;
            int b = 0;
            // Deliberate divide-by-zero bug for testing
            int c = a / b;
            Console.WriteLine($"Result: {c}");
        }
    }
}