using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Concurrent
{
   // ConcurrentStack<T>(LIFO)
   // Thread-safe version of Stack<T>.
    internal class ConcurrentStack
    {
        public void ConcurrentStackTest() 
        {
            var stack = new ConcurrentStack<string>();

            stack.Push("First");
            stack.Push("Second");

            if (stack.TryPop(out string item))
                Console.WriteLine($"Popped: {item}");
        }
    }
}
