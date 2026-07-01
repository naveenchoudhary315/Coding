
namespace ProblemWithoutRepository
{
    public interface IOrderService
    {
        Task CreateOrder(Order order);
        Task<Order> GetOrder(int id);
    }
}