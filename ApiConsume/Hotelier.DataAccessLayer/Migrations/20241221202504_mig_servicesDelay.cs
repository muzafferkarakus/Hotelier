using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelier.DataAccessLayer.Migrations
{
    public partial class mig_servicesDelay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Delay",
                table: "Services",
                type: "nvarchar(4)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delay",
                table: "Services");
        }
    }
}
