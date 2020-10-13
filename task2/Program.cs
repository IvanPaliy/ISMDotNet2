using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double m, n, z1, z2;
            Console.WriteLine("Введіть m і n");
            m = double.Parse(Console.ReadLine());
            n = double.Parse(Console.ReadLine());
            if (m > 0 && n > 0) 
            {
                z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
                Console.WriteLine($"z1 = {z1}");
                z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
                Console.WriteLine($"z2 = {z2}");
            }
            else
            {
                Console.WriteLine("Введіть числа, які більші нуля.");
            }
          
        }
    }
}
