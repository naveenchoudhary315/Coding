using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Interview_4
{
    internal class MobillComm
    {

        //https://leetcode.com/problems/3sum/description/
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var output = new List<List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            output.Add(new List<int> { nums[i], nums[j], nums[k] });
                        }
                    }
                }
            }
            return output.Cast<IList<int>>().ToList();
        }
    }
}
