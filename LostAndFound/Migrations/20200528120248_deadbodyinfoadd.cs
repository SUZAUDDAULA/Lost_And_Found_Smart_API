using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class deadbodyinfoadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dateOfDeath",
                table: "ManInformation",
                type: "NVARCHAR(50)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "deadbodyConditionId",
                table: "ManInformation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_deadbodyConditionId",
                table: "ManInformation",
                column: "deadbodyConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManInformation_DeadbodyConditions_deadbodyConditionId",
                table: "ManInformation",
                column: "deadbodyConditionId",
                principalTable: "DeadbodyConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManInformation_DeadbodyConditions_deadbodyConditionId",
                table: "ManInformation");

            migrationBuilder.DropIndex(
                name: "IX_ManInformation_deadbodyConditionId",
                table: "ManInformation");

            migrationBuilder.DropColumn(
                name: "dateOfDeath",
                table: "ManInformation");

            migrationBuilder.DropColumn(
                name: "deadbodyConditionId",
                table: "ManInformation");
        }
    }
}
