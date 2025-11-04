using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal class StringProblems
    {
        /// <summary>
        /// string str= "My name is Naveen";
        /// </summary>
        /// <returns></returns>
        public static string ReverseString()
        {
            string str = "My name is Naveen";
            string[] input = str.Split(" ");
            string res = null;

            for (int i = input.Length - 1; i > 0; i--)
            {
                res += input[i] + " ";
            }

            return res;
        }

        public static int FindFactorial()
        {
            int num = 5;
            int res = 1;
            for (int i = num; i > 0; --i)
            {
                res *= i;
            }
            return res;
        }

        public static int FindFactorialByRecursion(int val)
        {
            if (val == 1)
                return val;
            //int num = 5;
            return val * FindFactorialByRecursion(val - 1);

        }

        public static void CreateFibonnaciSeries(int num = 9)
        {
            int a = 0, b = 1, c = 0;
            //Console.WriteLine(a + " ");
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }

        public static int CreateFibonnaciSeriesByRecursive(int num = 9)
        {
            if (num == 0) return 0; //To return the first Fibonacci number   
            if (num == 1) return 1; //To return the second Fibonacci number   
            return CreateFibonnaciSeriesByRecursive(num - 1) + CreateFibonnaciSeriesByRecursive(num - 2);
        }

        public static void FindNonRepetativeElement()
        {
            string input = "CAPITALISTIC",res=null;
            for (int i = 0; i <= input.Length-1; i++)
            {
                if (input.IndexOf(input[i]) == input.LastIndexOf(input[i]))
                {
                    res += input[i];
                }
            }

        }

        public static void FindLetterCount()
        {
            string input = "My name is king";
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (keyValuePairs.TryGetValue(input[i], out int val))
                {
                    keyValuePairs[input[i]] = ++val;
                }
                else
                {
                    keyValuePairs.Add(input[i], 1);
                }
            }

        }

        public static void IsPalidromeNo()
        {
            int input = 10016;
            int originalnum = input, result=0;
            
            while(input > 0) 
            {
                int reminder = input % 10;
                result = result * 10 + reminder;
                input /= 10;
            }
            if (originalnum == result)
            {
                Console.WriteLine("Palidrome");
            }
            else
            {
                Console.WriteLine("Not Palidrome");
            }
            
        }

        public static void IsPalidromeString()
        { 
            string input  = "MADAMw";
            string output = null;
            for (int i = input.Length-1; i >= 0; i--)
            {
                output += input[i];
            }


            if(input.Equals(output))
            {
                Console.WriteLine("Palidrome");
            }
            else
            {
                Console.WriteLine("Not Palidrome");
            }
        }

        //input s ="Hello world" ; find lenght of last word
        public static int FindLengthOfLastWord()
        {
            string input = "Hello world";
           string[] iii =  input.Split( ' ');
            string res = iii[iii.Length - 1];
             return  0;
        }
    }
}
