using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q25_T_avg
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your roll no");
            int rn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter M1");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter M2");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter M3");
            int m3 = Convert.ToInt32(Console.ReadLine());

            if (m1 >= 30 && m2 >= 30 && m3 >= 30)
            {
                int Total = m1 + m2 + m3;
                double Average = Total / 3;

                Console.WriteLine("RNO :" + rn);
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Marks: " + m1 + "+" + m2 + "+" + m3);
                Console.WriteLine("Total mark =" + Total);
                Console.WriteLine("Average =" + Average);
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }
        }
    }
}
