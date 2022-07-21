using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15_feet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of the field in feet");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the field in feet");
            double width = Convert.ToDouble(Console.ReadLine());

            if (length >= 1 && width >= 1)
            {
                double field = (length * width);

                Console.WriteLine("Area of a field is" + field + "square feet");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
