using System;
using System.Collections.Generic;
using System.Text;
using static Algorithms.History.BinaryTree;

namespace Algorithms.LeetCode.Trees_Graphs
{
    internal class BinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public List<int> GetBinaryTreeTraversal(TreeNode root)
        {
            var list = new List<int>();
            int h = GetTreeHeight(root);
            int i;
            for (i = 1; i <= h; i++)
            {
                AddCurrentLevelValue(root, i, list);
            }

            return list;
        }

        public static void AddCurrentLevelValue(TreeNode root, int level, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                list.Add(root.val);
            }
            else if (level > 1)
            {
                AddCurrentLevelValue(root.left, level - 1, list);
                AddCurrentLevelValue(root.right, level - 1, list);
            }
        }

        public static int GetTreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                // Compute height of each subtree
                int lheight = GetTreeHeight(root.left);
                int rheight = GetTreeHeight(root.right);

                // use the larger one
                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }

        public void RunBinaryTree()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            var height = GetTreeHeight(root);
            var result = GetBinaryTreeTraversal(root);
        }

    }
}
