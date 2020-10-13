using System;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            float a, b, s, p;
            Console.WriteLine("Введіть a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b: ");
            b = float.Parse(Console.ReadLine());
            s = a * b;
            p = (a + b) * 2;
            Console.WriteLine($"Площа = {s}");
            Console.WriteLine($"Периметр = {p}");

            

        }
    }
}
