using BurgersApp.Domain.Models;

namespace BurgersApp.Db
{
    public static class IntDb
    {
        public static string genericName = "PseudoBurgers";

        public static List<Location> Locations = new List<Location>
        {
            new Location(1, $"{genericName} Tetovo", "Boulevard Ilirija 9999, Tetovo", "09:00", "23:00"),
            new Location(2, $"{genericName} Gjorche Petrov", "Gjorche Petrov 9999, Gjorche Petrov, Skopje", "10:00", "22:00"),
            new Location(3, $"{genericName} Center", "Boulevard Partizanski Odredi 9999, Center, Skopje", "08:00", "00:00"),
            new Location(4, $"{genericName} Aerodrom", "Boulevard Jane Sandanski 9999, Aerodrom, Skopje", "09:00", "00:00"),
            new Location(5, $"{genericName} Ohrid", "Boulevard Turistichka 9999, Ohrid", "08:00", "00:00"),
        };
        public static IList<Order> Orders { get; set; } = new List<Order>
        {

        };

        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger(1, "Hamburger", 120, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Beef burger, Chicken ham slice, Vegetables(lettuce, tomato and pickle, Sauces",
                "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2022%2F03%2F11%2F49404-Juiciest-Hamburgers-Ever-mfs-052.jpg"),
            new Burger(2, "Cheeseburger", 140, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Beef burger, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://cdn.hswstatic.com/gif/cheeseburger-1.jpg"),
            new Burger(3, "Baconburger", 130, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Beef burger, Bacon, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://images-gmi-pmc.edge-generalmills.com/35268f51-42c0-40ec-9ce2-5ec8f689ebad.jpg"),
            new Burger(4, "Eggburger", 150, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Beef burger, Chicken ham slice, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://www.chatelaine.com/wp-content/uploads/2020/06/CHE07_WEB_FD_BURGERS_1280x960_STEAKANDEGG.jpg"),
            new Burger(5, "Crispy Chicken", 150, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Batter fried chicken fillet, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://thescranline.com/wp-content/uploads/2022/02/crispy-chicken-burger-WEB-01.jpg"),
            new Burger(6, "Chicken Sandwich", 120, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Chicken fillet, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://images-gmi-pmc.edge-generalmills.com/00556a9b-e367-47d6-8fa8-33d1de78ae65.jpg"),
            new Burger(7, "x2burger", 160, false, false, false, Domain.Enums.Categories.Regular,
                "Gluten free bun with seeds, Two beef burgers, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://c8.alamy.com/comp/D1WJRT/cut-out-of-double-hamburger-D1WJRT.jpg"),
            new Burger(8, "Vegetarian Burger", 120, true, false, false, Domain.Enums.Categories.Vegetarian,
                "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F19%2F2015%2F06%2F22%2Fclean-veggie-burgers-ck.jpg&q=60"),
            new Burger(9, "Vegetarian Cheeseburger", 140, true, false, false, Domain.Enums.Categories.Vegetarian,
                "Gluten free bun with seeds, Soybean burger, Mushrooms, Melted cheddar cheese, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F9%2F2021%2F07%2F13%2FUltimate-Veggie-Burgers-FT-Recipe-0821.jpg&q=60"),
            new Burger(10, "Vegetarian Eggburger", 150, true, false, false, Domain.Enums.Categories.Vegetarian,
                "Gluten free bun with seeds, Soybean burger, Mushrooms, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces",
                "https://images.ctfassets.net/lzukox2jf57a/2QwanILGms0aw04S4k4E6s/aa64ac85fe171a3ee616799b127fe366/optimized-fried_egg_burger-4.jpg?fm=jpg&fl=progressive&q=90&fit=crop&w=1679&h=1118"), 
            new Burger(11, "Vegan Burger", 120, true, true, false, Domain.Enums.Categories.Vegan,
                "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Vegan sauces",
                "https://www.myfoodandhappiness.com/wp-content/uploads/2017/08/The-Green-Warrior-Burger-2.jpg"),
            new Burger(12, "Vegan Cheeseburger", 150, true, true, false, Domain.Enums.Categories.Vegan,
                "Gluten free bun with seeds, Soybean burger, Mushrooms, Tofu cheese, Vegetables(lettuce, tomato and pickle), Vegan sauces",
                "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg"),
        };      
    }
}