using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class Joining
    {
        List<Employee> employees = new List<Employee>();
        List<Department> departments = new List<Department>();
        public void InnerJoin()
        {
            var result = employees.Join(departments,
                           e => e.Id,
                           d => d.EmployeeId,
                           (e, d) => new { e.Name, d.DepartmentName });
        }

        //using GroupJoin
        public void LeftJoin()
        {
           

        }


        public void InnesrJoin()
        {
            var result = employees.Join(departments,
                           e => e.Id,
                           d => d.EmployeeId,
                           (e, d) => new { e.Name, d.DepartmentName });
        }
    }
 
    public class Department
    {
        public int EmployeeId { get; set; }
        public string DepartmentName { get; set; }
    }


}
