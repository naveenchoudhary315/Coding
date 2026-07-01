using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal class SocietyGeneral2
    {
        public string FindLongestSubstring(string str = "NaveenChoudhary")
        {
            Dictionary<char, int> map = new Dictionary<char, int>();  // Dictionary to store all chars.

            int reStart = 0;  // Rest start on each duplicate case. 
            int maxLength = 0; //longest substring 
            int maxStart = 0;

            for (int current = 0; current < str.Length; current++)
            {
                char currentChar = str[current];

                // Duplicate found inside current window
                if (map.ContainsKey(currentChar) && map[currentChar] >= reStart)
                {
                    reStart = map[currentChar] + 1;  // if duplicate found, move the start to the right of the previous index of the duplicate character.
                }

                map[currentChar] = current;

                int currentLength = current - reStart + 1; // Checks the length of the current substring without duplicates.

                // Store longest substring info
                if (currentLength > maxLength)  //Compare the current length with the maximum length found so far. If it's greater, update the maximum length and the starting index of the longest substring.
                {
                    maxLength = currentLength;
                    maxStart = reStart;
                }
            }
            var substring = str.Substring(maxStart, maxLength);
            return substring;


        }
    }
}
