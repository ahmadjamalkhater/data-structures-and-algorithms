using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge16_tree_max
{
    internal class BinaryTree
    {

        public TreeNode Root { get; set; }

        public int FindMax()
        {
            if (Root == null)
                throw new InvalidOperationException("Binary tree is empty.");

            return FindMaxHelper(Root);
        }

        private int FindMaxHelper(TreeNode node)
        {
            if (node == null)
                return int.MinValue;

            int leftMax = FindMaxHelper(node.Left);
            int rightMax = FindMaxHelper(node.Right);

            return Math.Max(node.Value, Math.Max(leftMax, rightMax));
        }
    }
}
