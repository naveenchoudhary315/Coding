using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NETFeatures
{
    internal class ProblemWithoutYield
    {
        // Without yield, you usually create a list and return it:
        //  Problem:  Stores all data in memory first
        // Returns after full execution

        public List<int> GetNumbers()
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                nums.Add(i);
            }
            return nums;
        }
    }

    internal class SolutionWithYield
    {
        public IEnumerable<int> GetNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                yield return i + i * 100;
            }
        }
    }
}
