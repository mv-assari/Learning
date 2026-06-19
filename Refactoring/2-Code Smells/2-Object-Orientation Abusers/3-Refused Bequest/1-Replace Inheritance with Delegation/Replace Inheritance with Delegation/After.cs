using System;

namespace Replace_Inheritance_with_Delegation
{
    public class After
    {
    }


    public class Dictionary<TKey, TValue>
    {
        private List<(TKey, TValue)> _entries = new();

        public void Add(TKey key, TValue value)
        {
            _entries.Add((key, value));
        }

        public TValue Get(TKey key)
        {
            return _entries.First(e => e.Item1.Equals(key)).Item2;
        }

        public bool Contains(TKey key)
        {
            return _entries.Any(e => e.Item1.Equals(key));
        }

        public int Count => _entries.Count;

        public void Clear()
        {
            _entries.Clear();
        }
    }

    public class Cache<TKey, TValue> 
    {
        private Dictionary<TKey, TValue> _dictionary = new();
        public TValue GetOrAdd(TKey key, Func<TValue> factory)
        {
            if (!_dictionary.Contains(key))
                _dictionary.Add(key, factory());
            return _dictionary.Get(key);
        }
    }
}
