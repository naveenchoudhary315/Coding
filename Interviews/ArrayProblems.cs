using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class ArrayProblems
    {
        public static int[] Merge2Arrays()
        {
            int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] n2 = new int[] { 4, 5, 6 };
            for (int i = 0; i < n1.Length; i++) 
            {
                if (n1[i] == 0)
                { 
                for (int j = 0; j < n2.Length; j++,i++) 
                    {
                        n1[i] = n2[j];
                    }
                }
            }
            return n1;
        
        }

        public static int[] FindMissingAndRepeatedValue()
        {


            return null;
        }
    
    }
}
