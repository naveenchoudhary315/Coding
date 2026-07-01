using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.String
{
    internal class ValidAnagram
    {
        //An anagram means both strings contain the same characters with the same frequencies, just in a different order.
        public bool IsAnagram(string s, string t)
        {
            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            return new string(sArray) == new string(tArray);


        }
    }
}
