using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class SpecialBirthMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hairTypeId",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "heightFeet",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "heightInch",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specialBirthMarkTypeId",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "weight",
                table: "PhysicalDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "descriptionCircumcisionId",
                table: "IndentifyInfos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpecialBirthMarkBodyPartPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    typeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    typeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialBirthMarkBodyPartPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialBirthMarkBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    bodyName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    bodyNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialBirthMarkBodyParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialBirthMarkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    typeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    typeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialBirthMarkTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_hairTypeId",
                table: "PhysicalDescriptions",
                column: "hairTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkBodyPartId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkBodyPartPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkTypeId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalDescriptions_HairTypes_hairTypeId",
                table: "PhysicalDescriptions",
                column: "hairTypeId",
                principalTable: "HairTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkBodyParts_specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkBodyPartId",
                principalTable: "SpecialBirthMarkBodyParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkBodyPartPositions_specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkBodyPartPositionId",
                principalTable: "SpecialBirthMarkBodyPartPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkTypes_specialBirthMarkTypeId",
                table: "PhysicalDescriptions",
                column: "specialBirthMarkTypeId",
                principalTable: "SpecialBirthMarkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalDescriptions_HairTypes_hairTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkBodyParts_specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkBodyPartPositions_specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalDescriptions_SpecialBirthMarkTypes_specialBirthMarkTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropTable(
                name: "SpecialBirthMarkBodyPartPositions");

            migrationBuilder.DropTable(
                name: "SpecialBirthMarkBodyParts");

            migrationBuilder.DropTable(
                name: "SpecialBirthMarkTypes");

            migrationBuilder.DropIndex(
                name: "IX_PhysicalDescriptions_hairTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_PhysicalDescriptions_specialBirthMarkTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "hairTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "heightFeet",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "heightInch",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "specialBirthMarkBodyPartId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "specialBirthMarkBodyPartPositionId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "specialBirthMarkTypeId",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "PhysicalDescriptions");

            migrationBuilder.DropColumn(
                name: "descriptionCircumcisionId",
                table: "IndentifyInfos");
        }
    }
}
