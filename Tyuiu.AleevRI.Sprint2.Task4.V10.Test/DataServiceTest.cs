using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint2.Task4.V10.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 1.027;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 27.5;
            Assert.AreEqual(wait, res);
        }
    }
}

