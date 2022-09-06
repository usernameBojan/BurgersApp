using BurgersApp.Application;
using BurgersApp.Application.Dto.Burgers;
using BurgersApp.Application.Dto.Location;
using BurgersApp.Application.Services;
using BurgersApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurgersApp.Controllers
{
    [Authorize(Policy = SystemPolicies.MustHaveId)]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService adminService;
        private readonly ILocationService locationService;
        private readonly IOrderService orderService;
        private readonly IBurgerService burgerService;

        public AdminController(
            IAdminService adminService,
            ILocationService locationService, 
            IOrderService orderService, 
            IBurgerService burgerService, 
            ILogger<HomeController> logger
            )
        {
            this.adminService = adminService;
            this.locationService = locationService;
            this.orderService = orderService;
            this.burgerService = burgerService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new AdminViewModel
            {
                Locations = locationService.GetAllLocations(),
                Burgers = burgerService.GetAllBurgers()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLocation(CreateLocationDto model)
        {
            try
            {
                locationService.CreateLocation(model);
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditLocation(int id)
        {
            var location = locationService.GetLocation(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult EditLocation(int id, LocationDto model)
        {
            try
            {
                locationService.EditLocation(model, id);
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Admin/DeleteLocation/{id}")]
        public IActionResult DeleteLocationWarning(int id)
        {
            var location = locationService.GetLocation(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult DeleteLocation(int id)
        {
            locationService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateBurger()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBurger(CreateBurgerDto model)
        {
            try
            {
                burgerService.CreateBurger(model);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditBurger(int id)
        {
            var burger = burgerService.GetBurger(id);
            return View(burger);
        }

        [HttpPost]
        public IActionResult EditBurger(int id, BurgerDto model)
        {
            try
            {
                burgerService.EditBurger(model, id);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("Admin/DeleteBurger/{id}")]
        public IActionResult DeleteWarning(int id)
        {
            var burger = burgerService.GetBurger(id);

            return View(burger);
        }

        [HttpPost]
        public IActionResult DeleteBurger(int id)
        {
            burgerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}