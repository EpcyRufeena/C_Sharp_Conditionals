using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            
            if (first >=1 && second >1)               
            {
                int sum = first + second;                    
                Console.WriteLine("sum value is :" + sum); 
                int product = first * second;
                Console.WriteLine("Product is :"+product);
                int difference =Math.Abs(first - second);
                Console.WriteLine(("difference is :"+difference));
            }
           
            else
            {
                Console.WriteLine("Invalid input please enter positive number");
            }
            
                                                            
        }
    }
}
