using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Task6.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "122, 34, -56, 72";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(value);
            string wait = "122, 34, 72";
            Assert.AreEqual(wait, res)
        }
    }
}
