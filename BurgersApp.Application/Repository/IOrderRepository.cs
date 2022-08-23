using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        public IQueryable<Order> GetAllDelieveredBurgers();
    }
}
