using System;

namespace Replace_Inheritance_with_Delegation
{
    public class Before
    {
    }

    // کلاس والد
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

    // ❌ زیرکلاس فقط می‌خواد یه Cache ساده باشه
    // ولی کلی متد اضافی از والد به ارث برده
    public class Cache<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public TValue GetOrAdd(TKey key, Func<TValue> factory)
        {
            if (!Contains(key))
                Add(key, factory());
            return Get(key);
        }

        // ولی Clear هم در دسترسه! نباید باشه
        // Count هم هست
        // میتونن اشتباهی Clear کنن و کل Cache رو پاک کنن!
    }
}
