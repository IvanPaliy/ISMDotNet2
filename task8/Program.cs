using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            decimal a, a1 = 1;
            float n;
            Console.WriteLine("Введіть а та n :");
            a = decimal.Parse(Console.ReadLine());
            n = float.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (float i = 1; i <= n; i++)
                {
                    a1 *= a;
                    Console.WriteLine($"a{i} = {a1}");
                }
                Console.WriteLine($"Результат:{a1}");
            }
            else 
            {
                Console.WriteLine("Введіть таке n, щоб воно було більше нуля!");
            }
        }
    }
}
