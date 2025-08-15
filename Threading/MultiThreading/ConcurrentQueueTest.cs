using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.MultiThreading
{
    internal class ConcurrentQueueTest
    {
        static ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

       public static void Methd()
        {
            // Producer: enqueue numbers
            Task producer = Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    queue.Enqueue(i);
                    Console.WriteLine($"Enqueued: {i}");
                    Thread.Sleep(100); // Simulate work
                }
            });

            // Consumer: dequeue numbers
            Task consumer = Task.Run(() =>
            {
                while (true)
                {
                    if (queue.TryDequeue(out int item))
                    {
                        Console.WriteLine($"\tDequeued: {item}");
                    }
                    else
                    {
                        // Stop when producer is done and queue is empty
                        if (producer.IsCompleted)
                            break;

                    }
                }
            });
        }
    }
}
