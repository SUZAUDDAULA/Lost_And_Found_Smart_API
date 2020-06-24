using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class adf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "village",
                table: "SpaceAndTimes",
                type: "NVARCHAR(200)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "inTheEyeColorId",
                table: "DressDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "inTheEyeId",
                table: "DressDescriptions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheEyeColorId",
                table: "DressDescriptions",
                column: "inTheEyeColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheEyeId",
                table: "DressDescriptions",
                column: "inTheEyeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DressDescriptions_Colors_inTheEyeColorId",
                table: "DressDescriptions",
                column: "inTheEyeColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DressDescriptions_InTheEyes_inTheEyeId",
                table: "DressDescriptions",
                column: "inTheEyeId",
                principalTable: "InTheEyes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DressDescriptions_Colors_inTheEyeColorId",
                table: "DressDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_DressDescriptions_InTheEyes_inTheEyeId",
                table: "DressDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_DressDescriptions_inTheEyeColorId",
                table: "DressDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_DressDescriptions_inTheEyeId",
                table: "DressDescriptions");

            migrationBuilder.DropColumn(
                name: "village",
                table: "SpaceAndTimes");

            migrationBuilder.DropColumn(
                name: "inTheEyeColorId",
                table: "DressDescriptions");

            migrationBuilder.DropColumn(
                name: "inTheEyeId",
                table: "DressDescriptions");
        }
    }
}
