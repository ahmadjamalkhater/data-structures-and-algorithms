# Find the Maximum Value in a Binary Tree

## Description

This challenge involves finding the maximum value stored in a binary tree. You can assume that the values stored in the binary tree will be numeric.

## Whiteboard Process

<!-- Add the image of your whiteboard process here -->

## Approach & Efficiency

To find the maximum value in the binary tree, we'll use a recursive approach to traverse the tree and keep track of the maximum value found so far. For each node, we'll compare its value with the maximum value found in its left and right subtrees and return the maximum of the three values.

The time complexity of this approach is O(n), where n is the number of nodes in the binary tree. This is because we need to visit every node in the worst case to find the maximum value.

The space complexity of this approach is O(h), where h is the height of the binary tree. In the worst case, the height of the binary tree can be equal to the number of nodes (n) for an unbalanced tree, resulting in O(n) space complexity. However, for a balanced binary tree, the height is log(n), leading to O(log(n)) space complexity.

## Solution

```csharp
using System;

class Program
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
