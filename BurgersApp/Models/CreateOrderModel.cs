using BurgersApp.Application.ViewModel.Location;
using BurgersApp.Application.ViewModel.Order;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgersApp.Models
{
    public class CreateOrderModel
    {

        public CreateOrderViewModel Form { get; set; }
        public List<SelectListItem> Location { get; set; }

    }
}
