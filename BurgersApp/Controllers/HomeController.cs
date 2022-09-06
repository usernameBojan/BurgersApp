using BurgersApp.Application.Services;
using BurgersApp.Application.Dto.Home;
using BurgersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace BurgersApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILocationService locationService;
        private readonly IOrderService orderService;
        private readonly IAdminService adminService;

        public HomeController(ILocationService locationService, IOrderService orderService, IAdminService adminService, ILogger<HomeController> logger)
        {
            this.locationService = locationService;
            this.orderService = orderService;
            this.adminService = adminService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Location = locationService.GetAllLocations(),
                Statistics = orderService.OrderStatistics()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            bool checkClaim = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out int adminId);
            if(!checkClaim)
            {
                return View();
            }

            var admin = adminService.GetAdmin(adminId);
            if(admin != null)
            {
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginDto loginDto)
        {
            try
            {
                var admin = adminService.Login(loginDto);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.FirstName),
                    new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                };

                var identities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identities);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception)
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}