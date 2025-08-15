using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.MultiThreading
{
    using System;
    using System.Threading;

    class SemaphoreExample
    {
        // Allow maximum 2 threads in the critical section at the same time
        static Semaphore semaphore = new Semaphore(2, 2);

        public static void SampleTest(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread t = new Thread(DoWork);
                t.Name = $"Thread {i}";
                t.Start();
            }
        }

        private static void DoWork()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is waiting to enter...");

            // Wait until it's safe to enter
            semaphore.WaitOne();

            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has entered the critical section.");
                Thread.Sleep(2000); // Simulate some work
                Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the critical section.");
            }
            finally
            {
                // Release semaphore slot
                semaphore.Release();
            }
        }
    }

}
