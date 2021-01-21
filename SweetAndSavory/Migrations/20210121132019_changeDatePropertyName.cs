using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetAndSavory.Migrations
{
    public partial class changeDatePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Treats",
                newName: "DateAdded");

            migrationBuilder.RenameColumn(
                name: "InstallDate",
                table: "Flavors",
                newName: "DateAdded");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "Treats",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "Flavors",
                newName: "InstallDate");
        }
    }
}
