using BurgersApp.Application.Services;
using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Application.ViewModel.Home;
using BurgersApp.Application.ViewModel.Location;
using BurgersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgersApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILocationService locationService;
        private readonly IBurgerService burgerService;

        public HomeController(ILocationService locationService, IBurgerService burgerService, ILogger<HomeController> logger)
        {
            this.locationService = locationService;
            this.burgerService = burgerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Location = locationService.GetAllLocations(),
                BurgersTest = burgerService.GetAllBurgers()
            };
            return View(model);
            //var locations = locationService.GetAllLocations();
            //return View(model);
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
        public IActionResult CreateLocation(CreateLocationViewModel model)
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
        public IActionResult EditLocation(int id, LocationViewModel model)
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