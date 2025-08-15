using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.TPL
{
    internal class CancelllationToken
    {
        public static void  CancelllationTokenTest() 
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine($"Working {i}");
                    Task.Delay(500).Wait();
                }
            }, token);

            cts.CancelAfter(2000); // Cancel after 2 seconds

            try
            {
                t.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Task cancelled");
            }

        }
    }
}
