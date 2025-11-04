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
          
             foreach (Employee employee in employees) 
             {
                if(employee.id == findEmpId) { return employee; }
             }
            return null;
        }

        public void Merge2Arrays()
        {
            int[] n1= { 1, 2, 3 ,0,0,0};
            int[] n2= { 4,5,6};
          
            for (int i = 0; i < n1.Length; i++) 
            {
                if (n1[i] == 0)
                {
                    for (int j = 0; j <= n2.Length-1; j++,i++)
                    {
                        n1[i] = n2[j];
                    }
                }
            
            }
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
