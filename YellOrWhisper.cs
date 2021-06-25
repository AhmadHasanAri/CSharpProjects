using System;

namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter yell or whisper:");
            string choice = Console.ReadLine();
            YellOrWhisper(choice, text);
        }
        static void YellOrWhisper(string choice, string text)
        {
          if (choice == "yell")
          {
            string toBePrinted = $"{text}".ToUpper();
            Console.WriteLine(toBePrinted + "!!");
          }
          else if (choice == "whisper")
          {
            string toBePrintedTwo = $"{text}".ToLower();
            Console.WriteLine(toBePrintedTwo + "...");
          }
        }
    }
}
