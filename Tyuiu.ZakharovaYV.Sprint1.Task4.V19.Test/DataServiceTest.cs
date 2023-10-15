using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.ZakharovaYV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 2.0;
            double a = 3.0;

            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(16, res);
        }
    }
}
