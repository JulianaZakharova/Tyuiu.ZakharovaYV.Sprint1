using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Task7.V13.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 14.62988364;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
             
        }
    }
}
