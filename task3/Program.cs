using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double x, a, b, y ;
            Console.WriteLine("Введіть x, a, b.");
            x = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (x > 0 && a > 0 && b > 0)
            {
                y = (2.4 * Math.Abs(Math.Pow(x, 2) + b / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, 1 / 2) * (x - b));
                Console.WriteLine($"y = {y}");
            }
            else
            {
                Console.WriteLine("Введіть числа, які більше нуля");
            }

        }
    }
}
