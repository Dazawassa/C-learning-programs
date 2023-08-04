using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}