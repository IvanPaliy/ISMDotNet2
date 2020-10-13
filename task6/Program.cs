using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b;
            Console.WriteLine("Введіть числа");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                for (double i = a; i <= b; i++)
                {
                    a *= i;
                    Console.WriteLine($"a = {a}");
                    a /= i;
                }
            }
            else
            {
                Console.WriteLine("Введіть такі значпення а і в, щоб а було меньше в ");
            }
            
        }

    }
}
