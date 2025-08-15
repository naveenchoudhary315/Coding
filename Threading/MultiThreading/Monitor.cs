using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.MultiThreading
{
    using System;
    using System.Threading;

    using System;
    using System.Threading;

    class MonitorExample
    {
        private static readonly object lockObject = new object();
        private static int counter = 0;

        public static void Sample()
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread t = new Thread(IncrementCounter);
                t.Name = $"Thread {i}";
                t.Start();
            }
        }

          static void IncrementCounter()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is waiting...");

            Monitor.Enter(lockObject); // Acquire lock
            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} entered critical section.");

                for (int i = 0; i < 3; i++)
                {
                    counter++;
                    Console.WriteLine($"{Thread.CurrentThread.Name} counter = {counter}");
                    Thread.Sleep(500);
                }

                Console.WriteLine($"{Thread.CurrentThread.Name} exiting critical section.");
            }
            finally
            {
                Monitor.Exit(lockObject); // Always release in finally
            }
        }
    }


}
