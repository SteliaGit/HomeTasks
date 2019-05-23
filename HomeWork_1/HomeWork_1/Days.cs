using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Days
    {
        public void Show()
        {
            Console.Clear();
            int input;
            Console.WriteLine(new string('-', 73));
            Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7) || Для выхода нажмите - 0");
            Console.WriteLine(new string('-', 73));
            // string input = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out input);
            GetNameDay(input);
        }

        public void GetNameDay(int input = 0)
        {        
            while (input != 0)
            {                
                string FirstWord = $"Выбранный номер - {input}, соответствует дню: ";
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine(FirstWord + "Понедельник");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(FirstWord + "Вторник");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(FirstWord + "Среда");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(FirstWord + "Четверг");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(FirstWord + "Пятница");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(FirstWord + "Суббота");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(FirstWord + "Воскресенье");
                            break;
                        }
                    case 0:
                        {
                            // Console.WriteLine("Сейчас будет произведен выход в главное меню");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели не корректные данные, попробуйте еще раз");
                            break;
                        }
                }
                Console.WriteLine("Для продолжения нажмите - ENTER");
                Console.ReadKey();
                Console.Clear();
                input = 0;
                Show();
            }      
        }        
    }
}
