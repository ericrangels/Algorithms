using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode.Arrays_Strings
{
    internal class LongestSubstring
    {
        /**
         * Given a string s, find the length of the longest substring without repeating characters.
         * 
         * Example:
         * Input: s = "abcabcbb"
         * Output: 3
         * Explanation: The answer is "abc", with the length of 3.
         *
         **/
        
        public int GetLengthOfLongestSubstring(string s)
        {
            var countTemp = 0;
            var countResult = 0;
            var letters = new Dictionary<int, string>();

            for (int i = 0; i < s.Length; i++)
            {
                var letter = s.Substring(i, 1);

                foreach (var item in letters)
                {
                    if (letter == item.Value)
                    {
                        var remainingLetters = letters.Where(l => l.Key > item.Key);
                        countTemp = remainingLetters.Count();

                        var removeLetters = letters.Where(l => l.Key <= item.Key);
                        foreach (var rl in removeLetters)
                        {
                            letters.Remove(rl.Key);
                        }
                    }
                }
                countTemp++;
                letters.Add(i, letter);

                if (countTemp > countResult)
                {
                    countResult = countTemp;
                }
            }

            return countResult;
        }

        public void RunLengthOfLongestSubstring()
        {
            var srt = "pwwkew";

            var result = GetLengthOfLongestSubstring(srt);
        }
    }
}
