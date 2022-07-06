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
            new Burger(1, "Hamburger", 120, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Beef burger",
                "Chicken ham slice",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(2, "Cheeseburger", 140, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Beef burger",
                "Chicken ham slice",
                "Melted cheddar",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(3, "Baconburger", 130, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Beef burger",
                "Bacon",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(4, "Eggburger", 150, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Beef burger",
                "Chicken ham slice",
                "Fried egg",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(5, "Crispy Chicken", 150, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Batter fried chicken fillet",
                "Chicken ham slice",
                "Melted cheddar",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(6, "Chicken Sandwich", 120, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Chicken fillet",
                "Chicken ham slice",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(7, "x2burger", 160, false, false, false, Domain.Enums.Categories.Regular, new List<string>
            {
                "Gluten free bun with seeds",
                "Two beef burgers burger",
                "Chicken ham slice",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(8, "Vegetarian Burger", 120, true, false, false, Domain.Enums.Categories.Vegetarian, new List<string>
            {
                "Gluten free bun with seeds",
                "Soybean burger",
                "Mushrooms",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(9, "Vegetarian Cheeseburger", 140, true, false, false, Domain.Enums.Categories.Vegetarian, new List<string>
            {
                "Gluten free bun with seeds",
                "Soybean burger",
                "Mushrooms",
                "Melted cheddar cheese",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(10, "Vegetarian Eggburger", 150, true, false, false, Domain.Enums.Categories.Vegetarian, new List<string>
            {
                "Gluten free bun with seeds",
                "Soybean burger",
                "Mushrooms",
                "Fried egg",
                "Vegetables(lettuce, tomato and pickle)",
                "Sauces"
            }),
            new Burger(11, "Vegan Burger", 120, true, true, false, Domain.Enums.Categories.Vegan, new List<string>
            {
                "Gluten free bun with seeds",
                "Soybean burger",
                "Mushrooms",
                "Vegetables(lettuce, tomato and pickle)",
                "Vegan sauces"
            }),
            new Burger(12, "Vegan Cheeseburger", 150, true, true, false, Domain.Enums.Categories.Vegan, new List<string>
            {
                "Gluten free bun with seeds",
                "Soybean burger",
                "Tofu cheese",
                "Mushrooms",
                "Vegetables(lettuce, tomato and pickle)",
                "Vegan sauces"
            })
        };      
    }
}