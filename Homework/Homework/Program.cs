using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int masslength = int.Parse(Console.ReadLine());
            int[] myArray = new int[masslength];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(i + "-й элемент: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
