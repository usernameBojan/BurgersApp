using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;

namespace BurgersApp.Db.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order? GetById(int id)
        {
            return OrdersStaticDb.Orders.FirstOrDefault(x => x.Id == id);
        }
        public Order Create(Order entity)
        {
            var lastId = OrdersStaticDb.Orders.LastOrDefault()?.Id ?? 0;
            entity.Id = ++lastId;
            OrdersStaticDb.Orders.Add(entity);
            return entity;
        }
        public void Delete(int id)
        {
            var order = GetById(id);
            OrdersStaticDb.Orders.Remove(order);
        }
        public void DeleteAll()
        {
            OrdersStaticDb.Orders.Clear();
        }
        public IQueryable<Order> GetAll()
        {
            return OrdersStaticDb.Orders.AsQueryable();
        }
        public void Update(Order entity)
        {
            var order = GetById(entity.Id);
            order = entity;
        }
        public IQueryable<Order> GetAllDelieveredBurgers()
        {
            return OrdersStaticDb.Orders.AsQueryable();
        }
        Order IRepository<Order>.Update(Order entity)
        {
            throw new NotImplementedException();
        }
        public Order Delete(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}