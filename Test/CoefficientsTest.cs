using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class CoefficientsTest
    {
        //Ejemplo extraido de la pagina 82 de la Guia Teorica @ 2 Parte
        [TestMethod]
        public void test_coefficients_1()
        {
            var ordenedPairOne = new OrdenedPair { xValue = 0, yValue = 1 };
            var ordenedPairTwo = new OrdenedPair { xValue = 1, yValue = 1 };
            var ordenedPairThree = new OrdenedPair { xValue = 2, yValue = 2 };
            var ordenedPairFour = new OrdenedPair { xValue = 3, yValue = 5 };

            var interpolatingPolynomial = new InterpolatingPolynomial();

            interpolatingPolynomial.ordenedPairs.Add(ordenedPairOne);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairTwo);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairThree);
            interpolatingPolynomial.ordenedPairs.Add(ordenedPairFour);

            var coefficients = interpolatingPolynomial.calculateCoefficients();

            Assert.AreEqual(1.0f, coefficients.ElementAt(0));
            Assert.AreEqual(0.0f, coefficients.ElementAt(1));
            Assert.AreEqual(1.0f/2.0f, coefficients.ElementAt(2));
            Assert.AreEqual(1.0f/6.0f, coefficients.ElementAt(3));
        }
    }
}
