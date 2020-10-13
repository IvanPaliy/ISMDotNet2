using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, c, x1, x2, D, y, x;
            Console.WriteLine("Введіть a, b, c. ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
                D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = ((-b) + (Math.Sqrt(D)) / 2 * a);
                x2 = ((-b) - (Math.Sqrt(D)) / 2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");

            }
            else 
            if (D == 0)
            {
                x1 = ((-b) / 2 * a);
                Console.WriteLine($"x1 = {x1}");
            
            } 
            if (D < 0)
            {
                Console.WriteLine("Рішень немає! Введіть інші значення.");
            }
         }
    }
}
