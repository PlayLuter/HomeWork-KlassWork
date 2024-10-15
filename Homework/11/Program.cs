using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Введите вещественное число: ");
                double value;
                while (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Ошибка: некорректный ввод. Пожалуйста, введите вещественное число.");
                }

                Console.Write("Введите первую букву единицы измерения (г - граммы, к - килограммы, ц - центнеры, т - тонны): ");
                char fromUnit = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Введите вторую букву единицы измерения (г - граммы, к - килограммы, ц - центнеры, т - тонны): ");
                char toUnit = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = ConvertWeight(value, fromUnit, toUnit);
                if (result != double.NaN)
                {
                    Console.WriteLine($"Результат: {result} {GetUnitName(toUnit)}");
                }
            }

            static double ConvertWeight(double value, char fromUnit, char toUnit)
            {
                double grams = value;

                // Преобразование в граммы
                switch (fromUnit)
                {
                    case 'г':
                        grams = value; // уже в граммах
                        break;
                    case 'к':
                        grams = value * 1000; // килограммы в граммы
                        break;
                    case 'ц':
                        grams = value * 100000; // центнеры в граммы
                        break;
                    case 'т':
                        grams = value * 1000000; // тонны в граммы
                        break;
                    default:
                        Console.WriteLine("Ошибка: недопустимая единица измерения.");
                        return double.NaN;
                }

                // Преобразование из граммов в целевую единицу
                switch (toUnit)
                {
                    case 'г':
                        return grams; // назад в граммы
                    case 'к':
                        return grams / 1000; // граммы в килограммы
                    case 'ц':
                        return grams / 100000; // граммы в центнеры
                    case 'т':
                        return grams / 1000000; // граммы в тонны
                    default:
                        Console.WriteLine("Ошибка: недопустимая единица измерения.");
                        return double.NaN;
                }
            }

            static string GetUnitName(char unit)
            {
                switch (unit)
                {
                    case 'г': return "грамм";
                    case 'к': return "килограмм";
                    case 'ц': return "центнер";
                    case 'т': return "тонна";
                    default: return "неизвестная единица";
                }
            }
        }
    }
}
