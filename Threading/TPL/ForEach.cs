using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.TPL
{
    internal class Fork
    {
        public void Test()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
            });
        }
    }
}
