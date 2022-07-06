using BurgersApp.Application.Services;
using BurgersApp.Application.ViewModel.Burgers;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateBurgerViewModel model)
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
        public IActionResult Edit(int id)
        {
            var burger = burgerService.GetBurger(id);
            return View(burger);
        }
        [HttpPost]
        public IActionResult Edit(int id, BurgerViewModel model)
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

        [HttpGet("Menu/Delete/{id}")]
        public IActionResult DeleteWarning(int id)
        {
            var burger = burgerService.GetBurger(id);

            return View(burger);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            burgerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
