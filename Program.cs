using System;
using System.Collections.Generic;
using static Algorithms.BinaryTree;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            // Arrays
            program.executeHourGlass();

            /* Dictionaries and Hashmaps
            program.executeRansomNote();
            program.executeTwoStrings();
            */

            /* Math
            program.executeGDC();
            */

            /* Trees
            program.executeBynaryTree();
            */
        }


        #region Arrays
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
        #endregion

        #region Dictionaries and Hashmaps
        public void executeRansomNote()
        {
            RansomNote ransomNote = new RansomNote();

            string[] magazine = { "give", "me", "one", "grand", "today", "night" };
            string[] note = { "give", "one", "grand", "today" };

            ransomNote.checkMagazine(magazine, note);
        }

        public void executeTwoStrings()
        {
            TwoStrings twoStrings = new TwoStrings();

            string s1 = "hello";
            string s2 = "world";

            var teste = twoStrings.checkTwoStringsV2(s1, s2);
        }
        #endregion

        #region Math
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
        #endregion

        #region Trees
        public void executeBynaryTree()
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Height of tree is : " + tree.maxDepth(tree.root));
        }
        #endregion

    }
}
