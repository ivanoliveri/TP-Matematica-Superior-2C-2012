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
        //Ejemplo extraido de la pagina 82 de la Guia Teorica @ 2 Parte. Puntos Equidistantes usando diferencias PROGRESIVAS
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

            var coefficients = interpolatingPolynomial.calculateCoefficientsUsingForwardDifferences();

            Assert.AreEqual(1.0f, coefficients.ElementAt(0));
            Assert.AreEqual(0.0f, coefficients.ElementAt(1));
            Assert.AreEqual(1.0f/2.0f, coefficients.ElementAt(2));
            Assert.AreEqual(1.0f/6.0f, coefficients.ElementAt(3));
        }

        //Ejemplo extraido de la pagina 85 de la Guia Teorica @ 2 Parte. Puntos NO Equidistantes usando diferencias PROGRESIVAS
        [TestMethod]
        public void test_coefficients_2()
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

            var coefficients = interpolatingPolynomial.calculateCoefficientsUsingForwardDifferences();

            Assert.AreEqual(1.0f, coefficients.ElementAt(0));
            Assert.AreEqual(1.0f, coefficients.ElementAt(1));
            Assert.AreEqual(3.0f, coefficients.ElementAt(2));
            Assert.AreEqual(1.0f, coefficients.ElementAt(3));
            Assert.AreEqual(0.0f, coefficients.ElementAt(4));
        }

        //Ejemplo extraido de la pagina 85 de la Guia Teorica @ 2 Parte. Puntos NO Equidistantes usando diferencias REGRESIVAS
        [TestMethod]
        public void test_coefficients_3()
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

            var coefficients = interpolatingPolynomial.calculateCoefficientsUsingBackwardDifferences();

            Assert.AreEqual(151.0f, coefficients.ElementAt(0));
            Assert.AreEqual(57.0f, coefficients.ElementAt(1));
            Assert.AreEqual(11.0f, coefficients.ElementAt(2));
            Assert.AreEqual(1.0f, coefficients.ElementAt(3));
            Assert.AreEqual(0.0f, coefficients.ElementAt(4));
        }
    }
}
