using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.ViewModel.Order
{
    public class CreateOrderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public IList<SelectBurger> Burgers { get; set; } = new List<SelectBurger>();
        public int LocationId { get; set; }
    }

    public class SelectBurger
    {
        public int BurgerId { get; set; }   
        public bool IsSelected { get; set; }
        public string BurgerName { get; set; }
    }
}
