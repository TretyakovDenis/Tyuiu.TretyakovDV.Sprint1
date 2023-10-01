using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string word = "Dexp";
            string wait = "Dex";
            var res = ds.DeleteLastLetter(word);
            Assert.AreEqual(wait, res);
        }
    }
}