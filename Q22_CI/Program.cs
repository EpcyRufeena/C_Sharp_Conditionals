using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q22_CI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Initial Principal amount");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the interest rate ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of times interst");
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time period ");
            double T = Convert.ToDouble(Console.ReadLine());

            if (P >= 1 && N >= 1 && R >= 1 && T >= 1)
            {
                double Compound = P * Math.Pow((1 + R / N), (N * T));
                double ci = Compound - P;
                Console.WriteLine("Compond interest is" + Compound);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
