using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Task4.V26.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.105;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
