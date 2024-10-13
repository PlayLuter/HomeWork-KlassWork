using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    internal class Program
    {
        static void Main()
        {
            // Задаем начальные параметры
            double start = 10.0;
            double end = 15.0;
            double step = 0.5;

            Console.WriteLine(" Таблица значений функции f(x) = sin(x^2) * ln(x) ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("{0,10} | {1,20}", " x", "f(x)");
            Console.WriteLine("-----------------------------------------------------");

            // Проходим по значениями от start до end с заданным шагом
            for (double x = start; x <= end; x += step)
            {
                double fx = CalculateFunction(x);
                Console.WriteLine("{0,10:F2} | {1,20:F6}", x, fx);
            }
        }

        // Функция для вычисления f(x) = sin(x^2) * ln(x)
        static double CalculateFunction(double x)
        {
            // Используем Math.Sin и Math.Log для вычисления значений
            // Math.Log по умолчанию вычисляет натуральный логарифм
            return Math.Sin(x * x) * Math.Log(x);
        }
    }
}
