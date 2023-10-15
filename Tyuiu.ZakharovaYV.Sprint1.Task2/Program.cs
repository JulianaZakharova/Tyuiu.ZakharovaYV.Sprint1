using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint1.Task2.Lib;

//ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
// Формулировка задания: Известен угол в радианах. Перевести угол в градусы. Ответ округлите до 3 знаков после запятой.
//Что пользователь вводит? Угол в радианах (целое число)
//Что программа печатает на экране? Угол в градусах (вещественное число)

namespace Tyuiu.ZakharovaYV.Sprint1.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Захарова Ю. В. | ПКТБ 23 - 1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна   | ПКТБ-23-2                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите угол в радианах :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(x));

            Console.ReadLine();
        }
    }
}
