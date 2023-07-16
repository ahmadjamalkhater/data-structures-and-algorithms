using challenge11;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_.challenge11.pseudo_queue
{
    public class PseudoQueue<T>
    {
        private Stack<T> stack1;
        private Stack<T> stack2;

        public PseudoQueue()
        {
            stack1 = new Stack<T>();
            stack2 = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack1.Count == 0)
            {
                throw new InvalidOperationException("PseudoQueue is empty");
            }
            return stack1.Pop();
        }
    }
}