using Assets.Scripts.Api;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Monika
{
    sealed class NamedSpriteCollection<T> : ICollection<T> where T : INamedSprite
    {
        private Dictionary<string, T> _dict = new Dictionary<string, T>();

        public T this[string key]
        {
            get
            {
                return _dict[key];
            }
        }

        public int Count
        {
            get
            {
                return _dict.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            _dict[item.Name] = item;
        }

        public void Clear()
        {
            _dict.Clear();
        }

        public bool Contains(T item)
        {
            return _dict.ContainsKey(item.Name);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _dict.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _dict.Values.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return _dict.Remove(item.Name);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dict.Values.GetEnumerator();
        }
    }
}
