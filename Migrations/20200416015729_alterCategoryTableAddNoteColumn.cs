using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnLazyLoader.Migrations
{
    public partial class alterCategoryTableAddNoteColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Categories");
        }
    }
}
