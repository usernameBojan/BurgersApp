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
            repository.Delete(id);
        }
        public LocationDto EditLocation(LocationDto model, int id)
        {
            var location = repository.GetById(id);

            if (location == null)
            {
                throw new Exception("No such location");
            }
            var toSave = location.Edit(model);

            repository.Update(toSave);

            return toSave.ToLocationDto();
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