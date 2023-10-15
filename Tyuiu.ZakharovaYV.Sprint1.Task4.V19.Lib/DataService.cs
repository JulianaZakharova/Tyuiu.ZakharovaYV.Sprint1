using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZakharovaYV.Sprint1.Task1.Lib
{
    public class DataService : ISprint1Task1V16
    {
        public double Calculate(double x, double y, double a)
        {
            return x * 5 * y + 2 * a;
        }
    }
}
