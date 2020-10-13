using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double n;
            float n1, n2 = 0;
            Console.WriteLine("Введіть n:");
            n = double.Parse(Console.ReadLine());
            if(n>0)
            {
                for (float i = 1; i <= n; i++)
                {
                    n1 = (float)1 / i;
                    n2 += n1;
                    Console.WriteLine($"n{i} = {n1}");
                    n1 *= (float)i;
                }
                Console.WriteLine($"Сумма = {n2}");
            }
            else 
            {
                Console.WriteLine("Введіть таке n, щоб воно було більше нуля!");
            }
        }
    }
}
