using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TempeatureConversion
    {
        public void temperatureconversion(int temperature)
        {
            Console.WriteLine("\n 1. Celsius to Fahrenheit \n 2. Fahrenheit to Celsius");
            Console.WriteLine("Enter the choice:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int celsius_to_fahrenheit = (temperature * 9 / 5) + 32;
                    Console.WriteLine("celsius to fahrenheit: " + celsius_to_fahrenheit);
                    break;
                case 2:
                    int fahrenheit_to_celsius = (temperature - 32) * 5 / 9;
                    Console.WriteLine("fahrenheit to celsius: " + fahrenheit_to_celsius);
                    break;
                default:
                    Console.WriteLine("invalid selection");
                    break;
            }
        }
    }
}
