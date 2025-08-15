using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task Parallel Library (TPL) provides a set of APIs for parallel programming in .NET.
namespace Threading.TPL
{
  static  internal class For
    {
        public static void ForLoop() 
        {
           
            Parallel.For(1, 6, i =>
            {
                Console.WriteLine($"Processing {i} on Thread {Task.CurrentId}");
            });

        } 
    }
}
