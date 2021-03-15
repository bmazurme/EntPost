using Microsoft.EntityFrameworkCore.Migrations;

namespace EntPost.Migrations.Post
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "Note");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Note",
                type: "TEXT",
                nullable: true);
        }
    }
}
