using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZakharovaYV.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            
           
            foreach (char c in value)
            {
                if (c < 'а' || c > 'я')
                {
                    return false;
                    
                }
            }
            return true;

        }
    }
}
