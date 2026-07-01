using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class curatal
    {
        public static void CallGreatestLetter()
        {
            char[] letters = { 'c', 'f', 'j' };
            char target = 'c';
            var result = NextGreatestLetter(letters, target);
            Console.WriteLine(result); // Output: 'c'
        }




        static char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (letters[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }

            // If no greater character found, return first character
            return left < letters.Length ? letters[left] : letters[0];
        }

    }

}
