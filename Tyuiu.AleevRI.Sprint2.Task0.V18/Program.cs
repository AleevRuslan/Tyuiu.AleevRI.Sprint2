using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint2.Task0.V18.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5105;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                             *");
            Console.WriteLine("* Задание #2.0                                                         *");
            Console.WriteLine("* Вариант #18                                                          *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУБ-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений(==, !=, <, >, <=, >=,       *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических   *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):     *");
            Console.WriteLine("* (False, True, True, True, True, False), при x = 5105, y = 475        *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
