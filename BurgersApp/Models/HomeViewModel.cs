using BurgersApp.Application.Dto.Location;

namespace BurgersApp.Application.Dto.Home
{
    public class HomeViewModel
    {
        public IEnumerable<LocationDto>? Location { get; set; }
        public StatisticsDto? Statistics { get; set; }
    }
}