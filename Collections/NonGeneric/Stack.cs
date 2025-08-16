using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGeneric
{
    internal class StackExample
    {
        Stack stack = new  Stack();
        //FIFO (First In, First Out).
        public void StackTest()
        {
            Stack s = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            Console.WriteLine("\nStack Example:");
            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());


        }
    }
}
