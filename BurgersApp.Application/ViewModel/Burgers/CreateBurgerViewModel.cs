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
        public string Ingredients { get; set; }
        public string ImgSrc { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
    }
}
