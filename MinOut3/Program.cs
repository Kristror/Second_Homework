using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOut3
{
    class Program
    {
        static void Main(string[] args)
        {

            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            /// Написать метод, возвращающий минимальное из трех чисел.
            ///
            double num1;
            double num2;
            double num3;
            Console.WriteLine("Программа по нахождению минимального из трех чисел");

            Console.WriteLine("Введите первое число:");
            Double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Введите второе число:");
            Double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("Введите третье число:");
            Double.TryParse(Console.ReadLine(), out num3);
            double min = MinOut3(num1, num2, num3);

            Console.WriteLine($"Из чисел {num1}, {num2}, {num3} минимальное - {min}");
            Console.ReadKey();
        }

        private static double MinOut3(double num1, double num2, double num3)
        {
            return (num1 < num2) && (num1 < num3) ? num1 : (num2 < num3) ? num2 : num3;
        }
    }
}
