using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double chislo = 1;
            double wait = 1.022;
            var res = ds.Calculate(chislo);
            Assert.AreEqual(wait, res);
        }
    }
}