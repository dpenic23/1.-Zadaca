using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01 {

    /// <summary>
    /// Command line application which presents usage of IntegerList
    /// collection. Integers are being added and removed from the
    /// collection.
    /// </summary>
    public class ListExample {

        /// <summary>
        /// Method called once program is run.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args) {
            IntegerList listOfIntegers = new IntegerList();

            listOfIntegers.Add(1);
            listOfIntegers.Add(2);
            listOfIntegers.Add(3);
            listOfIntegers.Add(4);
            listOfIntegers.Add(5);
            // List is [1, 2, 3, 4, 5]

            // Removing first element
            listOfIntegers.RemoveAt(0);
            // List is [2, 3, 4, 5]

            // Removing element with value equal to "5".
            listOfIntegers.Remove(5);
            // List is [2, 3, 4]

            Console.WriteLine(listOfIntegers.Count);
            // 3

            Console.WriteLine(listOfIntegers.Remove(100));
            // false, collection does not contain specified item

            Console.WriteLine(listOfIntegers.RemoveAt(5));
            // false, there is nothing on position 5

            Console.WriteLine(listOfIntegers.Contains(2));
            // true

            // Deleting all elements from the collection
            listOfIntegers.Clear();

            Console.WriteLine(listOfIntegers.Count);
            // 0

            Console.ReadLine();
        }
    }
}