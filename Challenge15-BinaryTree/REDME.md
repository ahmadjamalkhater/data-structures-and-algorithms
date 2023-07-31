﻿# Binary Search Tree Implementation in C#

## Description

This project provides a C# implementation of a Binary Search Tree (BST) data structure. A Binary Search Tree is a type of binary tree where each node has at most two children, and the left child's value is less than the parent's value, while the right child's value is greater than or equal to the parent's value. The project offers methods to add elements to the tree and check if a specific value exists in the tree.

## Approach & Efficiency

### Adding an Element

When adding an element to the Binary Search Tree, the `Add` method is called, which uses a private helper method `AddNode`. The `AddNode` method recursively traverses the tree to find the appropriate position for the new value based on the comparison with the current node's value. If the value is greater than the current node's value, it moves to the right child; otherwise, it moves to the left child. Once the correct position is found, the new node is created and attached as either the left or right child of the last node in the path. The time complexity for adding an element is O(h), where h is the height of the tree. In a balanced BST, the height is log(n), where n is the number of nodes, making the insertion O(log n). However, in the worst case, the tree can become skewed, leading to O(n) time complexity for insertion.

### Checking Element Existence

To check if a specific value exists in the Binary Search Tree, the `Contains` method is called. The `Contains` method also uses a private helper method `ContainsNode`, which traverses the tree similarly to the `AddNode` method, but instead of adding elements, it checks for equality with the target value at each node. If the target value is found, the method returns true. Otherwise, it continues the search based on the comparison of the target value with the current node's value. The time complexity for checking the existence of an element is also O(h), where h is the height of the tree.

### Traversal Methods

The project also provides three different methods for traversing the Binary Search Tree: pre-order, in-order, and post-order traversal. All three traversal methods use recursion to visit each node in the tree and perform specific operations. The time complexity for each traversal method is O(n), where n is the number of nodes in the tree, as each node needs to be visited exactly once.
## Assest
![1](./Assest/aa)
![2](./Assest/dd)
![3](./Assest/ff)
![4](./Assest/ss)
## Solution

To use the Binary Search Tree implementation, follow these steps:

1. Include the `BinarySearchTree.cs`, `BinaryTree.cs`, and `Node.cs` files into your C# project.
2. Create a new instance of `BinarySearchTree` with the desired data type, e.g., `BinarySearchTree<int>` for integers.
3. Use the `Add` method to add elements to the tree.
4. Use the `Contains` method to check if a value exists in the tree.
5. Optionally, use the traversal methods `PreOrderTraversal`, `InOrderTraversal`, and `PostOrderTraversal` to explore the elements in the tree.

Example:

```csharp
namespace Challenge15_BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();

            newTree.Add(20);
            newTree.Add(30);
            newTree.Add(25);
            newTree.Add(15);

            newTree.Add(10);

            newTree.Add(5);
            newTree.Add(35);
            newTree.Add(40);
            newTree.Add(21);


            Console.WriteLine("InOrder Traversal here -----");
            string result2 = String.Join(",", newTree.InOrder(newTree.Root, new List<int>()));

            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("PreOder Traversal here -----");
            string result1 = String.Join(",", newTree.PreOder(newTree.Root, new List<int>()));
            Console.WriteLine(result1);
            Console.WriteLine();


            Console.WriteLine("PostOrder Traversal here -----");
            string result3 = String.Join(",", newTree.PostOrder(newTree.Root, new List<int>()));
            Console.WriteLine(result3);
            Console.WriteLine();

            Console.WriteLine(newTree.Contains(34));
        }
    }
}