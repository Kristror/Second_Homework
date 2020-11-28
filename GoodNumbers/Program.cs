using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            ///  *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
            ///  Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            ///
            Console.WriteLine("Программа для подсчита хороших чисел в диапазоне от 1 до 1 000 000 000");
            DateTime begin = DateTime.Now;
            int amount = 0;
            for (int num = 1; num <= 1000000000; num++)
            {
                int sum = 0;
                int copy = num;
                while (copy > 0)
                {
                    sum += copy % 10;
                    copy /= 10;                    
                }
                if (num%sum == 0) amount ++;
            }
            Console.WriteLine($"Кол-во хороших чисел в диапазоне от 1 до 1 000 000 000 : {amount}");
            Console.WriteLine($"Выполнение программы заняло: {begin - DateTime.Now}");

            Console.ReadKey();
        }

    }
}
