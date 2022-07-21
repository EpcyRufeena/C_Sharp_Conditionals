using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16_n_num
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1)
            {
                n = n * (n + 1) / 2;
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
