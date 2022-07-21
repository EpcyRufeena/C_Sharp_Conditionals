using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            if (a >= 1 && b <= 101)
            {
                Random r = new Random();
                int num = r.Next(a, b);
                Console.WriteLine("Random number is :" + num);
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
