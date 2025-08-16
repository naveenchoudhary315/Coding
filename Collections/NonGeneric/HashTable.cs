using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGeneric
{
    internal class HashTable
    {
        //Key-value pairs (like Dictionary<TKey, TValue>).  
        public HashTable() 
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add("Three", 3);

            Console.WriteLine("\nHashtable Example:");
            foreach (DictionaryEntry entry in ht)
                Console.WriteLine($"{entry.Key} : {entry.Value}");

        }
    }
}
