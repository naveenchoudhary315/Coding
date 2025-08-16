using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class ProjectionQueries
    {
        List<Employee> employees = new List<Employee>();
        public void Projection_With_Select() 
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Multiply each number by 2
            var doubled = numbers.Select(n => n * 2);

            foreach (var n in doubled)
                Console.WriteLine(n);

        }

        public void Projection_With_Anonymousbject()
        {
          
            var result = employees.Select(e => new
            {
                Name = e.Name,
                Salary = e.Salary / 12
            });

            foreach (var item in result)
                Console.WriteLine($"{item.Name} earns {item. Salary} per month");

        }

        //Flattening Collections with SelectMany.
        //SelectMany is used when each element contains a collection.
        public void Projection_With_SelectMany()
        {
            var customers = new[]
            {
                 new { Name = "Alex", Orders = new[] { "Laptop", "Mouse" } },
                 new { Name = "Naveen", Orders = new[] { "Keyboard" } }
            };

            // Flatten orders
            var allOrders = customers.SelectMany(c => c.Orders);

            foreach (var order in allOrders)
                Console.WriteLine(order);

        }
    }
}
