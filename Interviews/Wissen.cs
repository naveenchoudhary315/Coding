using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class Wissen
    {
        //get lenght of string from end.
        public static int GetLengthOfString()
        {
            string s = "Hello World";
            string[] input = s.Split(' ');

            foreach (var item in input.Reverse())
            {
                return item.Length; 
            }
            return -1;
        }
    }
}
