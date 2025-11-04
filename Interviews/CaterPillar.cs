using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class CaterPillar
    {
        //Regex expression to validate mobile no: +9198823428600
        public static bool ValidateMobileNo()
        {
            string mobileNo = "9882428600i";
            var res = Regex.Match(mobileNo, @"[0-9]");
            Regex regex = new Regex(@"[0-9]");
            var rrr = regex.Match(mobileNo);
            return false;
        }

        public static void RemoveDuplicate()
        {
            int[] data = { 1, 2, 2, 3, 4, 6, 4, 7 };
            List<int> list = new List<int>();   
            foreach (var item in data)
            {
                if (!list.Contains(item))
                {
                  list.Add(item);
                }
            }
        }
    
    }
}
