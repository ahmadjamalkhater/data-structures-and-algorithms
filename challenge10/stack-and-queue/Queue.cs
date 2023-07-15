using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    public class Queue<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            T value = front.Value;
            front = front.Next;

            if (front == null)
                rear = null;

            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            return front.Value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
