using System;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Problem!");
            Console.WriteLine("Vending Machine Program");
            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Vending_Machine.GetMinimumNumOfNotes(amount);
        }
    }
}