using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint2.Task5.V15.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Оператор switch                                                *");
            Console.WriteLine("* Задание #2.5                                                         *");
            Console.WriteLine("* Вариант #15                                                          *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУб-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет     *");
            Console.WriteLine("* требуемое значение и возвращает результат. Дано целое число          *");
            Console.WriteLine("* k(1 <= k <= 365). Определить, каким днем недели является k-й день    *");
            Console.WriteLine("* не високосного года, в котором 1 января понедельник.                 *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Введите номер дня:");
            int value = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDayName(value);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            if (value >= 1 && value <= 365)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine($"Введено неверное значение");
            }
            Console.ReadKey();
        }
    }
}
        
    

