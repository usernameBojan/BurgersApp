using BurgersApp.Application.Services;
using BurgersApp.Application.ViewModel.Order;
using BurgersApp.Db;
using BurgersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgersApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ILocationService locationService;
        public OrderController(IOrderService orderService, ILocationService locationService)
        {
            this.orderService = orderService;
            this.locationService = locationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            var orderModel = new CreateOrderModel
            {
                Form = new CreateOrderViewModel { Burgers = orderService.GetOrderableBurgers() },
                Location = locationService.GetAllLocations().Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList()
            };
            return View(orderModel);
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderModel order)
        {
            orderService.CreateOrder(order.Form);
            return RedirectToAction("Index");
        }
    }
    
}

