using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class descrioptandattachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "vehicleDescription",
                table: "VehicleInformation",
                type: "NVARCHAR(900)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gdDescription",
                table: "GDInformation",
                type: "NVARCHAR(900)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fileSubject",
                table: "AttachmentInformation",
                type: "NVARCHAR(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vehicleDescription",
                table: "VehicleInformation");

            migrationBuilder.DropColumn(
                name: "gdDescription",
                table: "GDInformation");

            migrationBuilder.DropColumn(
                name: "fileSubject",
                table: "AttachmentInformation");
        }
    }
}
