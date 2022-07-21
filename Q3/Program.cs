using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  length of the tank");  
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  height of the tank");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  width of the tank");
            float h = float.Parse(Console.ReadLine());
            if (l > 1 && w > 1 && h > 1)
            {
                float rectangle = l * w * h;
                Console.WriteLine("volume of a rectanglar water tank is" + rectangle);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
