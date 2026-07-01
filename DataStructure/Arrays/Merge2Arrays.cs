using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    internal class Merge2ArraysProblem
    {
        public void Merge2ArraysUsingBruteForce()
        {
            int[] n1 = { 1, 2, 3, 0, 0, 0 };
            int[] n2 = { 4, 5, 6 };

            for (int i = 0; i < n1.Length; i++)
            {
                if (n1[i] == 0)
                {
                    for (int j = 0; j <= n2.Length - 1; j++, i++)
                    {
                        n1[i] = n2[j];
                    }
                }
            }
        }

        //        Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
        public void Merge_Using2PointerProblem(int[] nums1, int m, int[] nums2, int n)
        {
            nums1 = [1, 2, 3, 0, 0, 0]; m = 3; nums2 = [2, 5, 6]; n = 3;

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

        }

    }
}
