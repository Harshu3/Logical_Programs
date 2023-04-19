using System;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem!");
            Console.WriteLine("Perfect Number Program");
            Perfect_Number perfect_Number = new Perfect_Number();
            perfect_Number.PerfectNum();
        }
    }
}