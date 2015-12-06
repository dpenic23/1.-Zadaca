using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02 {
    class ListExample {
        static void Main(string[] args) {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");

            Console.WriteLine(stringList.Count); // 3
            Console.WriteLine(stringList.Contains("Hello")); // true
            Console.WriteLine(stringList.IndexOf("Hello")); // 0
            Console.WriteLine(stringList.GetElement(1)); // World

            IGenericList<double> doubleList = new GenericList<double>();
            doubleList.Add(0.2);
            doubleList.Add(0.7);

            Console.ReadLine();
        }
    }
}
