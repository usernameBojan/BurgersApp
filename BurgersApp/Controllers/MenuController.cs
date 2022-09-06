using BurgersApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgersApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBurgerService burgerService;

        public MenuController(IBurgerService burgerService)
        {
          this.burgerService = burgerService;
        }
        public IActionResult Index()
        {
            var burgers = burgerService.GetAllBurgers();
            return View(burgers);
        }
    }
}