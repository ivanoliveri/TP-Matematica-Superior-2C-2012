using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public static class MathHelper
    {
        public static int calculateFactorial(int oneNumber){

            var newResult = 1;

            for (int count = oneNumber; count != 0; count--)
                newResult *= count;

            return newResult;

        }
    }
}
