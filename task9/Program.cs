using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double n, n1=1, n2=0;
            Console.WriteLine("Введіть n:");
            n = double.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    n1 *= i;
                    n2 += n*i;
                    Console.WriteLine($"a{i} = {n1}");
                }
            }
            else 
            {
                Console.WriteLine("Введіть таке n, щоб воно було більше нуля!");
            }
        }
    }
}
