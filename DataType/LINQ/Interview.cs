using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
   
    internal class Interview
    {
        List<Employee> employees = new List<Employee>();
        public void Find2ndHighestSalary() 
        {
            // Find top 2 highest-paid employees with salary > 5000
            var topEmployees = employees
                               .Where(e => e.Salary > 5000)
                               .OrderByDescending(e => e.Salary)
                               .Take(2)
                               .Select(e => new { e.Name, e.Salary });

            foreach (var emp in topEmployees)
                Console.WriteLine($"{emp.Name} - {emp.Salary}");

        }
    }
}
