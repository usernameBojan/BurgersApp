using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class BurgersMapper
    {
        public static BurgerViewModel ToBurgerViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Indgredients = burger.Indgredients,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                Category = burger.Category,
                HasFries = burger.HasFries
            };
        }

        public static Burger ToBurger(this CreateBurgerViewModel create)
        {
            return new Burger(create.Name, create.Price, create.IsVegetarian, create.IsVegan, create.Indgredients);    
        }

        public static Burger Edit(this Burger burger, BurgerViewModel model)
        {
            burger.Name = model.Name;
            burger.Price = model.Price;
            //burger.Indgredients = model.Indgredients;

            return burger;
        }
    }
}
