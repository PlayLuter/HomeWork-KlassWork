using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое вещественное число: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Введите второе вещественное число: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double result=0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
}
