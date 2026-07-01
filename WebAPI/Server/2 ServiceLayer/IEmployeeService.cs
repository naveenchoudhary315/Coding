using WebAPI.Server.Model;

namespace WebAPI.Server._2_ServiceLayer
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllAsync();

        Task<Employee?> GetByIdAsync(int id);

        Task AddAsync(Employee employee);
    }
}
