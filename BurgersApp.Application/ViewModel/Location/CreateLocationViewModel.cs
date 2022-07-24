using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.ViewModel.Location
{
    public class CreateLocationViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Opens { get; set; }
        public string Closes { get; set; }
        public string WorkingDaysAndHours { get; set; }
    }
}
