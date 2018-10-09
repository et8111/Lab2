using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            char t = 'y';
            while (t == 'y')
            {
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());
                double area = height * width;
                double pera = 2 * width + 2 * height;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perameter: " + pera);
                Console.Write("\nCONTIUE?" + '\n' + "(y/n): ");
                t = char.Parse(Console.ReadLine());
            }
        }
    }
}
