using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q24_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a height in meters");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter weight in kilograms");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (height >= 1 && weight >= 1)
            {
                double h = (height / 39.37); //1meter=39.37 inches
                double kg = (weight * 1000);
                double bmi = ((weight / height) * height);
                Console.WriteLine("Your BMI  is" + bmi);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
