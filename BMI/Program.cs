using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            ///
            ///  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            ///  б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            ///
            double lowNormalBMI = 18.5;
            double hightNormalBMI = 25;
            Console.WriteLine("Программа для рассчета индексаа массы тела и советов по работе с ней");

            Console.WriteLine("Введите ваш рост в метрах:");
            double growth = Double.Parse(Console.ReadLine().Replace('.',','));
            Console.WriteLine("Введите ваш вес в килограммах:");
            double weight = Double.Parse(Console.ReadLine());

            double growth2 = growth * growth;
            double bmi = weight / growth2;

            Console.WriteLine($"При росте {growth} м и весе {weight} кг ваш  индекс массы тела: {bmi:F2}");
            if ((bmi >= lowNormalBMI) && (bmi <= hightNormalBMI)) Console.WriteLine("С вашим весом все прекрасно, так дрежать!");
            else {
                if (bmi < lowNormalBMI) Console.WriteLine($"Вам нужно поднабрать {(lowNormalBMI - bmi) * growth2} кг для кого что бы ваш вес был в норме");
                if (bmi > hightNormalBMI) Console.WriteLine($"Вам нужно сбросить {(bmi - hightNormalBMI) * growth2} кг для кого что бы ваш вес был в норме");
            }
            Console.ReadKey();
         }

    }
}
