using BurgersApp.Application.ViewModel.Location;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class LocationMapper
    {
        public static LocationViewModel ToLocationViewModel(this Location location)
        {
            return new LocationViewModel
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                Opens = location.OpensAt,
                Closes = location.ClosesAt,
                WorkingDaysAndHours = location.WorkingDaysAndHours
            };
        }

        public static Location ToLocation(this CreateLocationViewModel create)
        {
            return new Location(create.Name, create.Address, create.Opens, create.Closes, create.ProlongedWeeknight);
        }

        public static Location Edit(this Location location, LocationViewModel model)
        {
            location.Name = model.Name;
            location.Address = model.Address;
            location.WorkingDaysAndHours = $"Monday - Saturday: {model.Opens} - {model.Closes}";
            return location;
        }
    }
}
