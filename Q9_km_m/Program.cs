using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_km_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a kilometer");
            double km = Convert.ToDouble(Console.ReadLine());
            if (km >= 1)
            {
                double miles = km / 1.60934;
                Console.WriteLine(miles + "Miles");
            }
            else
            {
                Console.WriteLine("Ivalid input please enter positive value");
            }
        }
    }
}
