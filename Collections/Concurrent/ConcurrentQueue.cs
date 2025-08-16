using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Concurrent
{ 
    //Thread-safe version of Dictionary<TKey, TValue>.
    internal class ConcurrentQueue
    {
        public void ConcurrentQueueTest() 
        {
            var queue = new ConcurrentQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);

            if (queue.TryDequeue(out int result))
                Console.WriteLine($"Dequeued: {result}");

        }
    }
}
