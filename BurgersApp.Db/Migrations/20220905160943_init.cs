using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgersApp.Db.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    OpensAt = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ClosesAt = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    BurgersInOrder = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", maxLength: 128, nullable: false),
                    TotalPrice = table.Column<int>(type: "int", maxLength: 64, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ImgSrc = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Price = table.Column<int>(type: "int", maxLength: 512, nullable: false),
                    BurgerQuantityForOrder = table.Column<int>(type: "int", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    HasFries = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<int>(type: "int", maxLength: 512, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Burgers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "BurgerQuantityForOrder", "Category", "HasFries", "ImgSrc", "Ingredients", "IsVegan", "IsVegetarian", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, 0, 0, false, "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2022%2F03%2F11%2F49404-Juiciest-Hamburgers-Ever-mfs-052.jpg", "Gluten free bun with seeds, Beef burger, Chicken ham slice, Vegetables(lettuce, tomato and pickle, Sauces", false, false, "Hamburger", null, 120 },
                    { 2, 0, 0, false, "https://cdn.hswstatic.com/gif/cheeseburger-1.jpg", "Gluten free bun with seeds, Beef burger, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "Cheeseburger", null, 140 },
                    { 3, 0, 0, false, "https://images-gmi-pmc.edge-generalmills.com/35268f51-42c0-40ec-9ce2-5ec8f689ebad.jpg", "Gluten free bun with seeds, Beef burger, Bacon, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "Baconburger", null, 130 },
                    { 4, 0, 0, false, "https://www.chatelaine.com/wp-content/uploads/2020/06/CHE07_WEB_FD_BURGERS_1280x960_STEAKANDEGG.jpg", "Gluten free bun with seeds, Beef burger, Chicken ham slice, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "Eggburger", null, 150 },
                    { 5, 0, 0, false, "https://thescranline.com/wp-content/uploads/2022/02/crispy-chicken-burger-WEB-01.jpg", "Gluten free bun with seeds, Batter fried chicken fillet, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "Crispy Chicken", null, 150 },
                    { 6, 0, 0, false, "https://images-gmi-pmc.edge-generalmills.com/00556a9b-e367-47d6-8fa8-33d1de78ae65.jpg", "Gluten free bun with seeds, Chicken fillet, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "Chicken Sandwich", null, 120 },
                    { 7, 0, 0, false, "https://c8.alamy.com/comp/D1WJRT/cut-out-of-double-hamburger-D1WJRT.jpg", "Gluten free bun with seeds, Two beef burgers, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces", false, false, "x2burger", null, 160 },
                    { 8, 0, 1, false, "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F19%2F2015%2F06%2F22%2Fclean-veggie-burgers-ck.jpg&q=60", "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Sauces", false, true, "Vegetarian Burger", null, 120 },
                    { 9, 0, 1, false, "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F9%2F2021%2F07%2F13%2FUltimate-Veggie-Burgers-FT-Recipe-0821.jpg&q=60", "Gluten free bun with seeds, Soybean burger, Mushrooms, Melted cheddar cheese, Vegetables(lettuce, tomato and pickle), Sauces", false, true, "Vegetarian Cheeseburger", null, 140 },
                    { 10, 0, 1, false, "https://images.ctfassets.net/lzukox2jf57a/2QwanILGms0aw04S4k4E6s/aa64ac85fe171a3ee616799b127fe366/optimized-fried_egg_burger-4.jpg?fm=jpg&fl=progressive&q=90&fit=crop&w=1679&h=1118", "Gluten free bun with seeds, Soybean burger, Mushrooms, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces", false, true, "Vegetarian Eggburger", null, 150 },
                    { 11, 0, 2, false, "https://www.myfoodandhappiness.com/wp-content/uploads/2017/08/The-Green-Warrior-Burger-2.jpg", "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Vegan sauces", true, true, "Vegan Burger", null, 120 },
                    { 12, 0, 2, false, "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg", "Gluten free bun with seeds, Soybean burger, Mushrooms, Tofu cheese, Vegetables(lettuce, tomato and pickle), Vegan sauces", true, true, "Vegan Cheeseburger", null, 150 },
                    { 13, 0, 0, false, "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg", "test", false, false, "forcrudtesting", null, 9999 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "ClosesAt", "Name", "OpensAt" },
                values: new object[,]
                {
                    { 1, "Boulevard Ilirija 9999, Tetovo", "23:00", "PseudoBurgers Tetovo", "09:00" },
                    { 2, "Gjorche Petrov 9999, Gjorche Petrov, Skopje", "22:00", "PseudoBurgers Gjorche Petrov", "10:00" },
                    { 3, "Boulevard Partizanski Odredi 9999, Center, Skopje", "00:00", "PseudoBurgers Center", "08:00" },
                    { 4, "Boulevard Jane Sandanski 9999, Aerodrom, Skopje", "00:00", "PseudoBurgers Aerodrom", "09:00" },
                    { 5, "Boulevard Turistichka 9999, Ohrid", "00:00", "PseudoBurgers Ohrid", "08:00" },
                    { 6, "ForCRUDTesting", "test", "ForCRUDTesting", "test" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Burgers_OrderId",
                table: "Burgers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LocationId",
                table: "Orders",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
