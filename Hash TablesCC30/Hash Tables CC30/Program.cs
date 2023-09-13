namespace Hash_Tables_CC30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable<string, int> hashtable = new Hashtable<string, int>();
            hashtable.Set("one", 1);
            hashtable.Set("two", 2);
            hashtable.Set("three", 3);

            Console.WriteLine(hashtable.Get("two")); // Output: 2
            Console.WriteLine(hashtable.Has("four")); // Output: False
            Console.WriteLine(hashtable.Has("one"));  // Output: True

            foreach (var key in hashtable.Keys())
            {
                Console.WriteLine(key);
            }
        }
    }
}