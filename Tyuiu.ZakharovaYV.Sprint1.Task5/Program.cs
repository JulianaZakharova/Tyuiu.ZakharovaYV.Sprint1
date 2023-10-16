using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint1.Task5.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Захарова Ю. В. | ПКТБ 23 - 1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)            *");
            Console.WriteLine("* прошло к этому моменту                                                  *");

            Console.WriteLine("Идет секунда суток = ");
            int time  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.SecondsToHours(time));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
