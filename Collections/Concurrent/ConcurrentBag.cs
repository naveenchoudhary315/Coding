using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Concurrent
{
    internal class ConcurrentBag
    {
        //  Thread-safe, unordered collection.
        //  Good when order doesn’t matter.

        private void ConcurrentBagTest()
        {
            var bag = new ConcurrentBag<int>();

            bag.Add(1);
            bag.Add(2);

            if (bag.TryTake(out int value))
                Console.WriteLine($"Removed: {value}");

        }
    }
}
