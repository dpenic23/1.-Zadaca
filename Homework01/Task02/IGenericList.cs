using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02 {

    interface IGenericList<T> {

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">Item to be added to the collection.</param>
        void Add(T item);

        /// <summary>
        /// Removes the first occurrence of an item from the collection.
        /// If the item was not found, method does nothing. 
        /// </summary>
        /// <param name="item">Item to be removed from the collection.</param>
        /// <returns>
        /// <code>True</code> if specified item is successfully removed, 
        /// <code>false</code> otherwise.
        /// </returns>
        bool Remove(T item);

        /// <summary>
        /// Removes the item at the given index in the collection.
        /// </summary>
        /// <param name="index">Index of an item to be removed.</param>
        /// <returns>
        /// <code>False</code> if index is out of range,
        /// <code>true</code> otherwise.
        /// </returns>
        bool RemoveAt(int index);

        /// <summary>
        /// Returns the item at the given index in the collection.
        /// </summary>
        /// <param name="index">Index of an item to be returned.</param>
        /// <returns>Item in the collection at the specified index.</returns>
        T GetElement(int index);

        /// <summary>
        /// Returns the index of the item in the collection.
        /// If item is not found in the collection, method returns -1.
        /// </summary>
        /// <param name="item">Item to be searched for in the collection.</param>
        /// <returns>
        /// Index of specified item in the collection,
        /// -1 if item is not found in the collection.
        /// </returns>
        int IndexOf(T item);

        /// <summary>
        /// Readonly property. Gets the number of items contained in the collection.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Removes all the items from the collection.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines wheter the collection contains a specific value.
        /// </summary>
        /// <param name="item">Item to be searched for in the collection.</param>
        /// <returns>
        /// <code>True</code> if collection contains specified item,
        /// <code>false</code> otherwise.
        /// </returns>
        bool Contains(T item);
    }
}
