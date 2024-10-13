using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Переменная a = {a}, переменная b = {b} ");
        }
    }
}
