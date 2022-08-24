using BurgersApp.Application.Services;
using BurgersApp.Application.Dto.Home;
using BurgersApp.Application.Dto.Location;
using BurgersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgersApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILocationService locationService;
        private readonly IOrderService orderService;


        public HomeController(ILocationService locationService, IOrderService orderService, ILogger<HomeController> logger)
        {
            this.locationService = locationService;
            this.orderService = orderService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Location = locationService.GetAllLocations(),
                Statistics = orderService.OrderStatistics()
            };

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
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

        [HttpGet("Home/DeleteLocation/{id}")]
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}