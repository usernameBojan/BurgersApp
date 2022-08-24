using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Application.Dto.Location;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Services.Implementation
{
    public class LocationService : ILocationService
    {

        private readonly IRepository<Location> repository;
        public LocationService(IRepository<Location> repository)
        {
            this.repository = repository;
        }
        public LocationDto CreateLocation(CreateLocationDto dto)
        {
            var location = dto.ToLocation();

            var created = repository.Create(location);
            return created.ToLocationDto();
        }
        public void Delete(int id)
        {
            var location = repository.GetById(id);
            if (location == null)
            {
                throw new Exception("No such location");
            }
            repository.Delete(location);
        }
        public LocationDto EditLocation(LocationDto dto, int id)
        {
            var location = repository.GetById(id);

            if (location == null)
            {
                throw new Exception("No such location");
            }
            var updated = location.Edit(dto);

            repository.Update(updated);

            return updated.ToLocationDto();
        }
        public IList<LocationDto> GetAllLocations()
        {
            var locations = repository.GetAll()
                                      .Select(x => x.ToLocationDto());

            return locations.ToList();
        }
        public LocationDto GetLocation(int id)
        {
            var location = repository.GetById(id);

            if (location == null)
            {
                throw new Exception("Not found");
            }
            return location.ToLocationDto();
        }
    }
}