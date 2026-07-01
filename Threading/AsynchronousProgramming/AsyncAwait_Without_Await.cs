using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyncawait_And_Task_Usage
{
    //    Task 1 started.
    //Task 1 completed.
    //Task 2 started.
    //Task 2 completed.
    //Task 3 started.
    //Task 3 completed.
    //All tasks initiated.
    public class AsyncAwait_Without_Await
    {
        public void CallAsyncAwait()
        {
            Task1();
            Task2();
            Task3();
            Console.WriteLine("All tasks initiated.");
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1 started.");
            Thread.Sleep(1000); // Simulate work
            Console.WriteLine("Task 1 completed.");
        }
        public static void Task2()
        {
            Console.WriteLine("Task 2 started.");
            Thread.Sleep(1000); // Simulate work
            Console.WriteLine("Task 2 completed.");
        }
        public static void Task3()
        {
            Console.WriteLine("Task 3 started.");
            Thread.Sleep(500); // Simulate work
            Console.WriteLine("Task 3 completed.");
        }
    }


    public class AsyncAwait_With_Await
    {
        public async Task AsyncAwait_With_Await_Method()
        {
            await Task1();
            await Task2();
            await Task3();
            Console.WriteLine("All tasks initiated.");
        }

        //With Whenall.
        public async Task AsyncAwait_With_Await_Method_WithWaitAll()
        {
            await Task1();
            Task t1 = Task2();
            Task t2 = Task3();
            await Task.WhenAll(t1, t2);
            Console.WriteLine("All tasks initiated.");
        }

        public async Task Task1()
        {
            Console.WriteLine("Task 1 started.");
            await Task.Delay(1000);
            Console.WriteLine("Task 1 completed.");
        }
        public async Task Task2()
        {
            Console.WriteLine("Task 2 started.");
            await Task.Delay(1000);// Simulate work
            Console.WriteLine("Task 2 completed.");
        }
        public async static Task Task3()
        {
            Console.WriteLine("Task 3 started.");
            await Task.Delay(1000);
            Console.WriteLine("Task 3 completed.");
        }
    }


}
