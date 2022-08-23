using BurgersApp.Application.Services;
using BurgersApp.Application.Dto.Order;
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

        [HttpGet]
        public IActionResult Index()
        {
            var orderModel = new CreateOrderViewModel
            {
                Form = new CreateOrderDto { Burgers = orderService.GetOrderableBurgers() },
                Location = locationService.GetAllLocations().Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList()
            };
            return View(orderModel);
        }

        [HttpPost]
        public IActionResult ConfirmOrder(CreateOrderViewModel order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var confirm = orderService.CreateOrder(order.Form);
            return View(confirm);
        }
        public IActionResult ServedOrders()
        {
            var active = orderService.GetOrders();
            return View(active);
        }

        [HttpGet("Order/OrderLog/{id}")]
        public IActionResult OrderLog(int id)
        {
            var order = orderService.GetOrder(id);
            return View(order);
        }
    }
}