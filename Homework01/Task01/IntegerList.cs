using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01 {

    /// <summary>
    /// Collection of integers which can be compared with list. Elements
    /// can be added and removed and user can check if collection contains
    /// certain element. Adding and retrieving is executed in constant time,
    /// searching and removing is linear in time.
    /// </summary>
    public class IntegerList : IIntegerList {

        /// <summary>
        /// Default array capacity if user did not specify
        /// initial size of array.
        /// </summary>
        private const int DefaultSize = 4;

        /// <summary>
        /// Resize factor used when size of this collection
        /// has to be increased.
        /// </summary>
        private const int ResizeFactor = 2;

        /// <summary>
        /// Array of integer elements which holds actual data.
        /// Data count can be less then array lenght.
        /// </summary>
        private int[] _internalStorage;

        /// <summary>
        /// Number of elements stored in this collection.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Default constructor. Creates new IntegerList collection
        /// with default size.
        /// </summary>
        public IntegerList() : this(DefaultSize) {
        }

        /// <summary>
        /// Creates new IntegerList with initial size specified as
        /// only argument. Initial size has to be nonnegative number,
        /// appropriate exception will be thrown otherwise.
        /// </summary>
        /// <param name="initialSize">Initial collection size.</param>
        public IntegerList(int initialSize) {
            if (initialSize < 0) {
                throw new ArgumentOutOfRangeException("Initial size has to " +
                    "be nonnegative number: " + initialSize);
            }

            _internalStorage = new int[initialSize];
            Count = 0;
        }

        public void Add(int item) {
            // Check if collection has to be resized.
            if (Count == _internalStorage.Length) {
                resize();
            }

            _internalStorage[Count] = item;
            Count++;
        }

        /// <summary>
        /// Resizes this collection by the specified resize factor.
        /// Complexity of this method is linear in number of elements
        /// currently stored in this collection.
        /// </summary>
        private void resize() {
            // Create new array with new size.
            int[] tmpStorage = new int[ResizeFactor * Count];

            // Transfer all elements to the new array.
            for (int index = 0; index < _internalStorage.Length; index++) {
                tmpStorage[index] = _internalStorage[index];
            }

            _internalStorage = tmpStorage;
        }

        public bool Remove(int item) {
            // Find first occurrence of an item and remove it.
            int itemIndex = IndexOf(item);
            return RemoveAt(itemIndex);
        }

        public bool RemoveAt(int index) {
            // Check if index is out of bounds.
            if (index < 0 || index >= Count) {
                return false;
            }

            // Remove element by moving all elements behind it by one
            // position to the left
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
