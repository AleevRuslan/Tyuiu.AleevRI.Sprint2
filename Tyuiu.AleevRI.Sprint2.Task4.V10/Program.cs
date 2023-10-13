using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint2.Task4.V10.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Тернарный оператор                                             *");
            Console.WriteLine("* Задание #2.4                                                         *");
            Console.WriteLine("* Вариант #10                                                          *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУб-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу,которая вычисляет требуемые значения с            *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит         *");
            Console.WriteLine("* значение переменных x, y с клавиатуры.                               *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Значение функции =" + res);

            Console.ReadKey();
        }
    }
}
