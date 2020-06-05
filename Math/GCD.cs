using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class GCD
    {
        /// <summary>
        /// Find GCD(Greatest Common Divisor) or HCF(Highest Common Factor) 
        /// of two numbers is the largest number that divides both of them.
        /// </summary>
        static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        /// <summary>
        /// Return GCD of an array of numbers.
        /// </summary>
        public int calculationGCD(int[] arr, int num)
        {
            int result = arr[0];
            int i = 1;

            while (i < num)
            {
                result = gcd(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }

                i++;
            }

            return result;
        }
    }
}
