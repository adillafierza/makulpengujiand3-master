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
        public void TestPenjumlahan()
        {
            double actual = 12;
            double expected = mw.Penjumlahan(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestPengurangan()
        {
            double actual = 6;
            double expected = mw.Pengurangan(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestPerkalian()
        {
            double actual = 27;
            double expected = mw.Perkalian(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestPembagian()
        {
            double actual = 3;
            double expected = mw.Pembagian(a, b);
            Assert.AreEqual(actual, expected);

        }


    }
}
