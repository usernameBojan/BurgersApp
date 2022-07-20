using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.ViewModel.Burgers
{
    public class CreateBurgerViewModel
    {
        public string Name { get; set; }
        public List<Ingredients>? Ingredients { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
    }
}
