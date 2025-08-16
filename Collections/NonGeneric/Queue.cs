using System;
using System.Collections;

namespace Collections.NonGeneric
{
    internal class QueueExample
    {
        Queue queue = new Queue();
        public void  QueueTest() 
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue("geeksforgeeks");
            queue.Enqueue(null);
            queue.Enqueue(1);
            queue.Enqueue(10.0);

            // Initial queue
            Console.WriteLine("Initial queue: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing the front element
            queue.Dequeue();
        }
    }
}
