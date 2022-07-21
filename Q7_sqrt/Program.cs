using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1)
            {
                double squareroot = Math.Sqrt(a);
                Console.WriteLine("Squareroot value is :" + squareroot);
            }
            else 
            {
                Console.WriteLine("Invalid input please give a positive number");
            }
        }
    }
}
