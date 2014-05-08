using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        double a = 9;
        double b = 3;

        MainWindow mw = new MainWindow();

        [TestMethod]
        public void TestMethod1()
        {
            double actual = 12;
            double expected = mw.Penjumlahan(a, b);
            Assert.AreEqual(actual, expected);

        }


    }
}
