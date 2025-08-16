using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    internal class Queue
    {
        // Queue<T> → FIFO (First In, First Out)
        public void QueueTest() 
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("\nQueue<T> Example:");
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

        }
    }
}
