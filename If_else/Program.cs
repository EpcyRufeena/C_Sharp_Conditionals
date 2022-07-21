using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponent number");
            int exponent= Convert.ToInt32(Console.ReadLine());

            if (base1 > 1 && exponent >1)
            {
                double power=Math.Pow(base1,exponent);   //using math.pow
                Console.WriteLine("power value is :"+power);
               
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
