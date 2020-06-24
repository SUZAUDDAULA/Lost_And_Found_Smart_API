using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class Intheeyeadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "otherIdentityfyMark",
                table: "PhysicalDescriptions",
                type: "NVARCHAR(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "visibleTatto",
                table: "PhysicalDescriptions",
                type: "NVARCHAR(200)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InTheEyes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    name = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    nameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InTheEyes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InTheEyes");

            migrationBuilder.DropColumn(
                name: "otherIdentityfyMark",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "visibleTatto",
                table: "PhysicalDescriptions");
        }
    }
}
