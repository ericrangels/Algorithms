using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BinaryTree
    {
       public Node root;



        /// <summary>
        /// Find the Maximum Depth Node in a Binary Search Tree.
        /// </summary>
        public int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                /// <summary>
                /// Compute the depth of each subtree.
                /// </summary>
                int lDepth = maxDepth(node.left);
                int rDepth = maxDepth(node.right);

                /// <summary>
                /// Use the larger one.
                /// </summary>
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        /// <summary>
        /// Find the Lowest Common Ancestor (LCA) in a Binary Search Tree.
        /// </summary>
        public virtual Node lca(Node node, int n1, int n2)
        {
            if (node == null)
            {
                return null;
            }

            /// <summary>
            /// If both n1 and n2 are smaller than root, then LCA lies in left.
            /// </summary>
            if (node.data > n1 && node.data > n2)
            {
                return lca(node.left, n1, n2);
            }

            /// <summary>
            /// If both n1 and n2 are greater than root, then LCA lies in right.
            /// </summary>
            if (node.data < n1 && node.data < n2)
            {
                return lca(node.right, n1, n2);
            }

            return node;
        }

        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

    }
}
