using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AleevRI.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()

        {
            DataService ds = new DataService();
            int m = 9;
            int n = 10;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "11.09";
            Assert.AreEqual(wait, res);
        }
    }
}
