using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число чей факториал нужно найти: ");
            int n = int.Parse(Console.ReadLine());
            long factrorial = 1;
            for (int i = 1; i < n+1; i++)
            {
                factrorial *= i;
                Console.WriteLine(factrorial);
            }
            Console.WriteLine($"Факториал числа {n} = "+factrorial);
        }
    }
}
