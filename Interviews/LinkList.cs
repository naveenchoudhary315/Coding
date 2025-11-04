using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class Node
    { 
        public int data;
        public Node next;

        public Node(int data)
        {
            data = data;
            next = null;
        }
    }
    internal class LinkList
    {
        Node Node;

        public int GetNthElement(int index)
        { 
           Node current = Node;
            int count = 0;
            while (current is not null)
            {
                if (count == index)
                {
                    return current.data;
                }

                count++;
                current = current.next;

            }
            return -1;
        }
    }
}
