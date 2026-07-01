using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var service1Result = await CallService1Async();
//var service2Result = await CallService2Async();
//var service3Result = await CallService3Async();

//1.

//    var service1Result = CallService1Async();  
//var service2Result = await CallService2Async();
//var service3Result = await CallService3Async();

//What is other than var we can use to hold return data?

namespace Threading.AsynchronousProgramming
{
    internal class Public_Sapient
    {
        public async Task TestScenario()
        {
            await CallService1Async();   //So Service1 runs in background while other code continues.
            await CallService2Async();
            await CallService3Async();
        }


        private async Task<int> CallService1Async()
        {
            int j = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                j = i * 100 - 20;
                // Thread.Sleep(1);

            }
            await Task.Delay(2500);
            Console.WriteLine("Service1");
            return j;

        }
        private async Task<int> CallService2Async()
        {
            int j = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    j++; //Thread.Sleep(100);
            //}
            Console.WriteLine("Service2");
            return j;
        }
        private async Task<int> CallService3Async()
        {
            int j = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    j++;
            //    Thread.Sleep(1);
            //}
            Console.WriteLine("Service3");
            return j;
        }



    }
}
