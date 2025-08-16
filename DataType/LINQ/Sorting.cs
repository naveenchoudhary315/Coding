using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    
    internal class Sorting
    {
        List<Employee> employees = new List<Employee>();
        public void SortingTest() 
        {

            var sorted = employees.OrderBy(e => e.Salary);
            var sortedDesc = employees.OrderByDescending(e => e.Salary);
        }
    
        public void Sorting_With_ThenBy()
        {
            // Sort by salary, then by name
            var sorted = employees.OrderBy(e => e.Salary).ThenBy(e => e.Name);
            foreach (var emp in sorted)
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }
    }
}
