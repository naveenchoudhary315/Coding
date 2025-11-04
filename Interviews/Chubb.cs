using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class Chubb
    {
        /// <summary>
        /// List<string> val = {"art","ccc","rat","ccc","tra"}
        /// OUtput: art,rat,tra</string>
        /// </summary>
        public static void SortAStringList()
        {
            List<string> val = new List<string> { "art", "ccc", "rat", "ccc", "tra" };
            var res = val
                .GroupBy(word => word.Concat(word.OrderBy(c=>c)))
                .Where(x => x.Count() > 1 )
                .SelectMany(x=>x)
                .OrderBy(word => word)
                .ToList();

        }
    }
}
