using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class Partitioning
    {
        List<Employee> employees = new List<Employee>();
        public void Test()
        {
            var top2 = employees.Take(2);
            var skip2 = employees.Skip(2);

        }
    }
}
