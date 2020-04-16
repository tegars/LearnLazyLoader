using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnLazyLoader.Migrations
{
    public partial class alterCategoryTableAddCatatanColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Catatan",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Catatan",
                table: "Categories");
        }
    }
}
