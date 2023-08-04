using system;

// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            bool isRunning = true;
            var name;
            // Setting styling.
            Console.Title = "Variables";
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Actual Code.
            Console.WriteLine("What is your name?");
            while (isRunning)
            {
                name = Console.ReadLine();
                if (name is string)
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid name.");
                }
            }
            Console.WriteLine($"Hello {name}");
        }
    }
}