using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Reverse_Number
    {
        public void ReverseNum()
        {
            Console.WriteLine("Enter number to Reverse it");
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            Console.WriteLine($"Before Reverse = {n}");
            while (number > 0)
            {
                int rem = number % 10;
                sum = (sum * 10) + rem;
                number = number / 10;

            }
            Console.WriteLine($"After Reverse = {sum}");
        }
    }
}
