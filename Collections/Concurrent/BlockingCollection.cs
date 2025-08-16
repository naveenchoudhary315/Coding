using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Concurrent
{
    internal class BlockingCollection
    {
        // Provides producer-consumer pattern.
        // Can wrap around other concurrent collections.
        // Supports bounded capacity and blocking Take() when empty.


        private BlockingCollection() 
        {
            var blockingCollection = new BlockingCollection<int>();

            // Producer
            Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    blockingCollection.Add(i);
                    Console.WriteLine($"Produced {i}");
                }
                blockingCollection.CompleteAdding();
            });

            // Consumer
            Task.Run(() =>
            {
                foreach (var item in blockingCollection.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed {item}");
                }
            }).Wait();
        }
    }
}
