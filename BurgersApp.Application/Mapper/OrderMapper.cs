using BurgersApp.Application.Dto.Burgers;
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
                //IsCancelled = createOrder.IsCancelled
                //BurgersInOrder = createOrder.Burgers.Where(b => b.IsSelected).ToList().ForEach(b => b.BurgerName)
            };
        }
        //public static Order ToOrder(this OrderDto orderDto, Location location)
        //{
        //    return new Order(orderDto.FirstName, orderDto.LastName, orderDto.Address, orderDto.OrderDate, new List<Burger>(), location)
        //    {
        //        TotalPrice = orderDto.Burgers.Where(b => b.IsSelected).Sum(x => x.BatchOrderBurgerPrice),
        //        //IsCancelled = orderDto.IsCancelled
        //        //BurgersInOrder = createOrder.Burgers.Where(b => b.IsSelected).ToList().ForEach(b => b.BurgerName)
        //    };
        //}
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
                //IsCancelled = order.IsCancelled
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
                //IsCancelled = create.IsCancelled,
                Payment = new OrderPayment()
            };
        }
    }
}