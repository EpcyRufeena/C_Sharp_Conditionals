using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter the radius :");
            double radius = double.Parse(Console.ReadLine());

            if (radius >=1)
            {
                double perimeter = pi * radius * radius;
                Console.WriteLine("Perimeter is :"+perimeter);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
