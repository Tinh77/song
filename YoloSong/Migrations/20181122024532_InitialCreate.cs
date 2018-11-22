using Microsoft.EntityFrameworkCore.Migrations;

namespace YoloSong.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Singer",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Singer",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Categories");
        }
    }
}
