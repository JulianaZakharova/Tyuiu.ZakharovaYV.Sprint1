using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            
            string strTest = "кошка";
            DataService ds = new DataService();
            bool  res = ds.CheckLowerCaseRusLetters(strTest);
            var wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
