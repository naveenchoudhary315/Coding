using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public static class Deloitte
    {
        public static void FindCommonElements(int[] arr1, int target = 11)
        {
            var result = new List<List<int>>();
            int[] nums = { 1, 2, 3, 4, 6, 7, 8, 9 };
            Array.Sort(nums);


            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    result.Add(new List<int> { nums[left], nums[right] });
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            //return result;

        }

    }
}
