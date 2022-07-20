using BurgersApp.Domain.Models;

namespace BurgersApp.Db
{
    public static class IntDb
    {
        public static string genericName = "PseudoBurgers";

        public static List<Location> Locations = new List<Location>
        {
            new Location(1, $"{genericName} Tetovo", "Boulevard Ilirija 9999, Tetovo", "09:00", "23:00", true),
            new Location(2, $"{genericName} Gjorche Petrov", "Gjorche Petrov 9999, Gjorche Petrov, Skopje", "10:00", "22:00", false),
            new Location(3, $"{genericName} Center", "Boulevard Partizanski Odredi 9999, Center, Skopje", "08:00", "00:00", true),
            new Location(4, $"{genericName} Aerodrom", "Boulevard Jane Sandanski 9999, Aerodrom, Skopje", "09:00", "00:00", false),
            new Location(5, $"{genericName} Ohrid", "Boulevard Turistichka 9999, Ohrid", "08:00", "00:00", true),
        };
        public static IList<Order> Orders { get; set; } = new List<Order>
        {

        };

        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger(1, "Hamburger", 120, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Beef burger"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Sauces")
            }),
            new Burger(2, "Cheeseburger", 140, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Beef burger"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Melted cheddar"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Sauces")
            }),
            new Burger(3, "Baconburger", 130, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Beef burger"),
                new Ingredients(3, "Bacon"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Sauces")
            }),
            new Burger(4, "Eggburger", 150, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Beef burger"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Fried egg"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Sauces")
            }),
            new Burger(5, "Crispy Chicken", 150, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Batter fried chicken fillet"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Melted cheddar"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Sauces")
            }),
            new Burger(6, "Chicken Sandwich", 120, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Chicken fillet"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Sauces")
            }),
            new Burger(7, "x2burger", 160, false, false, false, Domain.Enums.Categories.Regular, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Two beef burgers"),
                new Ingredients(3, "Chicken ham slice"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Sauces")
            }),
            new Burger(8, "Vegetarian Burger", 120, true, false, false, Domain.Enums.Categories.Vegetarian, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Soybean burger"),
                new Ingredients(3, "Mushrooms"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Sauces")
            }),
            new Burger(9, "Vegetarian Cheeseburger", 140, true, false, false, Domain.Enums.Categories.Vegetarian, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Soybean burger"),
                new Ingredients(3, "Mushrooms"),
                new Ingredients(4, "Melted cheddar cheese"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Sauces")
            }),
            new Burger(10, "Vegetarian Eggburger", 150, true, false, false, Domain.Enums.Categories.Vegetarian, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Soybean burger"),
                new Ingredients(3, "Mushrooms"),
                new Ingredients(4, "Fried egg"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Sauces")
            }),
            new Burger(11, "Vegan Burger", 120, true, true, false, Domain.Enums.Categories.Vegan, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Soybean burger"),
                new Ingredients(3, "Mushrooms"),
                new Ingredients(4, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(5, "Vegan sauces")
            }),
            new Burger(12, "Vegan Cheeseburger", 150, true, true, false, Domain.Enums.Categories.Vegan, new List<Ingredients>
            {
                new Ingredients(1, "Gluten free bun with seeds"),
                new Ingredients(2, "Soybean burger"),
                new Ingredients(3, "Mushrooms"),
                new Ingredients(4, "Tofu cheese"),
                new Ingredients(5, "Vegetables(lettuce, tomato and pickle)"),
                new Ingredients(6, "Vegan sauces")
            })
        };      
    }
}