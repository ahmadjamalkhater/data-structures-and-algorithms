using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables_CC30
{
    public class Hashtable<TKey, TValue>
    {
        private const int DefaultCapacity = 16;
        private List<HashNode<TKey, TValue>>[] buckets;

        public Hashtable() : this(DefaultCapacity) { }

        public Hashtable(int capacity)
        {
            this.buckets = new List<HashNode<TKey, TValue>>[capacity];
        }

        public void Set(TKey key, TValue value)
        {
            int index = Hash(key);
            if (buckets[index] == null)
            {
                buckets[index] = new List<HashNode<TKey, TValue>>();
            }

            bool keyExists = false;
            foreach (var node in buckets[index])
            {
                if (EqualityComparer<TKey>.Default.Equals(node.Key, key))
                {
                    node.Value = value;
                    keyExists = true;
                    break;
                }
            }

            if (!keyExists)
            {
                buckets[index].Add(new HashNode<TKey, TValue>(key, value));
            }
        }

        public TValue Get(TKey key)
        {
            int index = Hash(key);
            if (buckets[index] != null)
            {
                foreach (var node in buckets[index])
                {
                    if (EqualityComparer<TKey>.Default.Equals(node.Key, key))
                    {
                        return node.Value;
                    }
                }
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the Hashtable");
        }

        public bool Has(TKey key)
        {
            int index = Hash(key);
            if (buckets[index] != null)
            {
                foreach (var node in buckets[index])
                {
                    if (EqualityComparer<TKey>.Default.Equals(node.Key, key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public ICollection<TKey> Keys()
        {
            List<TKey> keys = new List<TKey>();
            foreach (var bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (var node in bucket)
                    {
                        keys.Add(node.Key);
                    }
                }
            }

            return keys.Distinct().ToList();
        }

        public int Hash(TKey key)
        {
            int hashCode = key.GetHashCode();
            return Math.Abs(hashCode) % buckets.Length;
        }
    }

    public class HashNode<TKey, TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; set; }

        public HashNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
