using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.ViewModel.Order
{
    public class OrderViewModel
    {
        public string FullName { get; set; }
        public string Address { get; set; } 
        public LocationLookUp Location { get; set; }
        public List<SelectBurger> Burgers { get; set; }
        public bool IsDelievered { get; set; }

    }

    public class LocationLookUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
