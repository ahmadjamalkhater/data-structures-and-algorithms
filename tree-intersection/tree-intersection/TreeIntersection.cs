using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Tree_intersection
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class TreeIntersection
    {
        public static HashSet<int> tree_intersection(TreeNode root1, TreeNode root2)
        {
            HashSet<int> values1 = new HashSet<int>();
            HashSet<int> commonValues = new HashSet<int>();

            TraverseTree(root1, values1);
            TraverseTreeAndFindCommon(root2, values1, commonValues);

            return commonValues;
        }

        private static void TraverseTree(TreeNode node, HashSet<int> values)
        {
            if (node == null)
                return;

            values.Add(node.Value);
            TraverseTree(node.Left, values);
            TraverseTree(node.Right, values);
        }

        private static void TraverseTreeAndFindCommon(TreeNode node, HashSet<int> values1, HashSet<int> commonValues)
        {
            if (node == null)
                return;

            if (values1.Contains(node.Value))
                commonValues.Add(node.Value);

            TraverseTreeAndFindCommon(node.Left, values1, commonValues);
            TraverseTreeAndFindCommon(node.Right, values1, commonValues);
        }
    }

    
}
    