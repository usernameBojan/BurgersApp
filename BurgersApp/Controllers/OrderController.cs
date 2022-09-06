using BurgersApp.Application.Services;
using BurgersApp.Application.Dto.Order;
using BurgersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using BurgersApp.Application;

namespace BurgersApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ILocationService locationService;
        public OrderController(IOrderService orderService, ILocationService locationService)
        {
            this.orderService = orderService;
            this.locationService = locationService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var orderModel = new CreateOrderViewModel
            {
                Form = new CreateOrderDto { Burgers = orderService.GetOrderableBurgers() },
                Location = locationService.GetAllLocations().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList()
            };
            return View(orderModel);
        }

        [AllowAnonymous]
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

        [Authorize(Policy = SystemPolicies.MustHaveId)]
        [HttpGet]
        public IActionResult ServedOrders()
        {
            var active = orderService.GetOrders();
            return View(active);
        }

        [Authorize(Policy = SystemPolicies.MustHaveId)]
        [HttpGet("Order/OrderLog/{id}")]
        public IActionResult OrderLog(int id)
        {
            var order = orderService.GetOrder(id);
            return View(order);
        }
    }
}