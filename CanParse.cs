using System;

namespace project
{
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Enter input: ");
      string textToBeConverted = Console.ReadLine();
      StringToNum(textToBeConverted);
    }
    static void StringToNum(string text)
    {
      try
      {
        int textToNum = Int32.Parse(text);
        Console.WriteLine($"Succesfully parsed input: {textToNum}");
      }
      catch (FormatException)
        {
            Console.WriteLine("Unable to parse input");
        }
    }
}
}
