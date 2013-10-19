﻿using System;
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

        public int calculateProgressiveDifferencesOfOrdenedPairs(int maxOrder,List<OrdenedPair> someOrdenedPairs){

            List<OrdenedPair> resultantOrdenedPairds=null;

            for (int countOrder = 0; countOrder < maxOrder; countOrder++){

                if (resultantOrdenedPairds == null)
                    resultantOrdenedPairds = someOrdenedPairs;
                
                var newResultantOrdenedPairs = new List<OrdenedPair>();

                for (int count = 0; count < resultantOrdenedPairds.Count-1; count++)
                {
                    var newYValue = resultantOrdenedPairds.ElementAt(count+1).yValue - resultantOrdenedPairds.ElementAt(count).yValue;
                    newResultantOrdenedPairs.Add(new OrdenedPair { yValue = newYValue });
                }

                resultantOrdenedPairds = newResultantOrdenedPairs;

            }

            return resultantOrdenedPairds.ElementAt(0).yValue;

        }

        public List<float> calculateCoefficients()
        {
            coefficients.Add(ordenedPairs.ElementAt(0).yValue);

            for (int count = 1; count < ordenedPairs.Count; count++)
            {
                float newCoefficient = ((float)ordenedPairs.ElementAt(0).yValue * (float)calculateProgressiveDifferencesOfOrdenedPairs(count, ordenedPairs.Take(count + 1).ToList<OrdenedPair>())) / ((float)MathHelper.calculateFactorial(count) * (float) (ordenedPairs.ElementAt(count).xValue - ordenedPairs.ElementAt(count - 1).xValue));
                coefficients.Add(newCoefficient);
            }

            return coefficients;
        }

        public void calculateInterpolatingPolynomial()
        {

        }

        public string getInterpolatingPolynomial()
        {
            calculateInterpolatingPolynomial();
            throw new NotImplementedException();
        }

        #endregion
    }
}
