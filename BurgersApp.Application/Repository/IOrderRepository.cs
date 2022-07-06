using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        public IQueryable<Order> GetAllDelieveredBurgers();
    }
}
