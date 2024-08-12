using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.History
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

        public void executeHourGlass()
        {
            HourGlass hourGlass = new HourGlass();

            /* Examples
            int[][] arr = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

            int[][] arr1 = new int[6][] {new int[] { -1, -1,  0, -9, -2, -2 },
                                         new int[] { -2, -1, -6, -8, -2, -5 },
                                         new int[] { -1, -1, -1, -2, -3, -4 },
                                         new int[] { -1, -9, -2, -4, -4, -5 },
                                         new int[] { -7, -3, -3, -2, -9, -9 },
                                         new int[] { -1, -3, -1, -2, -4, -5 }};
             */

            int[][] arr = new int[6][] {new int[] { 0, -4, -6,  0, -7, -6 },
                                         new int[] {-1, -2, -6, -8, -3, -1 },
                                         new int[] {-8, -4, -2, -8, -8, -6 },
                                         new int[] {-3, -1, -2, -5, -7, -4 },
                                         new int[] {-3, -5, -3, -6, -6, -6 },
                                         new int[] {-3, -6,  0, -8, -6, -7 }};

            int result = hourGlass.hourglassSum(arr);

        }
    }
}
