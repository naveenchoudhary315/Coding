using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interviews
{
    internal class Deloitte2
    {
        //standard backtracking prints all 8 valid combinations: [1,2,8], [1,3,7], [1,4,6], [2,3,6], [2,9], [3,8], [4,7].
        public void CalculateCombinations()
        {
            var nums = new[] { 1, 2, 3, 4, 6, 7, 8, 9 };
            int target = 11;
            var results = new List<List<int>>();

            // 2. Find Pairs (2 numbers)
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        results.Add(new List<int> { nums[i], nums[j] });
                    }
                }
            }
        }
    }
}

