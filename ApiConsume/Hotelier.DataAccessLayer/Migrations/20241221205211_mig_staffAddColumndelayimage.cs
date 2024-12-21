using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelier.DataAccessLayer.Migrations
{
    public partial class mig_staffAddColumndelayimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Delay",
                table: "Staff",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Staff",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delay",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Staff");
        }
    }
}
