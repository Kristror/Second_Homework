using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromAtoB
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            ///  a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            ///  б) *Разработать рекурсивный метод, который считает сумму чисел от a до b
            ///
            Console.WriteLine("Программа для вывода и подсчита сумму чисел от a до b");
            Console.WriteLine("Введите первое число:");
            int numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int numB = int.Parse(Console.ReadLine());

            int sum = 0;
            if (numA != numB)
            {
                if (numA > numB)
                {
                    sum = NumbersFromAtoB(numB, numA);
                }
                else
                {
                    sum = NumbersFromAtoB(numA, numB);
                }
                Console.WriteLine($"Сумма введеныч чисел равна: {sum}");
            }
            else Console.WriteLine("Введеные числа равны: ");
            Console.ReadKey();
        }

        private static int NumbersFromAtoB(int start, int end)
        {
            Console.WriteLine(start);
            if (start < end) return NumbersFromAtoB(start + 1, end) + start;
            else return 0;
        }
    }
}
