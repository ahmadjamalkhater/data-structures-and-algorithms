using Hash_Tables_CC30;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SetAndGetKeyValue()
        {
            var hashtable = new Hashtable<string, int>();
            hashtable.Set("one", 1);

            Assert.Equal(1, hashtable.Get("one"));
        }

        [Fact]
        public void GetNonExistentKey()
        {
            var hashtable = new Hashtable<string, int>();

            Assert.Throws<KeyNotFoundException>(() => hashtable.Get("nonexistent"));
        }


        [Fact]
        public void GetUniqueKeys()
        {
            var hashtable = new Hashtable<string, int>();
            hashtable.Set("one", 1);
            hashtable.Set("two", 2);
            hashtable.Set("three", 3);

            var keys = hashtable.Keys();

            Assert.Equal(3, keys.Count());
            Assert.Contains("one", keys);
            Assert.Contains("two", keys);
            Assert.Contains("three", keys);
        }

        [Fact]
        public void HandleCollision()
        {
            var hashtable = new Hashtable<string, int>(1); // Force a collision with a small capacity
            hashtable.Set("one", 1);
            hashtable.Set("neo", 42); // Collides with "one"

            Assert.Equal(1, hashtable.Get("one"));
            Assert.Equal(42, hashtable.Get("neo"));
        }

        [Fact]
        public void RetrieveValueFromCollisionBucket()
        {
            var hashtable = new Hashtable<string, int>(1); // Force a collision with a small capacity
            hashtable.Set("one", 1);
            hashtable.Set("neo", 42); // Collides with "one"

            var keys = hashtable.Keys();
            var bucketIndex = hashtable.Hash("one");

            Assert.Equal(2, keys.Count());
            Assert.Contains("one", keys);
            Assert.Contains("neo", keys);
            Assert.Equal(1, hashtable.Get("one"));
            Assert.Equal(42, hashtable.Get("neo"));
            Assert.Equal(bucketIndex, hashtable.Hash("neo")); // Should be the same bucket
        }
    }
}