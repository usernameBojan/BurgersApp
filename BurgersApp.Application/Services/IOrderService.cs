using BurgersApp.Application.Dto.Home;
using BurgersApp.Application.Dto.Order;

namespace BurgersApp.Application.Services
{
    public interface IOrderService
    {
        OrderDto CreateOrder(CreateOrderDto create);
        IList<OrderDto> GetOrders();
        OrderDto GetOrder(int id);
        StatisticsDto OrderStatistics();
        IList<SelectBurgerDto> GetOrderableBurgers();
    }
}