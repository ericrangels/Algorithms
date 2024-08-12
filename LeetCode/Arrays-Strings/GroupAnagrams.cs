using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode.Arrays_Strings
{
    internal class GroupAnagrams
    {
        /**
         * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
         * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
         * typically using all the original letters exactly once.
         * 
         * Example
         * Input: strs = ["eat","tea","tan","ate","nat","bat"]
         * Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
         * 
         **/

        public IList<IList<string>> GetGroupAnagrams(string[] strs)
        {
            var result = new List<List<string>>();
            var positions = new Dictionary<int, string>();
            for (int i = 0; i < strs.Length; i++)
            {
                positions.Add(i, String.Concat(strs[i].OrderBy(c => c)));
            }

            foreach (var item in positions)
            {
                var temp = new List<string>();
                var text = item.Value;
                temp.Add(strs[item.Key]);
                positions.Remove(item.Key);

                foreach (var comb in positions)
                {
                    if (comb.Value == text)
                    {
                        temp.Add(strs[comb.Key]);
                        positions.Remove(comb.Key);
                    }
                }
                var listOrdered = temp.OrderBy(t => t).ToList();
                result.Add(listOrdered);
            }

            var orderedResult = result.OrderBy(r => r.Sum(a => a.Count())).ToList();

            IList<IList<string>> IResult = orderedResult.ToList<IList<string>>();
            return IResult;
        }

        public void RunGroupAnagrams()
        {
            var srts = new string[6];
            srts[0] = "eat";
            srts[1] = "tea";
            srts[2] = "tan";
            srts[3] = "ate";
            srts[4] = "nat";
            srts[5] = "bat";

            var result = GetGroupAnagrams(srts);
        }
    }
}