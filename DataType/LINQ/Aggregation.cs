using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class Aggregation
    {
        List<Employee> employees = new List<Employee>();
        public void  Aggregationtest() 
        {
            int count = employees.Count();
            decimal totalSalary = employees.Sum(e => e.Salary);
            var avgSalary = employees.Average(e => e.Salary);
            var maxSalary = employees.Max(e => e.Salary);
        }
    }
}
