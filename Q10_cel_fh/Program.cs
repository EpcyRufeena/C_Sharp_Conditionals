using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_cel_fh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temprature in celcius");
            double celcius = Convert.ToDouble(Console.ReadLine());

            if (celcius >= -273.15 && celcius <= 1000)
            {
                double Fahrenheit = (celcius * 9 / 5) + 32;
                Console.WriteLine(9 / 5);
                Console.WriteLine("Temprature in fahrenheit" + Fahrenheit);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
