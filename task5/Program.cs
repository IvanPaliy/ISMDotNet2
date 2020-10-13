using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double x;
            Console.WriteLine("Введіть число, від 1 до 7:");
            x = double.Parse(Console.ReadLine()); 
            switch (x) 
            {
                case 1: Console.WriteLine("Понеділок");
                    break;
                case 2: Console.WriteLine("Вівторок");
                    break;
                case 3: Console.WriteLine("Середа");
                    break;
                case 4: Console.WriteLine("Четверг");
                    break;
                case 5: Console.WriteLine("П'ятниця");
                    break;
                case 6: Console.WriteLine("Субота");
                    break;
                case 7: Console.WriteLine("Неділя");
                    break;
                default:
                    Console.WriteLine("Введіть інше число.");
                    break;
            }    



        }
    }
}
