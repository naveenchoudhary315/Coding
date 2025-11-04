using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal class Zensar
    {
        public static void Find3rdHighlestSalary(List<int> input)
        {
            var res = input.OrderByDescending(x => x).Skip(2).First();
        }
    }
}
