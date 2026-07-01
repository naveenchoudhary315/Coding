using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI_TestCases.IntegrationTestCases
{
    using System.Net;
    using System.Net.Http.Json;
    using WebAPI.Server.Model;
    using Xunit;

    public class EmployeesControllerIntegrationTests
        : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public EmployeesControllerIntegrationTests(
            CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAll_ReturnsEmployees()
        {
            // Act
            var response =
                await _client.GetAsync("/api/v1/Employees");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var employees =
                await response.Content.ReadFromJsonAsync<List<Employee>>();

            Assert.NotNull(employees);
            Assert.Equal(2, employees.Count);

            Assert.Equal("John", employees[0].Name);
        }
    }
}
