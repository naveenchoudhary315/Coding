using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.String
{
    internal class LongestCommonPrefix
    {
        //Input: strs = ["flower", "flow", "flight"]
        //Output: "fl"

        //Logic : 
        // 1st iteration : prefix = "flower", compare with "flow" => prefix = "flow"
        // 2nd iteration : prefix = "flow", compare with "flight" => prefix = "fl"
        public string FindLongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))  // We weill remove 1 char from end.
                                                     // unitl currentPrefix is matching with current string.
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix == "")
                        return "";
                }
            }

            return prefix;
        }
    }
}
