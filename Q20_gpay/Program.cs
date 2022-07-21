using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20_gpay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the basic pay");
            double Basic_salary = double.Parse(Console.ReadLine());

            if (Basic_salary >= 1)
            {
                double da= Basic_salary*(40.0/ 100);
                double ta = Basic_salary*(20.0 / 100);
                double pf = (Basic_salary+da)*(8.0/ 100);
                double Grosspay = Basic_salary + da + ta - pf;
                Console.WriteLine("Basic salary " + Basic_salary);
                Console.WriteLine("Dearness Allowence " + da);
                Console.WriteLine("Travel Allowence " + ta);
                Console.WriteLine("Provident Fund " + pf);
                Console.WriteLine("Grosspay is " + Grosspay);
            }

            else
            {
                Console.WriteLine("Invalid input");
            }


        }
    }
}
