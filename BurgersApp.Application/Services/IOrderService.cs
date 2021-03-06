using BurgersApp.Application.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Services
{
    public interface IOrderService
    {
        OrderViewModel CreateOrder(CreateOrderViewModel create);
        OrderViewModel GetOrder(int id);
        List<SelectBurger> GetOrderableBurgers();

    }
}
