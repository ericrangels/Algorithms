using Algorithms.LeetCode.Arrays_Strings;
using Algorithms.LeetCode.Trees_Graphs;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.RunBinaryTree();
        }

        public void Executions()
        {
            #region Arrays-Strings
            GroupAnagrams groupAnagrams = new GroupAnagrams();
            groupAnagrams.RunGroupAnagrams();

            LongestSubstring longestSubstring = new LongestSubstring();
            longestSubstring.RunLengthOfLongestSubstring();
            #endregion
        }
    }
}
