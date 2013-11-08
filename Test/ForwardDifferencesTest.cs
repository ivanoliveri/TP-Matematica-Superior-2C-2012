using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class ForwardDifferencesTest
    {

        [TestMethod]
        public void test_forward_differences_1()
        {
            var ordenedPairOne = new OrdenedPair { xValue = 0, yValue = 2 };
            var ordenedPairTwo = new OrdenedPair { xValue = 1, yValue = 3 };
            var ordenedPairThree = new OrdenedPair { xValue = 2, yValue = 4 };
            var ordenedPairFour = new OrdenedPair { xValue = 3, yValue = 6 };
            var ordenedPairFive = new OrdenedPair { xValue = 4, yValue = 5 };
            var ordenedPairSix = new OrdenedPair { xValue = 5, yValue = 8 };

            var interpolatingPolynomial = new InterpolatingPolynomial();

            interpolatingPolynomial.ordenedPairs.Add(ordenedPairOne);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairTwo);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairThree);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFour);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFive);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairSix);

            var result = interpolatingPolynomial.calculateForwardDifferencesOfOrdenedPairs(5,interpolatingPolynomial.ordenedPairs);

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void test_forward_differences_2()
        {
            var ordenedPairOne = new OrdenedPair { xValue = 1, yValue = 91 };
            var ordenedPairTwo = new OrdenedPair { xValue = 4, yValue = 84 };
            var ordenedPairThree = new OrdenedPair { xValue = 5, yValue = 77 };
            var ordenedPairFour = new OrdenedPair { xValue = 9, yValue = 51 };

            var interpolatingPolynomial = new InterpolatingPolynomial();

            interpolatingPolynomial.ordenedPairs.Add(ordenedPairOne);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairTwo);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairThree);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFour);

            var result = interpolatingPolynomial.calculateForwardDifferencesOfOrdenedPairs(3, interpolatingPolynomial.ordenedPairs);

            Assert.AreEqual(-19, result);
        }

    }
}
