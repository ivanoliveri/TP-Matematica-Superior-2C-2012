using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class MathHelperTest
    {
        [TestMethod]
        public void test_factorial()
        {
            var oneNumber = 6;
            Assert.AreEqual(720, MathHelper.calculateFactorial(oneNumber));
        }

        [TestMethod]
        public void test_combination()
        {
            var oneNumber = 5;
            var anotherNumber = 2;
            Assert.AreEqual(10, MathHelper.calculateCombination(oneNumber,anotherNumber));
        }
    }
}
