using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays.BruteForce
{
    public class PairSum
    {
        //Time Complexity O(n^2) and Space Complexity O(n) 
        public Dictionary<int, int> FindPairSum_BruteForceApproach(int target)
        {
            int[] nums = [2, 7, 5, 15, 4];
            Dictionary<int, int> keyValuePairs = new();


            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        keyValuePairs.Add(nums[i], nums[j]);
                    }
                }
            }
            return keyValuePairs;
        }

        // TwoPointerApproach
        // https://www.youtube.com/watch?v=_xqIp2rj8bo&t=882s
        public Dictionary<int, int> FindPairSum_TwoPointerApproach()
        {
            int[] nums = [2, 7, 5, 15, 4];

            Array.Sort(nums); // 2,4,5,7,15 
            int target = 9;
            Dictionary<int, int> keyValuePairs = new();
            int i = 0, j = nums.Length - 1;

            while (i < j)
            {
                int pairSum = nums[i] + nums[j];
                if (pairSum == target)
                {
                    keyValuePairs.Add(nums[i], nums[j]);
                    i++;
                    j--;
                }

                if (pairSum < target)
                {
                    i++;
                }
                if (pairSum > target)
                {
                    j--;
                }
            }
            return keyValuePairs;
        }

    }
}
