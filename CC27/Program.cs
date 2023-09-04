

using CC27;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            Console.WriteLine("Giving Array");

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            MargeSorts.MargeSorting(array);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}