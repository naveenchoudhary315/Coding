using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal class Microsoft
    {
        public Employee GetListoDDepartments(List<Employee> employees, int findEmpId)
        {
            return employees.FirstOrDefault(emp => emp.id == findEmpId);

        }




    }

    public class Employee
    {
        public int id;
        public string name;
        public double salary;
    }
    public class Department
    {
        public int id;
        public string dept_name;
        public List<Employee> lstEmp;
    }

}
