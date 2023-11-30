using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint6.Task0.V26.Lib;

namespace Tyuiu.DubrovinSN.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.769, res);
        }
    }
}
