using BurgersApp.Application.Dto.Location;

namespace BurgersApp.Application.Services
{
    public interface ILocationService
    {
        IList<LocationDto> GetAllLocations();
        LocationDto GetLocation(int id);
        LocationDto CreateLocation(CreateLocationDto model);
        LocationDto EditLocation(LocationDto model, int id);
        void Delete(int id);
    }
}