using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Application.ViewModel.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.ViewModel.Home
{
    public class HomeViewModel
    {
        public IEnumerable<LocationViewModel> Location { get; set; }
        public IEnumerable<BurgerViewModel> BurgersTest { get; set; }
    }
}
