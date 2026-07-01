using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Without_Repository
{
    public class OrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrder(int id)
        {
            //return 
            //await _context.Orders
            //    .FirstOrDefaultAsync(x => x.Id == id);
            return null;
        }

        public async Task CreateOrder(Order order)
        {
            //await _context.Orders.AddAsync(order);
            //await _context.SaveChangesAsync();
        }
    }

    public class AppDbContext
    {
        public object Orders { get; internal set; }
    }

    public class Order
    {
    }

}



namespace Solution_With_Repository
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Order> GetOrder(int id)
        {

            return await _repository.GetByIdAsync(id);
        }
        public async Task CreateOrder(Order order)
        {
            //await _context.Orders.AddAsync(order);
            //await _context.SaveChangesAsync();
        }
    }



    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(int id);

        Task AddAsync(Order order);

        Task<List<Order>> GetPendingOrdersAsync();
    }
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            //return await _context.Orders
            //    .FirstOrDefaultAsync(x => x.Id == id);
            return null;
        }

        public async Task AddAsync(Order order)
        {
            //await _context.Orders.AddAsync(order);
            //await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetPendingOrdersAsync()
        {
            return null;
            //return await _context.Orders
            //    .Where(x => x.Status == "Pending")
            //    .ToListAsync();
        }
    }

    public class AppDbContext
    {
        public object Orders { get; internal set; }
    }

    public class Order
    {
    }

}