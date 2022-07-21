using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q23_feet
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch, feet;
            Console.WriteLine("Enter a height of the person in cm ");
            Double height = double.Parse(Console.ReadLine());

            if (height >= 1)
            {
                inch = height / 2.54;   //1 inch=2.54cms
                feet = height * 0.3048;
                Console.WriteLine("Height in inch" + inch);
                Console.WriteLine("Height in feet" + feet);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
