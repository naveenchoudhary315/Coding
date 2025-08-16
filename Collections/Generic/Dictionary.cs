using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    internal class Dictionary
    {
        public void DictionaryTest() 
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees[101] = "Alice";
            employees[102] = "Bob";

            Console.WriteLine("\nDictionary<TKey, TValue> Example:");
            foreach (var kv in employees)
                Console.WriteLine($"ID: {kv.Key}, Name: {kv.Value}");

        }
    }
}
