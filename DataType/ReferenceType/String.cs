using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.ReferenceType
{
    internal class String
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            string @string= null;
            foreach (char c in charArray)
            {
                @string += c;
            }
            return new string(charArray);
        }

        public string isPalindromeString(string input)
        {
            string reversed = ReverseString(input);
            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                return $"{input} is a palindrome.";
            }
            else
            {
                return $"{input} is not a palindrome.";
            }
        }   

        public string CountVowelsAndConsonants(string input)
        {
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (char c in input.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantsCount++;
                    }
                }
            }
            return $"Vowels: {vowelsCount}, Consonants: {consonantsCount}";
        }

        public string IsPalidromeNumber(int input)
        {
            bool isPalindrome = true;
            int originalNumber = input;
            int reversedNumber = 0;
            while (input > 0)
            {
                int digit = input % 10;
                reversedNumber = reversedNumber * 10 + digit;
                input /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                return $"{originalNumber} is a palindrome number.";
            }
            else
            {
                return $"{originalNumber} is not a palindrome number.";
            }   
        }

        public string CountCharactersOccurences(string input)
        {
               input = "qqqwwwqw";
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
            int currentchar = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == currentchar)
                { 
                  
                }
                else
                {

                }
            }
            return input ;
        }

    }
}
