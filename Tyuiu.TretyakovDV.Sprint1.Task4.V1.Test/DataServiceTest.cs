using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint1.Task4.V1.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.25;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}