using BurgersApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (isVegan)
            {
                Category = Categories.Vegan;
            }
            else if ((isVegan) || (isVegetarian))
            {
                Category = Categories.Vegetarian;
            }
            else Category = Categories.Regular;
        }

        public Burger(int id, string name, int price, bool isVegetarian, bool isVegan, bool hasFries, Categories categories, string ingredients, string img)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            ImgSrc = img;
            Price = price;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
            Category = categories;

            if (hasFries)
            {
                Price = price + 40;
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string ImgSrc { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public Categories Category { get; set; }
    }
}
