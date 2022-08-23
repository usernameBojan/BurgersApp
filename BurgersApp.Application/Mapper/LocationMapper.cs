using BurgersApp.Application.Dto.Location;
using BurgersApp.Application.Dto.Order;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class LocationMapper
    {
        public static LocationDto ToLocationDto(this Location location)
        {
            return new LocationDto
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                Opens = location.OpensAt,
                Closes = location.ClosesAt,
                WorkingDaysAndHours = location.WorkingDaysAndHours
            };
        }
        public static Location ToLocation(this CreateLocationDto create)
        {
            return new Location(create.Name, create.Address, create.Opens, create.Closes);
        }
        public static Location Edit(this Location location, LocationDto model)
        {
            location.Name = model.Name;
            location.Address = model.Address;
            location.OpensAt = model.Opens;
            location.ClosesAt = model.Closes;
            return location;
        }
        public static LocationLookUp ToLocationLookUp(this Location location)
        {
            return new LocationLookUp
            {
                Name = location.Name,
                Address = location.Address,
                Id = location.Id
            };
        }
    }
}