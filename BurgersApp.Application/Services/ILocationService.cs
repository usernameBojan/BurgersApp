using BurgersApp.Application.ViewModel.Home;
using BurgersApp.Application.ViewModel.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Services
{
    public interface ILocationService
    {
        IList<LocationViewModel> GetAllLocations();

        LocationViewModel GetLocation(int id);

        LocationViewModel CreateLocation(CreateLocationViewModel model);

        LocationViewModel EditLocation(LocationViewModel model, int id);

        void Delete(int id);
    }
}
