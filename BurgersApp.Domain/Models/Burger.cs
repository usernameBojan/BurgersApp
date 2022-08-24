using BurgersApp.Domain.Enums;

namespace BurgersApp.Domain.Models
{
    public class Burger : IEntity
    {
        public Burger()
        {

        }
        public Burger(string name, int price, bool isVegetarian, bool isVegan, string ingredients, string img)
        {
            Name = name;
            Price = price;
            Ingredients = ingredients;
            ImgSrc = img;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;

            _ = (isVegan) ? Category = Categories.Vegan
                : ((isVegan) || (isVegetarian)) ? Category = Categories.Vegetarian
                : Category = Categories.Regular;
        }
        public Burger(int id, string name, int price, bool isVegetarian, bool isVegan, string ingredients, string img)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            ImgSrc = img;
            Price = price;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;

            _ = (isVegan) ? Category = Categories.Vegan
                : ((isVegan) || (isVegetarian)) ? Category = Categories.Vegetarian
                : Category = Categories.Regular;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ingredients { get; set; } = string.Empty;
        public string ImgSrc { get; set; } = string.Empty;
        public int Price { get; set; }
        public int BurgerQuantityForOrder { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public Categories Category { get; set; }
    }
}