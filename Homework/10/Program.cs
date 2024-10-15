using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите сумму денег (копейки до рубля включительно): ");
            int amount = int.Parse(Console.ReadLine());

            if (amount < 0 || amount > 100)
            {
                Console.WriteLine("Сумма должна быть в диапазоне от 0 до 100.");
                return;
            }

            string[] units = { "", "одна копейка", "две копейки", "три копейки", "четыре копейки", "пять копеек", "шесть копеек", "семь копеек", "восемь копеек", "девять копеек" };
            string[] teens = { "десять копеек", "одиннадцать копеек", "двенадцать копеек", "тринадцать копеек", "четырнадцать копеек", "пятнадцать копеек", "шестнадцать копеек", "семнадцать копеек", "восемнадцать копеек", "девятнадцать копеек" };
            string[] tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

            if (amount == 100)
            {
                Console.WriteLine("один рубль");
            }
            else if (amount >= 10 && amount < 20)
            {
                Console.WriteLine(teens[amount - 10]);
            }
            else
            {
                int unit = amount % 10;
                int ten = amount / 10;

                if (unit == 0)
                {
                    Console.WriteLine(tens[ten] + " копеек");
                }
                else
                {
                    string result = tens[ten];
                    if (result != "") result += " ";
                    result += units[unit];
                    Console.WriteLine(result);
                }
            }
            }
    }
}
