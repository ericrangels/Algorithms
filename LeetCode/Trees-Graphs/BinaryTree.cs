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

        public void GetBinaryTreeTraversal(TreeNode root, List<int> list)
        {
            if (root != null)
            {
                list.Add(root.val);
                GetBinaryTreeTraversal(root.left, list);
                GetBinaryTreeTraversal(root.right, list);
            }
        }

        public void RunBinaryTree()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            var result = new List<int>();

            GetBinaryTreeTraversal(root, result);
        }

    }
}
