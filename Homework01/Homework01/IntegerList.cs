using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01 {
    public class IntegerList : IIntegerList {

        private int[] _internalStorage;
        public int Count { get; private set; }

        public IntegerList() : this(4) {
        }

        public IntegerList(int initialSize) {
            if (initialSize < 0) {
                throw new ArgumentOutOfRangeException("Initial size has to " +
                    "be nonnegative number: " + initialSize);
            }

            _internalStorage = new int[initialSize];
            Count = 0;
        }

        public void Add(int item) {
            if (Count == _internalStorage.Length) {
                resize();
            }

            _internalStorage[Count] = item;
            Count++;
        }

        private void resize() {
            int[] tmpStorage = new int[2 * Count];
            for (int index = 0; index < _internalStorage.Length; index++) {
                tmpStorage[index] = _internalStorage[index];
            }
            _internalStorage = tmpStorage;
        }

        public bool Remove(int item) {
            int itemIndex = IndexOf(item);
            return RemoveAt(itemIndex);
        }

        public bool RemoveAt(int index) {
            if (index < 0 || index >= Count) {
                return false;
            }

            for(int position = index; position < Count - 1; position++) {
                _internalStorage[position] = _internalStorage[position + 1];
            }

            Count--;
            return true;
        }

        public int GetElement(int index) {
            if(index < 0 || index >= Count) {
                throw new IndexOutOfRangeException("Index has to be from interval: [" +
                    0 + ", " + Count + ">");
            }

            return _internalStorage[index];
        }

        public int IndexOf(int item) {
            for (int index = 0; index < Count; index++) {
                if (_internalStorage[index] == item) {
                    return index;
                }
            }

            return -1;
        }

        public void Clear() {
            Count = 0;
        }

        public bool Contains(int item) {
            return IndexOf(item) != -1;
        }

    }
}
