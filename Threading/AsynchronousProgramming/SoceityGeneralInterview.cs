using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.AsynchronousProgramming
{
    // Output without async await
    class OutputWithoutAsyncAwait
    {
        // Print met3
        // Print met2
        // Print met1 
        public void MainSocietyGeneral()
        {
            met1();

        }

        public void met1()
        {
            met2();
            Console.WriteLine("Print met1");
        }
        public void met2()
        {
            met3();
            Console.WriteLine("Print met2");
        }
        public void met3()
        {
            Console.WriteLine("Print met3");
        }
    }


    class SoceityGeneralInterviewScenario2
    {
        // Print met3
        // Print met2
        // Print met1 
        public async Task MainSocietyGeneral()
        {
            met1();    // Now met1() begins execution immediately on the current thread.
            Console.WriteLine("MainSocietyGeneral");
        }

        public async Task met1()
        {
            await Task.Delay(1000);
            await met2();
            Console.WriteLine("Print met1");
        }

        public async Task met2()
        {
            await Task.Delay(1000);
            await met3();
            Console.WriteLine("Print met2");
        }

        public async Task met3()
        {
            await Task.Delay(1000);
            Console.WriteLine("Print met3");
        }
    }
}