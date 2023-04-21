using System;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Problem!");
            Console.WriteLine("Temperature Conversion Program");
            Temperature_Conversion temp = new Temperature_Conversion();
            temp.TempConvInCelsius();
            temp.TempConvInFahrenheit();
        }
    }
}