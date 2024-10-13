using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine( (Math.Pow(a*b+7*c,3)-(Math.Pow(a,2)+ Math.Pow(b,2)+ Math.Pow(c,2)))/( b-a*c-a*(b+c) )  );
        }
    }
}
