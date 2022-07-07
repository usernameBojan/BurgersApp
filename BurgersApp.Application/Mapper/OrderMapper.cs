using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Application.ViewModel.Order;
using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Mapper
{
    public static class OrderMapper
    {
        public static Order ToOrder(this CreateOrderViewModel createOrder, Location location)
        {
            return new Order(createOrder.FirstName, createOrder.LastName, createOrder.Address, new List<Burger>(), location, false);
        }

        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                FullName = order.FullName,
                Address = order.Address,
                Location = new LocationLookUp 
                { 
                    Address = order.Location.Address,
                    Name = order.Location.Name,
                    Id = order.Location.Id
                },
                Burgers = order.Burgers.Select(b => new SelectBurger 
                {
                    BurgerId = b.Id,
                    IsSelected = true,
                    BurgerName = b.Name,
                }
                ).ToList(),
                IsDelievered = order.IsDelievered,
            };
        }
        
    }
}
