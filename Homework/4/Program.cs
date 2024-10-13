using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = String.Concat(str.OrderBy(i => i));
            Console.WriteLine(str);
        }
    }
}
