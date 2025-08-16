using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class Grouping
    {
        List<Employee> employees = new List<Employee>();
        public void GroupByExample()
        {
            
            var groupedByAge = employees.GroupBy(p => p.Salary);

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }
        }

        public void GroupByWithProjection()
        {
            var groups = employees.GroupBy(e => new { e.Name, SalaryRange = e.Salary > 6000 ? "High" : "Low" });

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key.SalaryRange} - {group.Key.SalaryRange}");
                foreach (var emp in group)
                    Console.WriteLine($"  {emp.Name} - {emp.Salary}");
            }

        }
    }
}
