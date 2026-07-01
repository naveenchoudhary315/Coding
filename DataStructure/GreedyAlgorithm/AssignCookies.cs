using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.GreedyAlgorithm
{
    internal class AssignCookies
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">Greed factor of each child.
        /// Total child = g.Length </param>  
        /// <param name="s">Cooies | Each represent its size.</param>
        /// <returns></returns>
        public int FindContentChildren(int[] greed, int[] cookieSize)
        {

            Array.Sort(greed); // 1,2,3 
            Array.Sort(cookieSize); // 1,1
            int result = 0;

            int child = 0, cookie = 0;


            // Use 2 pointer solution.
            while (child < greed.Length && cookie < cookieSize.Length)
            {
                if (greed[child] <= cookieSize[cookie])
                {
                    child++; // Take next chile.
                    result++;
                }
                cookie++; // if current cookie is not enough for current child, then we can try next cookie.

            }

            return -1;

        }

    }
}
