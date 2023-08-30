using cc26;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = { 8, 4, 23, 42, 16, 15 };
            int[] sampleArray2 = { 20, 18, 12, 8, 5, -2 };
            int[] sampleArray3 = { 5, 12, 7, 5, 5, 7 };
            Console.WriteLine("First Given Array is : " + string.Join(", ", sampleArray));

            Insertions.InsertionSorting(sampleArray);

            Console.WriteLine("Sorted Array: " + string.Join(", ", sampleArray));

            Console.WriteLine("secound Given Array is : " + string.Join(", ", sampleArray2));
            Insertions.InsertionSorting(sampleArray2);
            Console.WriteLine("Secound Sorted Array: " + string.Join(", ", sampleArray2));
            Console.WriteLine("third Given Array is : " + string.Join(", ", sampleArray3));
            Insertions.InsertionSorting(sampleArray3);
            Console.WriteLine("third Sorted Array: " + string.Join(", ", sampleArray3));
        }
    }
}