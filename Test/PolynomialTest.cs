using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void test_polynomial_1()
        {
            var ordenedPairOne = new OrdenedPair { xValue = 1, yValue = 1 };
            var ordenedPairTwo = new OrdenedPair { xValue = 3, yValue = 3 };
            var ordenedPairThree = new OrdenedPair { xValue = 4, yValue = 13 };
            var ordenedPairFour = new OrdenedPair { xValue = 5, yValue = 37 };
            var ordenedPairFive = new OrdenedPair { xValue = 7, yValue = 151 };

            var interpolatingPolynomial = new InterpolatingPolynomial();

            interpolatingPolynomial.ordenedPairs.Add(ordenedPairOne);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairTwo);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairThree);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFour);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFive);

            const string expectedForwardPolynomial = "1 + 1 * ( X - 1 ) + 3 * ( X - 1 ) * ( X - 3 ) + 1 * ( X - 1 ) * ( X - 3 ) * ( X - 4 ) + 0 * ( X - 1 ) * ( X - 3 ) * ( X - 4 ) * ( X - 5 )";
            const string expectedBackwardPolynomial = "151 + 57 * ( X - 7 ) + 11 * ( X - 7 ) * ( X - 5 ) + 1 * ( X - 7 ) * ( X - 5 ) * ( X - 4 ) + 0 * ( X - 7 ) * ( X - 5 ) * ( X - 4 ) * ( X - 3 )";
            
            Assert.AreEqual(expectedForwardPolynomial, interpolatingPolynomial.calculateInterpolatingPolynomialUsingForwardDifferences());
            Assert.AreEqual(expectedBackwardPolynomial, interpolatingPolynomial.calculateInterpolatingPolynomialUsingBackwardDifferences());
        }

    }
}
