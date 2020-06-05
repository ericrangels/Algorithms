using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TwoStrings
    {
        public string checkTwoStringsV1(string s1, string s2)
        {
            int y = 0;
            int z = 0;

            string s1L;
            string response = "NO";


            while (y < s1.Length)
            {
                s1L = s1.Substring(y, 1);
                z = 0;

                while (z < s2.Length)
                {
                    if (s1L.IndexOf(s2.Substring(z, 1)) == 0)
                    {
                        response = "YES";
                        break;
                    }
                    else
                    {
                        z++;
                    }
                }

                y++;
            }

            return response;
        }

        public string checkTwoStringsV2(string s1, string s2)
        {
            char[] s1Array = s1.GroupBy(g => g).Select(s => s.OrderBy(o => o).First()).ToArray();
            char[] s2Array = s2.GroupBy(g => g).Select(s => s.OrderBy(o => o).First()).ToArray();

            int y = 0;
            int z = 0;
            int pointer = 0;

            string response = "NO";

            while (y < s1Array.Length)
            {
                z = pointer;

                while (z < s2Array.Length)
                {
                    if (s1Array[y] == s2Array[z])
                    {
                        response = "YES";
                        pointer = z + 1;
                        break;
                    }
                    else
                    {
                        z++;
                    }
                }

                y++;
            }

            return response;
        }
    }
}
