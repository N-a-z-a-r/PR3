using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR;

namespace UnitTestPR3
{
    [TestClass]
    public class Calculation_abTest
    {
        [TestMethod]
        public void Calculation_a_great_b()
        {
            // arrage
            var calc = new Calculation_ab(2, 1);

            // act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sun());
        }
        [TestMethod]
        public void Calculation_a_equal_b()
        {
            // arrage
            var calc = new Calculation_ab(1, 1);
            var testRes = 0;
            // act
            var res = calc.Sun();
            // assert
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_negative_positive()
        {
            // arrage
            var calc = new Calculation_ab(-5, 5);
            var testRes = 6;
            // act
            var res = calc.Sun();
            // assert
            Assert.AreEqual(testRes, res);
        }
    }
}
