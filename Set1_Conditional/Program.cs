using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            ////int number = 1;

            if (number > 1)
            {
                int sum = number1 + number2;
                Console.WriteLine("sum value is :" + sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
