using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList {
    public class GenericListEnumerator<T> : IEnumerator<T> {

        private IGenericList<T> _collection;
        private int _currentIndex;

        public GenericListEnumerator(IGenericList<T> collection) {
            _collection = collection;
            _currentIndex = -1;
        }

        public bool MoveNext() {
            _currentIndex++;
            return _currentIndex < _collection.Count;
        }

        public T Current {
            get {
                return _collection.GetElement(_currentIndex);
            }
        }

        object IEnumerator.Current {
            get {
                return Current;
            }
        }

        public void Dispose() {
            // do nothing
        }

        public void Reset() {
            // do nothing
        }

    }
}
