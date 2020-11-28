using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogPass
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            ///  Реализовать метод проверки логина и пароля. 
            ///  На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            ///  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            ///  С помощью цикла do while ограничить ввод пароля тремя попытками.
            ///
            string login = "root";
            string password = "GeekBrains";
            int attempts = 3;
            bool authorization = false;
            Console.WriteLine("Программа для проверки логина и пароля");

            while (attempts > 0)
            {
                authorization = Authorizations(login, password);
                if (authorization) break;
                else
                {
                    attempts--;
                    Console.WriteLine($"Ввенные логин и пароль не подходят осталось {attempts} попыток");
                }
            };
            if(authorization) Console.WriteLine("Вы успешно вошли в систему");
                else Console.WriteLine("Вы превысили кол-во попыток для входа в систему");
            Console.ReadKey();
        }

        private static bool Authorizations(string login, string password)
        {
            Console.WriteLine("Введите логин:");
            string inLog = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string inPass = Console.ReadLine();

            if ((inLog == login) && (inPass == password)) return true;

            return false;
        }
    }
}
