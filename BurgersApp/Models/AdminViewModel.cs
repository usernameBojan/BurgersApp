using BurgersApp.Application.Dto.Burgers;
using BurgersApp.Application.Dto.Location;
using BurgersApp.Application.Dto.Order;

namespace BurgersApp.Models
{
    public class AdminViewModel
    {
        public IEnumerable<LocationDto>? Locations { get; set; }
        public IEnumerable<BurgerDto>? Burgers { get; set; }
    }
}