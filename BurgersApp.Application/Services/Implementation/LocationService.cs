using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Application.ViewModel.Location;
using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Services.Implementation
{
    public class LocationService : ILocationService
    {

        private readonly IRepository<Location> repository;
        public LocationService(IRepository<Location> repository)
        {
            this.repository = repository;
        }

        public LocationViewModel CreateLocation(CreateLocationViewModel model)
        {
            var location = model.ToLocation();

            var newItem = repository.Create(location);
            return newItem.ToLocationViewModel();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
        public LocationViewModel EditLocation(LocationViewModel model, int id)
        {
            var location = repository.GetById(id);

            if (location == null)
            {
                throw new Exception("No such location");
            }
            var toSave = location.Edit(model);

            repository.Update(toSave);

            return toSave.ToLocationViewModel();
        }

        public IList<LocationViewModel> GetAllLocations()
        {
            return repository.GetAll().Select(x => x.ToLocationViewModel()).ToList();
        }

        public LocationViewModel GetLocation(int id)
        {
            var location = repository.GetById(id);

            if (location == null)
            {
                throw new Exception("Not found");
            }
            return location.ToLocationViewModel();
        }
    }
}