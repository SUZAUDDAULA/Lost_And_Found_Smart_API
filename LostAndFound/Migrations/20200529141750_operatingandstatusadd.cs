using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class operatingandstatusadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "battery",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "macAddress",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "operatingSystemTypeId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ram",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rom",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "screenSize",
                table: "OtherDocumentDetails",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OperatingSystemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    deviceType = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    typeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    typeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    statusName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    statusNameBn = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusInfos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_operatingSystemTypeId",
                table: "OtherDocumentDetails",
                column: "operatingSystemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_OperatingSystemTypes_operatingSystemTypeId",
                table: "OtherDocumentDetails",
                column: "operatingSystemTypeId",
                principalTable: "OperatingSystemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_OperatingSystemTypes_operatingSystemTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropTable(
                name: "OperatingSystemTypes");

            migrationBuilder.DropTable(
                name: "StatusInfos");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_operatingSystemTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "battery",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "macAddress",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "operatingSystemTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "ram",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "rom",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "screenSize",
                table: "OtherDocumentDetails");
        }
    }
}
