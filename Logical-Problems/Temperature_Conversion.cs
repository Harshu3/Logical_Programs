using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Temperature_Conversion
    {
        public void TempConvInCelsius()
        {
            Console.Write("\nEnter Fahrenheit Temperature: ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
        }
        public void TempConvInFahrenheit()
        {
            Console.Write("\nEnter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("The converted Fahrenheit temperature is : " + fahrenheit);
        }
    }
}
