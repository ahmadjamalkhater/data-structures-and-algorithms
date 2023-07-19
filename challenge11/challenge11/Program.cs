using data_structures_and_algorithms_.challenge11.pseudo_queue;

namespace challenge11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();
            pseudoQueue.Enqueue();
            pseudoQueue.Enqueue();
            pseudoQueue.Enqueue();

            int value = pseudoQueue.Dequeue(); // Returns 10
            Console.WriteLine(value);

            value = pseudoQueue.Dequeue(); // Returns 15
            Console.WriteLine(value);
        }
    }
}
