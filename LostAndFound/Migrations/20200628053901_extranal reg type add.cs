using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class extranalregtypeadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userFrom",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userFrom",
                table: "AspNetUsers");
        }
    }
}
