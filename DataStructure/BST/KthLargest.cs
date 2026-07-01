using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BST
{
    internal class KthLargest
    {
        int k = 0;  // no. of elements
        private readonly PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();



        public void FindKthLargest(int k, int[] nums)
        {
            k = 3;

            foreach (int num in nums)
            {
                Add(num);
            }

        }

        public int Add(int num)
        {
            minHeap.Enqueue(num, num);

            if (minHeap.Count == k)
            {
                minHeap.Dequeue();
            }

            return minHeap.Peek();

        }


    }
}
