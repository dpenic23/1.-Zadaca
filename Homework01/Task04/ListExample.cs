using GenericList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04 {

    /// <summary>
    /// Command line application which presents usage of GenericList
    /// collection. Application shows using collection in foreach loop.
    /// </summary>
    public class ListExample {
        static void Main(string[] args) {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");

            foreach(string value in stringList) {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
