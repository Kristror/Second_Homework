using System;

namespace OddPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            ///  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
            ///
            int num;
            int sum = 0;
            Console.WriteLine("Программа для подсчита суммы всех введенных нечетных положительных чисел до введения нуля");

            do
            {
                int.TryParse(Console.ReadLine(), out num);
                sum += (num > 0)&&(num % 2 !=0)? num: 0;
            } while (num != 0);

            Console.WriteLine($"Cумма всех введенных нечетных положительных чисел: {sum}");
            Console.ReadKey();            
        }
    }
}
