using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal class Microsoft1
    {
        public Employee1 GetListoDDepartments(List<Employee1> employees, int findEmpId)
        {
            return employees.FirstOrDefault(emp => emp.Empid == findEmpId);

        }




    }

    public class Employee1
    {
        public int Empid;
        public string name;
        public double salary;
    }
    public class Department1
    {
        public int id;
        public string dept_name;
        public List<Employee> lstEmp;
    }

}
