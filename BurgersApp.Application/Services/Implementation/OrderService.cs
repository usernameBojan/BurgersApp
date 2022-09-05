using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using Microsoft.EntityFrameworkCore;
using BurgersApp.Application.Dto.Order;
using BurgersApp.Domain.Models;
using BurgersApp.Application.Dto.Home;

namespace BurgersApp.Application.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<Burger> burgerRepository;
        private readonly IRepository<Location> locationRepository;
        public OrderService(IRepository<Order> orderRepository, IRepository<Burger> burgerRepository, IRepository<Location> locationRepository)
        {
            this.orderRepository = orderRepository;
            this.burgerRepository = burgerRepository;
            this.locationRepository = locationRepository;
        }
        public OrderDto GetOrder(int id)
        {
            var order = orderRepository.GetAll()
                                        .Include(x => x.Burgers)
                                        .Include(x => x.Location)
                                        .FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                throw new Exception("Not found");
            }

            foreach(var burger in order.Burgers)
            {
                order.BurgersInOrder += $"{burger.Name}; ";
            }

            return order.ToOrderDto();
        }
        public IList<OrderDto> GetOrders()
        {
            var orders = orderRepository.GetAll()
                                        .Include(x => x.Burgers)
                                        .Include(x => x.Location)
                                        .Select(x => x.ToOrderDto());

            return orders.ToList();
        }
        public OrderDto CreateOrder(CreateOrderDto create)
        {
            var location = locationRepository.GetById(create.LocationId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            create.Location = location.ToLocationLookUp();

            var model = create.ToOrder(location);
            
            foreach (var burger in create.Burgers.Where(x => x.IsSelected))
            {
                var burgerModel = burgerRepository.GetById(burger.BurgerId);
                if(burgerModel != null) 
                {
                    burgerModel.BurgerQuantityForOrder = burger.Quantity;
                    model.AddBurger(burgerModel, 1);
                }
            }

            orderRepository.Create(model);

            return create.ToOrderDto();
        }
        //public void Confirmed(OrderDto create)
        //{
        //    //var location = locationRepository.GetById(create.LocationId);
        //    //if (location == null)
        //    //{
        //    //    throw new Exception("Location not found");
        //    //}
        //    //create.Location = location.ToLocationLookUp();
        //    var model = create.ToOrder();
        //    foreach (var burger in create.Burgers.Where(x => x.IsSelected))
        //    {
        //        var burgerModel = burgerRepository.GetById(burger.BurgerId);
        //        if (burgerModel != null)
        //        {
        //            burgerModel.BurgerQuantityForOrder = burger.Quantity;
        //            model.AddBurger(burgerModel, 1);
        //        }
        //    }
        //    orderRepository.Create(model);

        //    return create.ToOrderDto();
        //}
        public IList<SelectBurgerDto> GetOrderableBurgers()
        {
            return burgerRepository.GetAll().Select(x => new SelectBurgerDto
            {
                BurgerId = x.Id,
                BurgerName = x.Name,
                IsSelected = false,
                HasFries = false,
                Quantity = 0,
                BurgerPrice = x.Price,
            }).ToList();
        }
        public StatisticsDto OrderStatistics()
        {
            var orders = orderRepository.GetAll()
                                        .Include(x => x.Burgers)
                                        .Include(x => x.Location)
                                        .Select(x => x.ToOrderDto())
                                        .ToList();

            var statistics = orders.GetStatistics();
            statistics.BurgerBestSeller = burgerRepository.GetById(statistics.BurgerBestSellerId)?.ToBurgerDto();

            return statistics;
        }
    }
}