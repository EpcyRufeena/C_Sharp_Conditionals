using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Quot_Remain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double second = Convert.ToDouble(Console.ReadLine());

            if (first >=1 && second > 1)
            {
                double quotient = first / second;
                Console.WriteLine("Quotient of the value is" + quotient);
                double remainder = first % second;
                Console.WriteLine("Remainder of the value is" + remainder);
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
