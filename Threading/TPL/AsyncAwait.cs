using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.TPL
{
   internal class AsyncAwait
    {
        public static async Task Main()
        {
            Console.WriteLine("Starting Main...");
            string result = await GetDataAsync();

            Console.WriteLine($"Result: {result}");
              result = await GetDataAsync();
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Main completed.");
        }
        private static async Task<string> GetDataAsync()
        {
            Console.WriteLine("Fetching data...");
            await Task.Delay(2000); // Simulate async work
            return "Data fetched successfully!";
        }

        //Run Multiple Tasks in Parallel
        public async Task<string> GetAllData()
        {
            var t1 = GetDataAsync();
            var t2 = GetDataAsync();
            var t3 = GetDataAsync();

            await Task.WhenAll(t1, t2, t3);

            return $"{t1.Result} {t2.Result} {t3.Result}";
        }


    }
}
