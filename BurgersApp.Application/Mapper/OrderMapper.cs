using BurgersApp.Application.Dto.Order;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class OrderMapper
    {
        public static Order ToOrder(this CreateOrderDto createOrder, Location location)
        {
            return new Order(createOrder.FirstName, createOrder.LastName, createOrder.Address, createOrder.OrderDate, new List<Burger>(), location)
            {
                TotalPrice = createOrder.Burgers.Where(b => b.IsSelected).Sum(x => x.BatchOrderBurgerPrice),
            };
        }
        public static OrderDto ToOrderDto(this Order order)
        {
            return new OrderDto()
            {
                Id = order.Id,
                FirstName = order.FirstName,
                LastName = order.LastName,
                Burgers = order.Burgers.Select(b => new SelectBurgerDto
                {
                    BurgerId = b.Id,
                    IsSelected = false,
                    BurgerName = b.Name,
                    HasFries = false,
                    Quantity = b.BurgerQuantityForOrder,
                    BurgerPrice = b.Price,
                }).ToList(),
                Location = new LocationLookUp
                {
                    Address = order.Location.Address,
                    Name = order.Location.Name,
                    Id = order.Location.Id
                },
                Address = order.Address,
                TotalPrice = order.TotalPrice,
                OrderDate = order.OrderDate,
                BurgersInOrder = order.BurgersInOrder,
            };
        }
        public static OrderDto ToOrderDto(this CreateOrderDto create)
        {
            return new OrderDto
            {
                Id = create.Id,
                Burgers = create.Burgers,
                Address = create.Address,
                FirstName = create.FirstName,
                LastName = create.LastName,
                Location = create.Location,
                TotalPrice = create.Burgers.Where(b => b.IsSelected)
                                           .Sum(x => x.BatchOrderBurgerPrice),
                OrderDate = create.OrderDate,
                Payment = new OrderPayment()
            };
        }
    }
}