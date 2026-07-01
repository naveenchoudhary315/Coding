using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Interview_4
{
    class WiproRound2Main
    {
        public void MainMethodCall(string[] args)
        {
            WiproRound2 wiproRound2 = new WiproRound2();
            Console.WriteLine("Hello, World!");

            wiproRound2.Method1();
            Console.WriteLine("Next Hello, World!");

            Console.ReadLine();

        }
    }

    internal class WiproRound2
    {
        public async Task Method1()
        {
            Console.WriteLine("Method1!!");

            await Method2();

            Console.WriteLine("Next Method1");
        }

        public async Task Method2()
        {
            Console.WriteLine("Method2!!");

            await Task.Delay(2000);

            Console.WriteLine("Next Method2");
        }
    }

}
