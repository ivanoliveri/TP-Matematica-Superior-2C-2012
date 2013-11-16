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

        public string buildPolynomialExpression(List<float> xValues,List<float> coefficients ){
            var stringBuilder = new StringBuilder();

            for (int count = 1; count <= coefficients.Count - 1; count++){
                var coefficientWithSign = coefficients.ElementAt(count) >= 0
                    ? " + " + coefficients.ElementAt(count)
                    : " - " + coefficients.ElementAt(count).ToString().Substring(1);
                stringBuilder.Append(coefficientWithSign);

                for (int auxCount = 0; auxCount < count; auxCount++){
                    var xValueToAdd = xValues.ElementAt(auxCount) >= 0
                        ? " * ( X - " + xValues.ElementAt(auxCount) + " )"
                        : " * ( X + " + xValues.ElementAt(auxCount).ToString().Substring(1) + " )";
                    stringBuilder.Append(xValueToAdd);
                }
            }

            return stringBuilder.ToString();
        }

        public string calculateInterpolatingPolynomialUsingForwardDifferences()
        {
            this.calculateCoefficientsUsingForwardDifferences();

            var xValues = new List<float>();

            for (int count = 0; count < forwardCoefficients.Count; count++)
                xValues.Add(ordenedPairs.ElementAt(count).xValue);

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(forwardCoefficients.ElementAt(0));
            return stringBuilder.Append(this.buildPolynomialExpression(xValues,this.forwardCoefficients)).ToString();

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

            var dividedDifferencesOfOrdenedPairsOfOrder1 =  this.calculateColumnOfDividedDifferences(maxOrder,
                                                            someOrdenedPairs, partialResultantList, increment);

            maxOrder = maxOrder - 1;

            if (partialResultantList.Count.Equals(0)){

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(maxOrder - 1));


                partialResultantList = dividedDifferencesOfOrdenedPairsOfOrder1;

            }else{

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(0));


                partialResultantList = ((IEnumerable<float>)dividedDifferencesOfOrdenedPairsOfOrder1).Reverse().ToList();
            }

            if (!partialResultantList.Count.Equals(1))
                this.calculateForwardDividedDifferencesOfOrdenedPairs(maxOrder, increment + 1, someOrdenedPairs, partialResultantList, calculatedCoefficients);

            return calculatedCoefficients;
        }

        public List<float> calculateColumnOfDividedDifferences(int maxOrder, List<OrdenedPair> someOrdenedPairs, List<float> partialResults,int increment){

            var dividedDifferencesOfOrdenedPairsOfOrder1 = new List<float>();

            var minCount = 0;

            for (int count = maxOrder - 1; count > 0; count--){

                if (partialResults.Count.Equals(0)){

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { someOrdenedPairs.ElementAt(count), someOrdenedPairs.ElementAt(count - 1) }));

                }else{

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { new OrdenedPair() { yValue = partialResults.ElementAt(count - 1), xValue = someOrdenedPairs.ElementAt(minCount + increment).xValue }, new OrdenedPair() { yValue = partialResults.ElementAt(count), xValue = someOrdenedPairs.ElementAt(minCount).xValue } }));

                    minCount++;
                }

            }

            return dividedDifferencesOfOrdenedPairsOfOrder1;
        }

        public List<float> calculateBackwardDividedDifferencesOfOrdenedPairs(int maxOrder, int increment, List<OrdenedPair> someOrdenedPairs, List<float> partialResults, List<float> calculatedCoefficients)
        {
            var partialResultantList = partialResults ?? new List<float>();

            var dividedDifferencesOfOrdenedPairsOfOrder1 =  this.calculateColumnOfDividedDifferences(maxOrder,
                                                            someOrdenedPairs, partialResultantList, increment);

            maxOrder = maxOrder - 1;

            if (partialResultantList.Count.Equals(0)){

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(0));


                partialResultantList = dividedDifferencesOfOrdenedPairsOfOrder1;

            }else{

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

            var xValues = new List<float>();

            for (int count = 0; count < forwardCoefficients.Count; count++)
                xValues.Add(ordenedPairs.ElementAt(count).xValue);

            xValues.Reverse();

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(backwardCoefficients.ElementAt(0));
            return stringBuilder.Append(this.buildPolynomialExpression(xValues,this.backwardCoefficients)).ToString();

       
        }
        /* Para determinar el grado del polinomio puedo elegir cualquiera de los dos polinomios ya que son EQUIVALENTES. Optamos evaluar usando el polinomio progresivo*/
        public int getPolynomialDegree(){

            var lastNotZeroCoefficientPosition = 0;

            var auxCount = 0;

            foreach (var forwardCoefficient in forwardCoefficients){
                if (forwardCoefficient != 0)
                    lastNotZeroCoefficientPosition = auxCount;
                auxCount++;
            }

            return lastNotZeroCoefficientPosition;
        }

        /* Se usa cuando se saca/agrega un par ordenado para evaluar el grado del nuevo polinomio sin calcularlo */
        public int getPolynomialDegreeWithoutCalculatingInterpolatingPolynomial(List<OrdenedPair> somePairs ){

            var newPolynomial = new InterpolatingPolynomial();

            newPolynomial.ordenedPairs = somePairs;

            newPolynomial.calculateCoefficientsUsingForwardDifferences();

            return newPolynomial.getPolynomialDegree();

        }

        /* Para evaluar puedo elegir cualquiera de los dos polinomios ya que son EQUIVALENTES. Optamos evaluar usando el polinomio progresivo*/
        public float evaluatePolynomialAt(float aValue){

            var xValues = new List<float>();

            for (int count = 0; count < forwardCoefficients.Count; count++)
                xValues.Add(ordenedPairs.ElementAt(count).xValue);

            var result = forwardCoefficients.ElementAt(0);

            for (int count = 1; count <= forwardCoefficients.Count - 1; count++){
                var newTerm = forwardCoefficients.ElementAt(count);
                for (int auxCount = 0; auxCount < count; auxCount++)
                    newTerm *= (aValue-xValues.ElementAt(auxCount));
                result += newTerm;
            }

            return result;
        }

        public string getInterpolationInterval(){

            var xValues = new List<float>();

            ordenedPairs.ForEach(aPair => xValues.Add(aPair.xValue));

            var maxX = xValues.Max();

            var minX = xValues.Min();

            return  new StringBuilder().Append("[")
                                       .Append(minX)
                                       .Append(",")
                                       .Append(maxX)
                                       .Append("]")
                                       .ToString();
        }

        #endregion
    }
}