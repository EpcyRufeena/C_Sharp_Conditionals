using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_traingle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height value");
            int h = Convert.ToInt32(Console.ReadLine());
            if(b>=1 && h>=1)
            {
            double Triangle = (1 / 2.0 * (b * h));
            Console.WriteLine("Area of a triangle is" + Triangle);
            }
            else
            {
            Console.WriteLine("Invalid input please enter a positive number");
            }
        }
    }
}
