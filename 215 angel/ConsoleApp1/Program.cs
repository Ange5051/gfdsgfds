using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.Write("x=");
            //    int x = int.Parse(Console.ReadLine);
            //    int y = x < 0 ? x + 1;
            //    Console.WriteLine($"y={y}");
            //    Console.Read();
            //}
            //catch()
            //{

            //}

            //try
            //{
            //    //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7.
            //    //По указанному номеру n вывести название соответствующего дня недели.

            //    Console.Write("НОМЕР ДНЯ НЕДЕЛИ:");
            //    int day = int.Parse(Console.ReadLine());
            //    switch (day)
            //    {
            //        case 1: Console.WriteLine("Понедельник");break;
            //        case 2: Console.WriteLine("Вторник");break;
            //        case 3:Console.WriteLine("Среда");break;
            //        case 4:Console.WriteLine("Четверг");break;
            //        case 5:Console.WriteLine("Пятница");break;
            //        case 6:Console.WriteLine("Суббота");break;
            //        case 7:Console.WriteLine("Воскресенье");break;

            //        default: Console.WriteLine("Нет такого дня недели"); break;
            //    }

            //}
            // catch(Exception ex)
            //     Console.WriteLine($"Исключение: {ex.Message}");
            //     Console.WriteLine($"Метод: {ex.TargetSite}");
            //     Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            // }

            //}
            //Console.ReadKey();

            //            try
            //            {
            //                //Задача 2.По номеру месяца вывести название времени года.

            //                Console.Write("Номер месяца:");
            //                int day = int.Parse(Console.ReadLine());
            //                switch (day)
            //                {
            //                    case 1: Console.WriteLine("Январь"); break;
            //                    case 2: Console.WriteLine("Февраль"); break;
            //                    case 3: Console.WriteLine("Март"); break;
            //                    case 4: Console.WriteLine("Апрель"); break;
            //                    case 5: Console.WriteLine("Май"); break;
            //                    case 6: Console.WriteLine("Июнь"); break;
            //                    case 7: Console.WriteLine("Июль"); break;
            //                    case 8: Console.WriteLine("Август"); break;
            //                    case 9: Console.WriteLine("Сентябрь"); break;
            //                    case 10: Console.WriteLine("Октябрь"); break;
            //                    case 11: Console.WriteLine("Ноябрь"); break;
            //                    case 12: Console.WriteLine("Декабрь"); break;

            //                    default: Console.WriteLine("Нет такого месяца"); break;
            //                }

            //            }
            //            catch(Exception ex)
            //{
            //                Console.WriteLine($"Исключение: {ex.Message}");
            //                Console.WriteLine($"Метод: {ex.TargetSite}");
            //                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //            }
            //            {

            //            }
            //            Console.ReadKey();

            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}
