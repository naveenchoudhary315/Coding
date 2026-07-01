using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WebAPI.Server;
using WebAPI.Server._2_ServiceLayer;
using WebAPI.Server.Model;

namespace EmployeeAPI_TestCases
{
    public class EmployeesControllerTests
    {
        private readonly Mock<IEmployeeService> _employeeServiceMock;
        private readonly EmployeesController employeeService;

        EmployeesControllerTests()
        {
            _employeeServiceMock = new Mock<IEmployeeService>();
            employeeService = new EmployeesController(_employeeServiceMock.Object);
        }

        [Fact]
        public async Task Get_All_ShouldReturnOk_WithEmployee()
        {
            // Arrange
            var employees = new List<Employee>
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
                 };

            _employeeServiceMock.Setup(x => x.GetAllAsync()).ReturnsAsync(employees);

            // Act 
            var result = await employeeService.GetAll();

            // Assert.
            var okResult = Assert.IsType<OkObjectResult>(result);
            var actualEmployees = Assert.IsType<List<Employee>>(okResult.Value);

            Assert.Equal(1, actualEmployees.Count);
            _employeeServiceMock.Verify(x => x.GetAllAsync(), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public async Task GetAll_ShouldReturnOkResult_WithExpectedEmployeeCount(int employeeCount)
        {
            // Arrange
            var employees = Enumerable.Range(1, employeeCount)
                                      .Select(x => new Employee
                                      {
                                          Id = x,
                                          Name = $"Employee{x}"
                                      })
                                      .ToList();

            _employeeServiceMock.Setup(x => x.GetAllAsync()).ReturnsAsync(employees);

            // Act
            var result = await employeeService.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnedEmployees =
                Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);

            Assert.Equal(employeeCount, returnedEmployees.Count());

            _employeeServiceMock.Verify(
                x => x.GetAllAsync(),
                Times.Once);
        }
    }
}
