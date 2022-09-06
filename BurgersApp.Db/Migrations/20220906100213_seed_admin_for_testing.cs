using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgersApp.Db.Migrations
{
    public partial class seed_admin_for_testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropColumn(
                name: "AdminCredentials",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AuthorizationCode",
                table: "Admins");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminCredentials",
                table: "Admins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AuthorizationCode",
                table: "Admins",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    AdminsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => new { x.AdminsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_AdminRole_Admins_AdminsId",
                        column: x => x.AdminsId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminRole_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdminCredentials", "AuthorizationCode" },
                values: new object[] { "AdminJohn", "123456789101112" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Administrator" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "User" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminRole_RolesId",
                table: "AdminRole",
                column: "RolesId");
        }
    }
}
