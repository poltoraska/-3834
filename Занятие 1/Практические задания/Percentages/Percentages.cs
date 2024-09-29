using System;
using static System.Net.Mime.MediaTypeNames;

namespace Percentages
{
    internal class Programm
    {
        static void Main(string [] args)
        {
            
            Console.WriteLine("Введите количество средств, процент вклада(годовой) и срок вклада в месяцах.");
            string input = Console.ReadLine(); // записывает ввод с клавиатуры

            string[] y = input.Split(" "); // делит числа по пробелу
            double money = double.Parse(y[0]);
            double percent = double.Parse(y[1]) / 100;
            int mouth = int.Parse(y[2]); ;
            double percentpermouth = Math.Pow(1 + percent, 1.0 / 12) - 1;
            Console.WriteLine($"Этот ввод соответствует вкладу {money} рублей под {percent}% годовых на {mouth} месяц.");
            
            double result = Calculate(input);
            Console.WriteLine($"Через месяц на {money} рублей добавится {percentpermouth} % (1 / 12 от годового процента), значит общая сумма будет {result}.");
           
            
        }
        static double Calculate(string input)
        {
            string[] y = input.Split(" "); // делит числа по пробелу
            double money = double.Parse(y[0]);
            double percent = double.Parse(y[1]) / 100;
            int mouth = int.Parse(y[2]);

            double percentpermouth = Math.Pow(1 + percent, 1.0 / 12) - 1; // месячный процент по вкладу


            double result = money * Math.Pow(1 + percentpermouth, mouth);

            return result;
        }


    }
}