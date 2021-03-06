﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while (input != 3) 
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ №1");
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Главное меню:");
                Console.WriteLine("1 - Вывод дня недели по его номеру");
                Console.WriteLine("2 - Вывод таблицы умножения по введенному числу");
                Console.WriteLine("3 - Выход из программы"); 

                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        {
                            Days days = new Days();
                            days.Show();
                            break;
                        }
                    case 2:
                        {
                            Multiplication multiplication = new Multiplication();
                            multiplication.Show();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Сейчас будет произведен выход из программы ");
                            Console.WriteLine("Для продолжения нажмите - ENTER");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели не корректные данные, попробуйте еще раз");
                            Console.WriteLine("Для продолжения нажмите - ENTER");
                            Console.ReadKey();
                            break;
                        }
                }                
                Console.Clear();
            } 
        }
    }
}
