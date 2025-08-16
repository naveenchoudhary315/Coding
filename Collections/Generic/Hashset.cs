using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Collections.Generic
{
    internal class Hashset
    {
       // HashSet<T> → Stores only unique items
        public Hashset() 
        {
            HashSet<int> numbers = new HashSet<int> { 1, 2, 2, 3, 4 };

            Console.WriteLine("\nHashSet<T> Example:");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
