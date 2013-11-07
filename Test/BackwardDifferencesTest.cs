using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class BackwardDifferencesTest
    {
        //Ejemplo extraido de la carpeta
        [TestMethod]
        public void TestBackwardDifference1()
        {
            var ordenedPairOne = new OrdenedPair { xValue = 1, yValue = 1 };
            var ordenedPairTwo = new OrdenedPair { xValue = 2, yValue = 5 };
            var ordenedPairThree = new OrdenedPair { xValue = 3, yValue = 7 };
            var ordenedPairFour = new OrdenedPair { xValue = 4, yValue = 3 };
            var ordenedPairFive = new OrdenedPair { xValue = 5, yValue = 8 };

            var interpolatingPolynomial = new InterpolatingPolynomial();

            interpolatingPolynomial.ordenedPairs.Add(ordenedPairOne);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairTwo);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairThree);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFour);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFive);

            var result = interpolatingPolynomial.calculateBackwardDifferencesOfOrdenedPairs(4, interpolatingPolynomial.ordenedPairs);

            Assert.AreEqual(19, result);
        }
    }
}
