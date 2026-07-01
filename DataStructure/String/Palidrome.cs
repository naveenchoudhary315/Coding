using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.String
{
    internal class Palidrome
    {
        public bool FindValidPalidrome(string input)
        {
            input = "A man, a plan, a canal: Panama";
            int left = 0, right = input.Length - 1;

            while (left < right)
            {
                // Handle special characters.

                while ((left < right) && (!char.IsLetterOrDigit(input[left])))
                    left++;

                while ((left < right) && (!char.IsLetterOrDigit(input[right])))
                    right--;


                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }
                left++; right--;
            }
            return true;

        }
    }
}
