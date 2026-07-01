using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class ObjectOverrideScenario
    {
        public void MainMethod()
        {
            Employee employee1 = new Employee(1);
            Employee employee2 = employee1;
            employee2.id = 5;

            employee2 = new Employee(10);
            Console.WriteLine(employee1.id);   // 5
            Console.WriteLine(employee2.id);  // 10
        }
    }

    class Employee
    {
        public int id;

        public Employee()
        {
        }

        public Employee(int id)
        {
            this.id = id;
        }
    }
}
