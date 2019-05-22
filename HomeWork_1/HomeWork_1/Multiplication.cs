using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Multiplication
    {
        // 
        public void GetMultiplication()
        {
            int input = 0;
            int result = 0;
            Console.Clear();
            do
            {
                Console.WriteLine(new string('-', 85));
                Console.WriteLine("Введите число для вывода таблицы умножения (от 1 до 10) || Для выхода нажмите - 11");                    
                Console.WriteLine(new string('-', 85));
                int.TryParse(Console.ReadLine(), out input);
                if (input >= 1 && input <= 10)
                {
                    Console.WriteLine($"Таблица умнажения на {input}\n" );
                    for (int i = 1; i < 11; i++)
                    {
                        result = input * i;
                        Console.WriteLine($"{input} * {i} = {result}");
                    }
                    Console.WriteLine("\nМожете попробывать еще раз");
                }
                else if (input == 11)
                {
                    Console.WriteLine("Сейчас будет произведен выход в главное меню");
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректные данные, попробуйте еще раз");
                }

                Console.WriteLine("Для продолжения нажмите - ENTER");
                Console.ReadKey();
                Console.Clear();

            } while (input != 11);
        }
    }
}
