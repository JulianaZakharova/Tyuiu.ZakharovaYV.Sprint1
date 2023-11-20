using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint1.Task3.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.

namespace Tyuiu.ZakharovaYV.Sprint1.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Захарова Ю. В. | ПКТБ 23 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание # 3                                                             *");
            Console.WriteLine("* Вариант # 3                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна   | ПКТБ-23-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Вычисления объема параллелепипеда                                        *");

            double length = 9;
            double width = 7.5;
            double height = 5;

            Console.WriteLine("Длинна = " + length);
            Console.WriteLine("Ширина = " + width);
            Console.WriteLine("Высота = " + height);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Объем параллелепипеда = " + ds.ParallelepipedVolume(length, width, height));

            Console.ReadKey();

        }
    }
}
