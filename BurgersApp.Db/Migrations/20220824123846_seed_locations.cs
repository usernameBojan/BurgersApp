using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgersApp.Db.Migrations
{
    public partial class seed_locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OpensAt",
                table: "Locations",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClosesAt",
                table: "Locations",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "BurgerQuantityForOrder", "Category", "HasFries", "ImgSrc", "Ingredients", "IsVegan", "IsVegetarian", "Name", "OrderId", "Price" },
                values: new object[] { 13, 0, 0, false, "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg", "test", false, false, "forcrudtesting", null, 9999 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "OpensAt",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "ClosesAt",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);
        }
    }
}