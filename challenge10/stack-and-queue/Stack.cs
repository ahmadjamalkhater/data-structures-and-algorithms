using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    public class Stack<T>
    {
        private Node<T> top;

        public Stack()
        {
            top = null;
        }

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T value = top.Value;
            top = top.Next;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return top.Value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

}
