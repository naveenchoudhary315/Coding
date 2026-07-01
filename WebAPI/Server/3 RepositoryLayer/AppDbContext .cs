using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebAPI.Server.Model;

namespace WebAPI.Server._3_RepositoryLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
