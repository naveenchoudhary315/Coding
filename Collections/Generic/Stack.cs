using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    internal class Stack
    {
        //Stack<T> → LIFO (Last In, First Out)
        public void StackTest() 
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            Console.WriteLine("\nStack<T> Example:");
            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());

        }
    }
}
