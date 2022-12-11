using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Molnar_Lorand_Lab2.Migrations
{
    public partial class AddCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityId",
                table: "Customer",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_City_CityId",
                table: "Customer",
                column: "CityId",
                principalTable: "City",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_City_CityId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CityId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Customer");
        }
    }
}
