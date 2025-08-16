using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Concurrent
{
    //Thread-safe version of Dictionary<TKey, TValue>.
    internal class ConcurrentDictionary
    {
        private void  ConcurrentDictionaryTest()
        {
            var dict = new ConcurrentDictionary<int, string>();

            dict.TryAdd(1, "Alice");
            dict.TryAdd(2, "Bob");

            dict[2] = "Robert"; // update safely

            Console.WriteLine("ConcurrentDictionary Example:");
            foreach (var kv in dict)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }
    }
}
