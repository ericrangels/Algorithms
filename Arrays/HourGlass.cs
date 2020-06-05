using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class HourGlass
    {
        public int hourglassSum(int[][] arr)
        {

            int sumGlass = 0;
            int result = -1000000;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    sumGlass = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                           +arr[i + 1][j + 1] +
                               arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];


                    if (sumGlass > result)
                    {
                        result = sumGlass;
                    }

                }

            }

            return result;
        }
    }
}
