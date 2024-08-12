using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.History
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

        public void executeGDC()
        {
            GCD gcd = new GCD();

            int[] arr1 = { 2, 3, 4, 5, 6 };
            int n1 = arr1.Length;
            Console.Write("\n GDC 1 = " + gcd.calculationGCD(arr1, n1));

            int[] arr2 = { 2, 4, 6, 8, 10 };
            int n2 = arr2.Length;
            Console.Write("\n GDC 2 = " + gcd.calculationGCD(arr2, n2));
        }
    }
}
