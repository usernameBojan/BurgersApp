using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Db.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order? GetById(int id)
        {
            return IntDb.Orders.FirstOrDefault(x => x.Id == id);
        }

        public Order Create(Order entity)
        {
            var lastId = IntDb.Orders.LastOrDefault()?.Id ?? 0;
            entity.Id = ++lastId;
            IntDb.Orders.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var order = GetById(id);
            IntDb.Orders.Remove(order);
        }

        public void DeleteAll()
        {
            IntDb.Orders.Clear();
        }

        public IQueryable<Order> GetAll()
        {
            return IntDb.Orders.AsQueryable();
        }

        public IQueryable<Order> GetAllDeliveredBurgers()
        {
            return IntDb.Orders.AsQueryable();
        }

        public void Update(Order entity)
        {
            var order = GetById(entity.Id);
            order = entity;
        }

        public IQueryable<Order> GetAllDelieveredBurgers()
        {
            throw new NotImplementedException();
        }
    }
}
