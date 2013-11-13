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

        public List<float> coefficients { set; get; }

        #endregion

        #region Methods

        public InterpolatingPolynomial()
        {
            ordenedPairs = new List<OrdenedPair>();
            coefficients = new List<float>();
        }

        public string calculateInterpolatingPolynomialUsingForwardDifferences()
        {
            calculateCoefficients();

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(coefficients.ElementAt(0));

            for (int count = 1; count <= coefficients.Count - 1; count++)
            {
                var coefficientWithSign = coefficients.ElementAt(count) >= 0 ? " + " + coefficients.ElementAt(count) : " - " + coefficients.ElementAt(count).ToString().Substring(1);
                stringBuilder.Append(coefficientWithSign);

                for (int auxCount = 0; auxCount < count; auxCount++){
                    var xValueToAdd = ordenedPairs.ElementAt(auxCount).xValue >= 0 ? " * ( X - " + ordenedPairs.ElementAt(auxCount).xValue + " )" : " * ( X + " + ordenedPairs.ElementAt(auxCount).xValue.ToString().Substring(1) + " )";
                    stringBuilder.Append(xValueToAdd);
                }

            }

            return stringBuilder.ToString();
        }

        public string calculateInterpolatingPolynomialUsingBackwardDifferences()
        {
            throw new NotImplementedException();
        }


        public float calculateForwardDividedDifferencesOfOrdenedPairsOfOrder1(List<OrdenedPair> someOrdenedPairs)
        {

            var newDifference = (someOrdenedPairs.ElementAt(0).yValue - someOrdenedPairs.ElementAt(1).yValue) /
                                (someOrdenedPairs.ElementAt(0).xValue - someOrdenedPairs.ElementAt(1).xValue);
            
            return newDifference;

        }

        public List<float> calculateForwardDividedDifferencesOfOrdenedPairs(int maxOrder,int increment, List<OrdenedPair> someOrdenedPairs, List<float> partialResults,List<float> calculatedCoefficients){
          
            
            var partialResultantList = partialResults==null ? new List<float>() : partialResults;

            var dividedDifferencesOfOrdenedPairsOfOrder1 = new List<float>();

            var minCount = 0;

            for(int count=maxOrder-1;count>0;count--){

                if(partialResultantList.Count.Equals(0)){

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateForwardDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>(){someOrdenedPairs.ElementAt(count),someOrdenedPairs.ElementAt(count - 1)}));
                
                }else{

                    dividedDifferencesOfOrdenedPairsOfOrder1.Add(this.calculateForwardDividedDifferencesOfOrdenedPairsOfOrder1(new List<OrdenedPair>() { new OrdenedPair() { yValue = partialResultantList.ElementAt(count - 1), xValue = someOrdenedPairs.ElementAt(minCount+increment).xValue }, new OrdenedPair() { yValue = partialResultantList.ElementAt(count), xValue = someOrdenedPairs.ElementAt(minCount).xValue } })); 

                    minCount++;
                }
            }            

            maxOrder = maxOrder -1;

            if (partialResultantList.Count.Equals(0)){

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(maxOrder - 1));


                partialResultantList = dividedDifferencesOfOrdenedPairsOfOrder1;

            }else{

                calculatedCoefficients.Add(dividedDifferencesOfOrdenedPairsOfOrder1.ElementAt(0));


                partialResultantList = ((IEnumerable<float>)dividedDifferencesOfOrdenedPairsOfOrder1).Reverse().ToList();
            }               

            if (!partialResultantList.Count.Equals(1))
                this.calculateForwardDividedDifferencesOfOrdenedPairs(maxOrder,increment+1, someOrdenedPairs, partialResultantList, calculatedCoefficients);

            return calculatedCoefficients;
        }

        public List<float> calculateCoefficients()
        {
            coefficients = new List<float>();
            coefficients.Add(ordenedPairs.ElementAt(0).yValue);
            this.calculateForwardDividedDifferencesOfOrdenedPairs(ordenedPairs.Count,1, ordenedPairs, null,new List<float>()).ForEach(oneCoefficient => coefficients.Add(oneCoefficient));

           
             
            return coefficients;
        }

        #endregion
    }
}