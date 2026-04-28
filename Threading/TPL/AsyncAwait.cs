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
    }
}
