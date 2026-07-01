using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Server._2_ServiceLayer;
using WebAPI.Server.Model;

namespace EmployeeAPI_TestCases.IntegrationTestCases
{
    public class FakeEmployeeService : IEmployeeService
    {
        public Task AddAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Employee>>
            (
                new List<Employee>
                {
                new Employee
                {
                    Id = 1,
                    Name = "John"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane"
                }
                }
            );
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Employee>> IEmployeeService.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
