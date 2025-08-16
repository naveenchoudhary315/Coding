using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class Filtering
    {
        public void Where()
        {
            int[] numbers = { 1, 5, 8, 10, 2, 7 };

            // Numbers greater than 5
            var result = numbers.Where(n => n > 5);

            foreach (var n in result)
                Console.WriteLine(n);
        }

        public void Where_With_Employee()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alex", Salary = 4000 },
                new Employee { Id = 2, Name = "Naveen", Salary = 7000 },
                new Employee { Id = 3, Name = "John", Salary = 5000 }
            };

            // Employees with salary > 5000
            var highEarners = employees.Where(e => e.Salary > 5000);

            foreach (var emp in highEarners)
                Console.WriteLine($"{emp.Name} - {emp.Salary}");


        }

        public void RemveDuplicate()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4 };

            var unique = nums.Distinct();

            foreach (var n in unique)
                Console.WriteLine(n);
        }

        public void TakeAndSkip()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numbers.Where((n, index) => n > 2 && index % 2 == 0);

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}