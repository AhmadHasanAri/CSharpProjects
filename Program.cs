using System;

namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string greeting = Console.ReadLine();
            string decoratedGreeting = DecorateString(greeting);
            Console.WriteLine(decoratedGreeting);
        }
        static string DecorateString(string toBeDecorated)
        {
            string decoratedString = $"*.*.{toBeDecorated}.*.*";
            return decoratedString.ToUpper();
        }
    }
}
