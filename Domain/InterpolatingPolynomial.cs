using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class InterpolatingPolynomial
    {
        #region Properties

        public List<OrdenedPair> ordenedPairs { set; get; }

        public List<float> backwardCoefficients { set; get; }

        public List<float> forwardCoefficients { set; get; }

        #endregion

        #region Methods

        public InterpolatingPolynomial()
        {
            ordenedPairs = new List<OrdenedPair>();
            forwardCoefficients = new List<float>();
            backwardCoefficients = new List<float>();
        }

        public string calculateInterpolatingPolynomialUsingForwardDifferences()
        {
            this.calculateCoefficientsUsingForwardDifferences();

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(forwardCoefficients.ElementAt(0));

            for (int count = 1; count <= forwardCoefficients.Count - 1; count++)
            {
                var coefficientWithSign = forwardCoefficients.ElementAt(count) >= 0 ? " + " + forwardCoefficients.ElementAt(count) : " - " + forwardCoefficients.ElementAt(count).ToString().Substring(1);
                stringBuilder.Append(coefficientWithSign);

                for (int auxCount = 0; auxCount < count; auxCount++){
                    var xValueToAdd = ordenedPairs.ElementAt(auxCount).xValue >= 0 ? " * ( X - " + ordenedPairs.ElementAt(auxCount).xValue + " )" : " * ( X + " + ordenedPairs.ElementAt(auxCount).xValue.ToString().Substring(1) + " )";
                    stringBuilder.Append(xValueToAdd);
                }

            }

            return stringBuilder.ToString();
        }

        public List<float> calculateCoefficientsUsingForwardDifferences()
        {
            forwardCoefficients = new List<float>{ordenedPairs.ElementAt(0).yValue};
            this.calculateForwardDividedDifferencesOfOrdenedPairs(ordenedPairs.Count, 1, ordenedPairs, null, new List<float>()).ForEach(oneCoefficient => forwardCoefficients.Add(oneCoefficient));

            return forwardCoefficients;
        }

        public float calculateDividedDifferencesOfOrdenedPairsOfOrder1(List<OrdenedPair> someOrdenedPairs)
        {

            var newDifference = (someOrdenedPairs.ElementAt(0).yValue - someOrdenedPairs.ElementAt(1).yValue) /
                                (someOrdenedPairs.ElementAt(0).xValue - someOrdenedPairs.ElementAt(1).xValue);
            
            return newDifference;

        }

        public List<float> calculateForwardDividedDifferencesOfOrdenedPairs(int maxOrder,int increment, List<OrdenedPair> someOrdenedPairs, List<float> partialResults,List<float> calculatedCoefficients){

            var partialResultantList = partialResults ?? new List<float>();

            var dividedDifferencesOfOrdenedPairsOfOrder1 = new List<float>();

            var minCount = 0;

            for (int count = maxOrder - 1; count > 0; count--)
            {

                if (partialResultantList.Count.Equals(0))
                {

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { someOrdenedPairs.ElementAt(count), someOrdenedPairs.ElementAt(count - 1) }));

                }
                else
                {

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { new OrdenedPair() { yValue = partialResultantList.ElementAt(count - 1), xValue = someOrdenedPairs.ElementAt(minCount + increment).xValue }, new OrdenedPair() { yValue = partialResultantList.ElementAt(count), xValue = someOrdenedPairs.ElementAt(minCount).xValue } }));

                    minCount++;
                }
            }

            maxOrder = maxOrder - 1;

            if (partialResultantList.Count.Equals(0))
            {

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(maxOrder - 1));


                partialResultantList = dividedDifferencesOfOrdenedPairsOfOrder1;

            }
            else
            {

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(0));


                partialResultantList = ((IEnumerable<float>)dividedDifferencesOfOrdenedPairsOfOrder1).Reverse().ToList();
            }

            if (!partialResultantList.Count.Equals(1))
                this.calculateForwardDividedDifferencesOfOrdenedPairs(maxOrder, increment + 1, someOrdenedPairs, partialResultantList, calculatedCoefficients);

            return calculatedCoefficients;
        }

        public List<float> calculateBackwardDividedDifferencesOfOrdenedPairs(int maxOrder, int increment, List<OrdenedPair> someOrdenedPairs, List<float> partialResults, List<float> calculatedCoefficients)
        {
            var partialResultantList = partialResults ?? new List<float>();

            var dividedDifferencesOfOrdenedPairsOfOrder1 = new List<float>();

            var minCount = 0;

            for (int count = maxOrder - 1; count > 0; count--)
            {

                if (partialResultantList.Count.Equals(0))
                {

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { someOrdenedPairs.ElementAt(count), someOrdenedPairs.ElementAt(count - 1) }));

                }
                else
                {

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { new OrdenedPair() { yValue = partialResultantList.ElementAt(count - 1), xValue = someOrdenedPairs.ElementAt(minCount + increment).xValue }, new OrdenedPair() { yValue = partialResultantList.ElementAt(count), xValue = someOrdenedPairs.ElementAt(minCount).xValue } }));

                    minCount++;
                }
            }

            maxOrder = maxOrder - 1;

            if (partialResultantList.Count.Equals(0))
            {

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(0));


                partialResultantList = dividedDifferencesOfOrdenedPairsOfOrder1;

            }
            else
            {

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(maxOrder - 1));


                partialResultantList = ((IEnumerable<float>)dividedDifferencesOfOrdenedPairsOfOrder1).Reverse().ToList();
            }

            if (!partialResultantList.Count.Equals(1))
                this.calculateBackwardDividedDifferencesOfOrdenedPairs(maxOrder, increment + 1, someOrdenedPairs, partialResultantList, calculatedCoefficients);

            return calculatedCoefficients;
        }

        public List<float> calculateCoefficientsUsingBackwardDifferences()
        {
            backwardCoefficients = new List<float>{ordenedPairs.ElementAt(ordenedPairs.Count - 1).yValue};
            this.calculateBackwardDividedDifferencesOfOrdenedPairs(ordenedPairs.Count, 1, ordenedPairs, null, new List<float>()).ForEach(oneCoefficient => backwardCoefficients.Add(oneCoefficient));

            return backwardCoefficients;
        }

        public string calculateInterpolatingPolynomialUsingBackwardDifferences()
        {
            this.calculateCoefficientsUsingBackwardDifferences();

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(backwardCoefficients.ElementAt(0));

            for (int count = 1; count <= backwardCoefficients.Count - 1; count++)
            {
                var coefficientWithSign = backwardCoefficients.ElementAt(count) >= 0 ? " + " + backwardCoefficients.ElementAt(count) : " - " + backwardCoefficients.ElementAt(count).ToString().Substring(1);
                stringBuilder.Append(coefficientWithSign);

                for (int auxCount = 1; auxCount <= count; auxCount++)
                {
                    var xValueToAdd = ordenedPairs.ElementAt(ordenedPairs.Count - auxCount).xValue >= 0 ? " * ( X - " + ordenedPairs.ElementAt(ordenedPairs.Count - auxCount).xValue + " )" : " * ( X + " + ordenedPairs.ElementAt(ordenedPairs.Count - auxCount).xValue.ToString().Substring(1) + " )";
                    stringBuilder.Append(xValueToAdd);
                }

            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}