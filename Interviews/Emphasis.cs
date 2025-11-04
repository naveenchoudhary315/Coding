using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class Emphasis
    {
        //Sort string Naveen in ascending and decending order.
        public static void SortInput()
        {
            string input1 = "Raveen".ToLower();
            char[] input = input1.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length-1; j++)
                {
                    if (input[j] > input[j+1])
                    {
                        char c = input[j];
                        input[j] = input[j+1];
                        input[j+1] = c;
                    }
                }
            }
            Console.WriteLine(input);


        }

        public static void FindPalidromeOfNumber()
        {
            int no = 10091, temp = no;
            int res = 0;
            while (no > 0)
            {
                int reminder = no % 10;
                res =  res *10 + reminder;
                no /= 10;
            }
            if (res == temp)
            { Console.WriteLine("Palidrome"); }
            else
            {
                Console.WriteLine("Not Palidrome");
           }


        }

        public static void FindPalidromeOfString()
        {
            string input = "madamb";
            //var re = input.Reverse();
            string output= null;
            foreach (char c in input.Reverse())
            {
                output += c;
            }
                if (input== output)
                {
                     Console.WriteLine("Palidrome"); 
                }
               else { Console.WriteLine("Not Palidrome"); }
            }

 
        }
}
 