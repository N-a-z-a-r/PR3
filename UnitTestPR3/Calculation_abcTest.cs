using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR;

namespace UnitTestPR3
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calculation_positive_positive_positive()
        {
            // arrage
            var calc = new Calculation_abc(1, 2, 3);
            var testRes = 6;
            // act
            var res = calc.D();
            // assert
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_negative_negative_negative()
        {
            // arrage
            var calc = new Calculation_abc(-1, -2, -3);
            var testRes = -6;
            // act
            var res = calc.D();
            // assert
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_negative_negative_positive()
        {
            // arrage
            var calc = new Calculation_abc(-1, -2, 3);
            var testRes = 2;
            // act
            var res = calc.D();
            // assert
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_negative_positive_positive()
        {
            // arrage
            var calc = new Calculation_abc(-1, 2, 3);
            var testRes = 2;
            // act
            var res = calc.D();
            // assert
            Assert.AreEqual(testRes, res);
        }
    }
}
