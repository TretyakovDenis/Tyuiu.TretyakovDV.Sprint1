using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint1.Task1.V7.Lib;
namespace Tyuiu.TretyakovDV.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}