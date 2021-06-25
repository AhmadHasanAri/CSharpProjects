using System;

namespace project
{
  class Program {
    static void Main(string[] args) {
        decimal bankTotal = 10000.00m;
        Console.WriteLine($"You have ${bankTotal} in your bank account.");

        Console.WriteLine("Amount to be deposited:");
        decimal bankDeposit = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Amount to be withdrawed:");
        decimal bankWithdrawal = Convert.ToDecimal(Console.ReadLine());

        bankTotal = bankTotal + bankDeposit - bankWithdrawal;
        if (bankTotal > 0)
        {
          Console.WriteLine($"Now you have ${bankTotal} in your bank account.");
        }
        else if (bankTotal == 0)
        {
          Console.WriteLine("You're bankrupt!");
        }
        else if (bankTotal < 0)
        {
          Console.WriteLine("You're in debt!");
        }
    }
}
}
