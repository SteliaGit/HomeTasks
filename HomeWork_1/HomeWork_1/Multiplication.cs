using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Multiplication
    {

        public void Show()
        {
            Console.Clear();
            int input = 0;
            Console.WriteLine(new string('-', 85));
            Console.WriteLine("Введите число для вывода таблицы умножения (от 1 до 10) || Для выхода нажмите - 0");
            Console.WriteLine(new string('-', 85));
            int.TryParse(Console.ReadLine(), out input);
            GetMultiplication(input);

        }
        public void GetMultiplication(int input = 0)
        {
            int result = 0;
            while (true)
            {                
                if (input >= 1 && input <= 10)
                {
                    Console.WriteLine($"Таблица умнажения на {input}\n" );
                    for (int i = 1; i < 11; i++)
                    {
                        result = input * i;
                        Console.WriteLine($"{input} * {i} = {result}");
                    }
                    Console.WriteLine("\nМожете попробывать еще раз");
                    input = 0;
                }
                else if (input == 0)
                {
                    // Console.WriteLine("Сейчас будет произведен выход в главное меню");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректные данные, попробуйте еще раз");
                    input = 0;
                }

                Console.WriteLine("Для продолжения нажмите - ENTER");
                Console.ReadKey();
                Console.Clear();
                Show();
            }
        }
    }
}
