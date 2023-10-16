using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Task5.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 13257;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
