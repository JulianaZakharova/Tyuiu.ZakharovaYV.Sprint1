using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZakharovaYV.Sprint1.Task6.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            value = value.Replace(" ", "");
            value = value.Replace("*", "");
            return  value;
        }
    }
}
