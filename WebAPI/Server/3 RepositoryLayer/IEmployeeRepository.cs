using WebAPI.Server.Model;

namespace WebAPI.Server._3_RepositoryLayer
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();

        Task<Employee?> GetByIdAsync(int id);

        Task AddAsync(Employee employee);
    }
}
