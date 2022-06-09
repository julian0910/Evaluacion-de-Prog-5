using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Valoracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movie",
                newName: "Valoracion");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movie",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "Marca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valoracion",
                table: "Movie",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Movie",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Movie",
                newName: "Genre");
        }
    }
}
