using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Application.ViewModel.Order;
using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public OrderViewModel CreateOrder(CreateOrderViewModel create)
        {
            var location = locationRepository.GetById(create.LocationId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            var model = create.ToOrder(location);

            foreach (var burger in create.Burgers.Where(x => x.IsSelected))
            {
                var burgerModel = burgerRepository.GetById(burger.BurgerId);
                if(burgerModel != null) 
                {
                    model.AddBurger(burgerModel, 1);
                }
            }

            var created = orderRepository.Create(model);

            return created.ToOrderViewModel();

        }
    }


}