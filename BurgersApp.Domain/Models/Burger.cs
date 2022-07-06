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

        public Burger(string name, int price, bool isVegetarian, bool isVegan, List<string> ingredients)
        {
            Name = name;
            Price = price;
            Indgredients = ingredients;
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

        public Burger(int id, string name, int price, bool isVegetarian, bool isVegan, bool hasFries, Categories categories, List<string> ingredients)
        {
            Id = id;
            Name = name;
            Indgredients = ingredients;
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
        public List<string>? Indgredients { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public Categories Category { get; set; }
    }
}
