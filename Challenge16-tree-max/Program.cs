namespace Challenge16_tree_max;
using System;
internal class Program
{
    static void Main(string[] args)
    {
    BinaryTree tree = new BinaryTree();

    tree.Root = new TreeNode(5);
    tree.Root.Left = new TreeNode(3);
    tree.Root.Right = new TreeNode(8);
    tree.Root.Left.Left = new TreeNode(2);
    tree.Root.Left.Right = new TreeNode(7);
    tree.Root.Right.Left = new TreeNode(6);
    tree.Root.Right.Right = new TreeNode(11);

    int max_value = tree.FindMax();
    Console.WriteLine(max_value); // Output: 11
}
}
