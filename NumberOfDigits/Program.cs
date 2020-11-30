using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            /// Написать метод подсчета количества цифр числа.
            ///
            int number;
            int copynum;
            int digits = 0;

            Console.WriteLine("Программа по подсчету количества цифр числа");

            Console.WriteLine("Введите  число:");
            Int32.TryParse(Console.ReadLine(), out number);
            
            copynum = number;
            if (number > 0)
            {
                while (number > 0)
                {
                    number /= 10;
                    digits++;
                }
            } else if( number < 0)
                {
                while (number < 0)
                {
                    number /= 10;
                    digits++;
                }
            }
                else if (number == 0)  digits++; 

            Console.WriteLine($"Число {copynum} имеет {digits} цифр");

            Console.ReadKey();
        }
    }
}
