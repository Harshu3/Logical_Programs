using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Prime_Number
    {
        public void PrimeNum()
        {
            Console.WriteLine("Enter the number to check prime number");
            int n = int.Parse(Console.ReadLine());
            int number = n;
            bool flag = true;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{n} is not a prime number");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"{n} is a prime number");
            }
        }
    }
}
