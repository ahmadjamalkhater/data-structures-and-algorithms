using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public T[] PreOrderTraversal()
        {
            List<T> result = new List<T>();
            PreOrderTraversal(Root, result);
            return result.ToArray();
        }

        private void PreOrderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                result.Add(node.Value);
                PreOrderTraversal(node.Left, result);
                PreOrderTraversal(node.Right, result);
            }
        }

        public T[] InOrderTraversal()
        {
            List<T> result = new List<T>();
            InOrderTraversal(Root, result);
            return result.ToArray();
        }

        private void InOrderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Value);
                InOrderTraversal(node.Right, result);
            }
        }

        public T[] PostOrderTraversal()
        {
            List<T> result = new List<T>();
            PostOrderTraversal(Root, result);
            return result.ToArray();
        }

        private void PostOrderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left, result);
                PostOrderTraversal(node.Right, result);
                result.Add(node.Value);
            }
        }
    }
}
