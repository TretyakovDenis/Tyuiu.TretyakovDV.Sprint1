using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint1.Task3.V12.Lib;
namespace Tyuiu.TretyakovDV.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}