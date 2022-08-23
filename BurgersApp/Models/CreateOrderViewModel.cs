using BurgersApp.Application.Dto.Location;
using BurgersApp.Application.Dto.Order;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgersApp.Models
{
    public class CreateOrderViewModel
    {
        public CreateOrderDto? Form { get; set; }
        public List<SelectListItem>? Location { get; set; }
    }
}