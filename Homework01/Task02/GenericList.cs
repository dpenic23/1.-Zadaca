using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02 {
    class GenericList<T> : IGenericList<T> {

        private T[] _internalStorage;
        public int Count { get; private set; }

        public GenericList() : this(4) {
        }

        public GenericList(int initialSize) {
            if (initialSize < 0) {
                throw new ArgumentOutOfRangeException("Initial size has to " +
                    "be nonnegative number: " + initialSize);
            }

            _internalStorage = new T[initialSize];
            Count = 0;
        }

        public void Add(T item) {
            if (Count == _internalStorage.Length) {
                resize();
            }

            _internalStorage[Count] = item;
            Count++;
        }

        private void resize() {
            T[] tmpStorage = new T[2 * Count];
            for (int index = 0; index < _internalStorage.Length; index++) {
                tmpStorage[index] = _internalStorage[index];
            }
            _internalStorage = tmpStorage;
        }

        public bool Remove(T item) {
            int itemIndex = IndexOf(item);
            return RemoveAt(itemIndex);
        }

        public bool RemoveAt(int index) {
            if (index < 0 || index >= Count) {
                return false;
            }

            for (int position = index; position < Count - 1; position++) {
                _internalStorage[position] = _internalStorage[position + 1];
            }

            Count--;
            return true;
        }

        public T GetElement(int index) {
            if (index < 0 || index >= Count) {
                throw new IndexOutOfRangeException("Index has to be from interval: [" +
                    0 + ", " + Count + ">");
            }

            return _internalStorage[index];
        }

        public int IndexOf(T item) {
            for (int index = 0; index < Count; index++) {
                if (_internalStorage[index].Equals(item)) {
                    return index;
                }
            }

            return -1;
        }

        public void Clear() {
            Count = 0;
        }

        public bool Contains(T item) {
            return IndexOf(item) != -1;
        }

    }
}
