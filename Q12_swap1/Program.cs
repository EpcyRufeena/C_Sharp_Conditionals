using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_swap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            if (a >= 1 && b >= 1)
            {
                Console.WriteLine("Before swap a: " + a + "b:" + b);
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("After swap a: " + a + "b:" + b);
            }
            else
            {
                Console.WriteLine("Invalid input please enter positive value");
            }
        }
    }
}
