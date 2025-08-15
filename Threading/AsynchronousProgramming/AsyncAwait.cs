using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.AsynchronousProgramming
{
    internal class AsyncAwait
    {
        public static async Task API_with_HttpClient()
        {
            using var client = new HttpClient();

            Console.WriteLine("Fetching data...");
            try
            {

                var data = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
            }
            catch (Exception ex)
            {

                throw ex;
            }

            // Console.WriteLine($"Data length: {data.Length}");
        }



        public static async Task Multiple_Operations()
        {
            var client = new HttpClient();
            Task<string> t1 = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
            Task<string> t2 = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/2");

            string[] results = await Task.WhenAll(t1, t2);

            Console.WriteLine($"Post1: {results[0].Length} chars");
            Console.WriteLine($"Post2: {results[1].Length} chars");
        }

        public static async Task CPU_Bound_Work()
        {
            Console.WriteLine("Starting calculation...");
            int result = await Task.Run(() => HeavyCalculation());
            Console.WriteLine($"Result: {result}");
        }

        static int HeavyCalculation()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
                sum += i;
            Thread.Sleep(2000); // Simulate long-running task
            return sum;
        }


        public static void MultiMethodsTest()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            var task2 = TeachClass12();
            var task3 = TeachClass11();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds}ms");


        }

        public static async void MultiMethods_WithoutAsync()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            await task1;
            var task2 = TeachClass12();
            var task3 = TeachClass11();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time:  {watch.ElapsedMilliseconds}  ms");
        }



        #region Helpers
        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }


        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12");
            });


        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 11");
            });


        }
        #endregion

    }

    class Test2
    {
        public static async Task Test2Case()
        {
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess2();

            //do something here
            Console.WriteLine("After two long processes.");

            int val = await result1; // wait untile get the return value
            DisplayResult(val);

            val = await result2; // wait untile get the return value
            DisplayResult(val);

            Console.ReadKey();
        }

        static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess 1 Started");

            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess 1 Completed");

            return 10;
        }

        static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess 2 Started");

            await Task.Delay(8000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess 2 Completed");

            return 20;
        }

        static void DisplayResult(int val)
        {
            Console.WriteLine(val);
        }
    }

}
