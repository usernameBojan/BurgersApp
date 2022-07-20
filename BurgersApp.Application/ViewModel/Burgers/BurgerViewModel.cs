using BurgersApp.Domain.Enums;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.ViewModel.Burgers
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredients>? Ingredients { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public Categories Category { get; set; }
    }
}
