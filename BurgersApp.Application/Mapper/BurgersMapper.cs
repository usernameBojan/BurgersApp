using BurgersApp.Application.Dto.Burgers;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class BurgersMapper
    {
        public static BurgerDto ToBurgerDto(this Burger burger)
        {
            return new BurgerDto
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Ingredients = burger.Ingredients,
                ImgSrc = burger.ImgSrc,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                Category = burger.Category,
                HasFries = burger.HasFries
            };
        }
        public static Burger ToBurger(this CreateBurgerDto create)
        {
            return new Burger(create.Name, create.Price, create.IsVegetarian, create.IsVegan, create.Ingredients, create.ImgSrc);    
        }
        public static Burger Edit(this Burger burger, BurgerDto model)
        {
            burger.Name = model.Name;
            burger.Price = model.Price;
            burger.Ingredients = model.Ingredients;
            burger.ImgSrc = model.ImgSrc;

            return burger;
        }
    }
}