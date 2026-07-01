using WebAPI.Server.Model;


using Microsoft.EntityFrameworkCore;

namespace WebAPI.Server._3_RepositoryLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employee.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employee.FindAsync(id);
        }

        public async Task AddAsync(Employee employee)
        {
            _context.Employee.Add(employee);

            await _context.SaveChangesAsync();
        }
    }
}
