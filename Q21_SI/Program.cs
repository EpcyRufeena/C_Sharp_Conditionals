using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21_SI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a principal amount: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a time period: ");
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a rate of interest: ");
            double R = Convert.ToDouble(Console.ReadLine());

            if (P >= 1 && N >= 1 && R >= 1)
            {
                double Simple_Interest = (P * N * R) / 100;
                Console.WriteLine("Simple Interest  is :" + Simple_Interest);
            }
            else
            {
                Console.WriteLine("Ivalid input");
            }
        }
    }
}
