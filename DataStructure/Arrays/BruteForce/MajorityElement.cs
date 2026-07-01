using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays.BruteForce
{
    //https://leetcode.com/problems/majority-element/description/
    public class MajorityElement
    {
        int[] nums = [2, 2, 1, 1, 1, 2, 2];
        public int FindMajorityElement()
        {
            int majorityElement = nums.Length / 2;
            int frequency = 0;

            // Brute force approach: Iterate through the array and count the frequency of each element. If the frequency of any element is greater than or equal to the majority element, return that element.
            for (int i = 0; i < nums.Length; i++)
            {
                var itemcount = nums.Count(x => x == nums[i]); // Check no. of times the element is repeated in the array

                if (itemcount >= majorityElement)  // If the count of the element is greater than or equal to the majority element, then return that element
                    return nums[i];
            }

            return -1;
        }

    }
}
