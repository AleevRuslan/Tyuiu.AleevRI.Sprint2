using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Получение результата из switch                                 *");
            Console.WriteLine("* Задание #2.6                                                         *");
            Console.WriteLine("* Вариант #9                                                           *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУб-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу,которая вычисляет дату следующего дня по заданным *");
            Console.WriteLine("* натуральными числами: m (порядковый номер месяца) и n (число)        *");
            Console.WriteLine("* (n и m не характеризуют 31 декабря).                                 *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(n, m);
            }

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}
