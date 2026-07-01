using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    internal class SingleNumberproblem
    {
        public void FindSingleNumber()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int CURRENT = nums[i];
                result = result ^ CURRENT;
            }

            Console.WriteLine(result);
        }


    }
}
