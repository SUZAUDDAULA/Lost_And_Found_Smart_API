using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    name = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressSourceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    sourceName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    sourceNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressSourceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgePeriods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    periodName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    periodNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgePeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    animalName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    animalNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(420)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    attachmentTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    attachmentTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeardTypes",
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
                    table.PrimaryKey("PK_BeardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyChinTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    chinTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    chinTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyChinTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    colorName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    colorNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    colorCode = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyStructures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    structureName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    structureNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStructures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareTypes",
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
                    table.PrimaryKey("PK_CareTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    colorName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    colorNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    colorCode = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complextions",
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
                    colorCode = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complextions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerAccessoriesBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    brandName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    brandNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerAccessoriesBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    countryCode = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    countryName = table.Column<string>(type: "NVARCHAR(120)", nullable: false),
                    countryNameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeadbodyConditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    conditionName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    conditionNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeadbodyConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathTypes",
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
                    table.PrimaryKey("PK_DeathTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    documentFor = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    documentTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    documentTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EarTypes",
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
                    table.PrimaryKey("PK_EarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicsTypes",
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
                    table.PrimaryKey("PK_ElectronicsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EyeTypes",
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
                    table.PrimaryKey("PK_EyeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaceShapeTypes",
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
                    table.PrimaryKey("PK_FaceShapeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileDocumentTypes",
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
                    table.PrimaryKey("PK_FileDocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForeHeadTypes",
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
                    table.PrimaryKey("PK_ForeHeadTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GDTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gdTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    gdTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GDTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    genderName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    genderNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    habitName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    habitNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HairTypes",
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
                    table.PrimaryKey("PK_HairTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadTypes",
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
                    table.PrimaryKey("PK_HeadTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InTheBodies",
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
                    table.PrimaryKey("PK_InTheBodies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InTheHeads",
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
                    table.PrimaryKey("PK_InTheHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InTheLegs",
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
                    table.PrimaryKey("PK_InTheLegs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InTheThroats",
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
                    table.PrimaryKey("PK_InTheThroats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InTheWaists",
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
                    table.PrimaryKey("PK_InTheWaists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LAFModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    moduleName = table.Column<string>(maxLength: 150, nullable: true),
                    moduleNameBN = table.Column<string>(maxLength: 150, nullable: true),
                    shortOrder = table.Column<int>(nullable: true),
                    isTeam = table.Column<string>(maxLength: 150, nullable: true),
                    imageClass = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LAFModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LostAndFoundTypes",
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
                    table.PrimaryKey("PK_LostAndFoundTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    sender = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    recipient = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    mailType = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    subject = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    sendTime = table.Column<DateTime>(nullable: true),
                    refNo = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    notSendReason = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    isSuccess = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    partName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    partNameBN = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManBodyParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
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
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementTypes",
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
                    table.PrimaryKey("PK_MeasurementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterialConditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    conditionName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    conditionNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterialConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetropolitanAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    areaName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    areaNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    districtId = table.Column<int>(nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetropolitanAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhoneTypes",
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
                    table.PrimaryKey("PK_MobilePhoneTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoustacheTypes",
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
                    table.PrimaryKey("PK_MoustacheTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MouthTypes",
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
                    table.PrimaryKey("PK_MouthTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalIdentityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    nationalIdentityName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    nationalIdentityNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalIdentityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NeckTypes",
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
                    table.PrimaryKey("PK_NeckTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoseTypes",
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
                    table.PrimaryKey("PK_NoseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberTypes",
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
                    table.PrimaryKey("PK_NumberTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    name = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    nameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(420)", nullable: true),
                    shortOrder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    brandName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    brandNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    brandFor = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    productTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    productTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurposeOfVisites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    purposeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    purposeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurposeOfVisites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    levelName = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    levelNameBn = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    relationName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    relationNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    religionName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    religionNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialBodyConditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    conditionName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    conditionNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialBodyConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speeches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    speechName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    speechNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speeches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeethTypes",
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
                    table.PrimaryKey("PK_TeethTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    userId = table.Column<string>(maxLength: 250, nullable: true),
                    logTime = table.Column<DateTime>(maxLength: 250, nullable: false),
                    status = table.Column<int>(nullable: true),
                    ipAddress = table.Column<string>(maxLength: 250, nullable: true),
                    browserName = table.Column<string>(maxLength: 250, nullable: true),
                    pcName = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    userTypeName = table.Column<string>(nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    vehicleTypeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    vehicleTypeNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    divisionCode = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    divisionName = table.Column<string>(type: "NVARCHAR(120)", nullable: false),
                    divisionNameBn = table.Column<string>(nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    countryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    documentTypeId = table.Column<int>(nullable: true),
                    categoryName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    categoryNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentCategories_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleAccessPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    inventoryModuleId = table.Column<int>(nullable: true),
                    eRPModuleId = table.Column<int>(nullable: true),
                    applicationRoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleAccessPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleAccessPages_AspNetRoles_applicationRoleId",
                        column: x => x.applicationRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModuleAccessPages_LAFModules_eRPModuleId",
                        column: x => x.eRPModuleId,
                        principalTable: "LAFModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Navbars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    nameOptionBangla = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    nameOption = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    controller = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    action = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    area = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    imageClass = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    activeLi = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    status = table.Column<bool>(nullable: false),
                    parentID = table.Column<int>(nullable: false),
                    isParent = table.Column<int>(nullable: true),
                    displayOrder = table.Column<int>(nullable: true),
                    moduleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navbars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Navbars_LAFModules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "LAFModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReligionCusts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    religionId = table.Column<int>(nullable: true),
                    custName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    custNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligionCusts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReligionCusts_Religions_religionId",
                        column: x => x.religionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    userTypeId = table.Column<int>(nullable: true),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    Citizenship = table.Column<string>(maxLength: 50, nullable: true),
                    NationalIdentityType = table.Column<int>(nullable: true),
                    NationalIdentityNo = table.Column<string>(maxLength: 100, nullable: true),
                    AddressType = table.Column<int>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 300, nullable: true),
                    otpCode = table.Column<string>(nullable: true),
                    isVarified = table.Column<int>(nullable: true),
                    isActive = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 120, nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    updatedBy = table.Column<string>(maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_UserTypes_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    vehicleTypeId = table.Column<int>(nullable: true),
                    modelName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    modelNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleTypes_vehicleTypeId",
                        column: x => x.vehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    districtCode = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    districtName = table.Column<string>(type: "NVARCHAR(120)", nullable: false),
                    districtNameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    divisionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentCategoryAccessories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    documentTypeId = table.Column<int>(nullable: true),
                    documentCategoryId = table.Column<int>(nullable: true),
                    accessoriesName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    accessoriesNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategoryAccessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentCategoryAccessories_DocumentCategories_documentCategoryId",
                        column: x => x.documentCategoryId,
                        principalTable: "DocumentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentCategoryAccessories_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentCategoryBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    documentTypeId = table.Column<int>(nullable: true),
                    documentCategoryId = table.Column<int>(nullable: true),
                    brandName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    brandNameBn = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    imagePath = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategoryBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentCategoryBrands_DocumentCategories_documentCategoryId",
                        column: x => x.documentCategoryId,
                        principalTable: "DocumentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentCategoryBrands_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAccessPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    navbarId = table.Column<int>(nullable: true),
                    isAccess = table.Column<int>(nullable: true),
                    applicationRoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccessPages_AspNetRoles_applicationRoleId",
                        column: x => x.applicationRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAccessPages_Navbars_navbarId",
                        column: x => x.navbarId,
                        principalTable: "Navbars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GDInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    gdFor = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    gdDate = table.Column<DateTime>(nullable: true),
                    gdNumber = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    productTypeId = table.Column<int>(nullable: true),
                    gDTypeId = table.Column<int>(nullable: true),
                    documentTypeId = table.Column<int>(nullable: true),
                    documentDescription = table.Column<string>(type: "NVARCHAR(500)", nullable: true),
                    statusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GDInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GDInformation_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GDInformation_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GDInformation_GDTypes_gDTypeId",
                        column: x => x.gDTypeId,
                        principalTable: "GDTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GDInformation_ProductTypes_productTypeId",
                        column: x => x.productTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostOffices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    districtId = table.Column<int>(nullable: false),
                    postalCode = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    postalName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    postalShortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    postalNameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostOffices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostOffices_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thanas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    thanaCode = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    thanaName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    thanaNameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    districtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thanas_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    attachmentTypeId = table.Column<int>(nullable: true),
                    masterId = table.Column<int>(nullable: true),
                    fileName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    fileType = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    filePath = table.Column<string>(type: "NVARCHAR(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachmentInformation_AttachmentTypes_attachmentTypeId",
                        column: x => x.attachmentTypeId,
                        principalTable: "AttachmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachmentInformation_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndentifyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    colorsId = table.Column<int>(nullable: true),
                    identifySign = table.Column<string>(type: "NVARCHAR(450)", nullable: true),
                    identifyType = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    religionId = table.Column<int>(nullable: true),
                    bloodGroup = table.Column<string>(type: "NVARCHAR(5)", nullable: true),
                    occupationId = table.Column<int>(nullable: true),
                    maritalStatusId = table.Column<int>(nullable: true),
                    attachmentPath = table.Column<string>(type: "NVARCHAR(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndentifyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndentifyInfos_Colors_colorsId",
                        column: x => x.colorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndentifyInfos_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndentifyInfos_MaritalStatuses_maritalStatusId",
                        column: x => x.maritalStatusId,
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndentifyInfos_Occupations_occupationId",
                        column: x => x.occupationId,
                        principalTable: "Occupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndentifyInfos_Religions_religionId",
                        column: x => x.religionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    relationTypeId = table.Column<int>(nullable: true),
                    name = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    aproxAge = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    agePeriodId = table.Column<int>(nullable: true),
                    genderId = table.Column<int>(nullable: true),
                    isHealthDisabled = table.Column<int>(nullable: true),
                    fatherName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    motherName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    spouseName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    nationalIdentityTypeId = table.Column<int>(nullable: true),
                    identityNo = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    numberTypeId = table.Column<int>(nullable: true),
                    number = table.Column<string>(type: "NVARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManInformation_AgePeriods_agePeriodId",
                        column: x => x.agePeriodId,
                        principalTable: "AgePeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManInformation_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManInformation_Genders_genderId",
                        column: x => x.genderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManInformation_NationalIdentityTypes_nationalIdentityTypeId",
                        column: x => x.nationalIdentityTypeId,
                        principalTable: "NationalIdentityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManInformation_NumberTypes_numberTypeId",
                        column: x => x.numberTypeId,
                        principalTable: "NumberTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManInformation_RelationTypes_relationTypeId",
                        column: x => x.relationTypeId,
                        principalTable: "RelationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherDocumentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    documentTypeId = table.Column<int>(nullable: true),
                    typeName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    modelName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    brandName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    bodyType = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    color = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    structureType = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    identificationMark = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    quantity = table.Column<decimal>(nullable: true),
                    price = table.Column<decimal>(nullable: true),
                    description = table.Column<string>(type: "NVARCHAR(350)", nullable: true),
                    attachment = table.Column<string>(type: "NVARCHAR(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherDocumentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherDocumentDetails_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherDocumentDetails_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherPersonInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    nationalIdentityTypeId = table.Column<int>(nullable: true),
                    identityNo = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    mobileNo = table.Column<string>(type: "NVARCHAR(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPersonInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherPersonInformation_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherPersonInformation_NationalIdentityTypes_nationalIdentityTypeId",
                        column: x => x.nationalIdentityTypeId,
                        principalTable: "NationalIdentityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: false),
                    vehicleTypeId = table.Column<int>(nullable: true),
                    vehicleBrandId = table.Column<int>(nullable: true),
                    vehicleRegNo = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    regNoFirstPart = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    regNoSecondPart = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    regNoThiredPart = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    madeBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    madeIn = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    modelNo = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    mfcDate = table.Column<DateTime>(nullable: true),
                    engineNo = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    chasisNo = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    ccNo = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    vehicleModelNo = table.Column<string>(type: "NVARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleInformation_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleInformation_VehicleModels_vehicleBrandId",
                        column: x => x.vehicleBrandId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleInformation_VehicleTypes_vehicleTypeId",
                        column: x => x.vehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpaceAndTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    gDInformationId = table.Column<int>(nullable: true),
                    divisionId = table.Column<int>(nullable: true),
                    districtId = table.Column<int>(nullable: true),
                    thanaId = table.Column<int>(nullable: true),
                    postOfficeId = table.Column<int>(nullable: true),
                    placeDetails = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    lafDate = table.Column<DateTime>(nullable: true),
                    lafTime = table.Column<string>(type: "NVARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceAndTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpaceAndTimes_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpaceAndTimes_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpaceAndTimes_GDInformation_gDInformationId",
                        column: x => x.gDInformationId,
                        principalTable: "GDInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpaceAndTimes_PostOffices_postOfficeId",
                        column: x => x.postOfficeId,
                        principalTable: "PostOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpaceAndTimes_Thanas_thanaId",
                        column: x => x.thanaId,
                        principalTable: "Thanas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    indentifyId = table.Column<int>(nullable: true),
                    masterId = table.Column<int>(nullable: true),
                    fileName = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    fileType = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    filePath = table.Column<string>(type: "NVARCHAR(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentificationAttachments_IndentifyInfos_indentifyId",
                        column: x => x.indentifyId,
                        principalTable: "IndentifyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    manInformationId = table.Column<int>(nullable: true),
                    countryId = table.Column<int>(nullable: true),
                    divisionId = table.Column<int>(nullable: true),
                    districtId = table.Column<int>(nullable: true),
                    thanaId = table.Column<int>(nullable: true),
                    union = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    postOffice = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    postCode = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    blockSector = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    houseVillage = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    roadNumber = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    addressDetails = table.Column<string>(type: "NVARCHAR(250)", nullable: true),
                    oneLineAddress = table.Column<string>(type: "NVARCHAR(200)", nullable: true),
                    type = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressInformation_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressInformation_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressInformation_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressInformation_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressInformation_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressInformation_Thanas_thanaId",
                        column: x => x.thanaId,
                        principalTable: "Thanas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DNAProfileDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    manInformationId = table.Column<int>(nullable: false),
                    locous = table.Column<string>(nullable: true),
                    genotype1 = table.Column<string>(nullable: true),
                    genotype2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DNAProfileDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DNAProfileDetails_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DressDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    manInformationId = table.Column<int>(nullable: true),
                    inTheBodyId = table.Column<int>(nullable: true),
                    inTheBodyColorId = table.Column<int>(nullable: true),
                    inTheHeadId = table.Column<int>(nullable: true),
                    inTheHeadColorId = table.Column<int>(nullable: true),
                    inTheLegsId = table.Column<int>(nullable: true),
                    inTheLegsColorId = table.Column<int>(nullable: true),
                    inTheThroatId = table.Column<int>(nullable: true),
                    inTheThroatColorId = table.Column<int>(nullable: true),
                    inTheWaistId = table.Column<int>(nullable: true),
                    inTheWaistColorId = table.Column<int>(nullable: true),
                    shoesSize = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    shoesSizeType = table.Column<string>(type: "NVARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_Colors_inTheBodyColorId",
                        column: x => x.inTheBodyColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_InTheBodies_inTheBodyId",
                        column: x => x.inTheBodyId,
                        principalTable: "InTheBodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_Colors_inTheHeadColorId",
                        column: x => x.inTheHeadColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_InTheHeads_inTheHeadId",
                        column: x => x.inTheHeadId,
                        principalTable: "InTheHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_Colors_inTheLegsColorId",
                        column: x => x.inTheLegsColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_InTheLegs_inTheLegsId",
                        column: x => x.inTheLegsId,
                        principalTable: "InTheLegs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_Colors_inTheThroatColorId",
                        column: x => x.inTheThroatColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_InTheThroats_inTheThroatId",
                        column: x => x.inTheThroatId,
                        principalTable: "InTheThroats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_Colors_inTheWaistColorId",
                        column: x => x.inTheWaistColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_InTheWaists_inTheWaistId",
                        column: x => x.inTheWaistId,
                        principalTable: "InTheWaists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressDescriptions_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManHabitDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    manInformationId = table.Column<int>(nullable: true),
                    habitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManHabitDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManHabitDetails_Habits_habitId",
                        column: x => x.habitId,
                        principalTable: "Habits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManHabitDetails_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManSpeechDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    manInformationId = table.Column<int>(nullable: true),
                    speechId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManSpeechDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManSpeechDetails_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManSpeechDetails_Speeches_speechId",
                        column: x => x.speechId,
                        principalTable: "Speeches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    manInformationId = table.Column<int>(nullable: true),
                    beardTypeId = table.Column<int>(nullable: true),
                    bodyChinTypeId = table.Column<int>(nullable: true),
                    bodyColorId = table.Column<int>(nullable: true),
                    bodyStructureId = table.Column<int>(nullable: true),
                    earTypeId = table.Column<int>(nullable: true),
                    eyeTypeId = table.Column<int>(nullable: true),
                    faceShapeTypeId = table.Column<int>(nullable: true),
                    foreHeadTypeId = table.Column<int>(nullable: true),
                    headTypeId = table.Column<int>(nullable: true),
                    moustacheTypeId = table.Column<int>(nullable: true),
                    mouthTypeId = table.Column<int>(nullable: true),
                    neckTypeId = table.Column<int>(nullable: true),
                    noseTypeId = table.Column<int>(nullable: true),
                    specialBodyConditionId = table.Column<int>(nullable: true),
                    teethTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_BeardTypes_beardTypeId",
                        column: x => x.beardTypeId,
                        principalTable: "BeardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_BodyChinTypes_bodyChinTypeId",
                        column: x => x.bodyChinTypeId,
                        principalTable: "BodyChinTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_BodyColors_bodyColorId",
                        column: x => x.bodyColorId,
                        principalTable: "BodyColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_BodyStructures_bodyStructureId",
                        column: x => x.bodyStructureId,
                        principalTable: "BodyStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_EarTypes_earTypeId",
                        column: x => x.earTypeId,
                        principalTable: "EarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_EyeTypes_eyeTypeId",
                        column: x => x.eyeTypeId,
                        principalTable: "EyeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_FaceShapeTypes_faceShapeTypeId",
                        column: x => x.faceShapeTypeId,
                        principalTable: "FaceShapeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_ForeHeadTypes_foreHeadTypeId",
                        column: x => x.foreHeadTypeId,
                        principalTable: "ForeHeadTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_HeadTypes_headTypeId",
                        column: x => x.headTypeId,
                        principalTable: "HeadTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_ManInformation_manInformationId",
                        column: x => x.manInformationId,
                        principalTable: "ManInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_MoustacheTypes_moustacheTypeId",
                        column: x => x.moustacheTypeId,
                        principalTable: "MoustacheTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_MouthTypes_mouthTypeId",
                        column: x => x.mouthTypeId,
                        principalTable: "MouthTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_NeckTypes_neckTypeId",
                        column: x => x.neckTypeId,
                        principalTable: "NeckTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_NoseTypes_noseTypeId",
                        column: x => x.noseTypeId,
                        principalTable: "NoseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_SpecialBodyConditions_specialBodyConditionId",
                        column: x => x.specialBodyConditionId,
                        principalTable: "SpecialBodyConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalDescriptions_TeethTypes_teethTypeId",
                        column: x => x.teethTypeId,
                        principalTable: "TeethTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_ApplicationUserId",
                table: "AddressInformation",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_countryId",
                table: "AddressInformation",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_districtId",
                table: "AddressInformation",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_divisionId",
                table: "AddressInformation",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_manInformationId",
                table: "AddressInformation",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_thanaId",
                table: "AddressInformation",
                column: "thanaId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_userTypeId",
                table: "AspNetUsers",
                column: "userTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentInformation_attachmentTypeId",
                table: "AttachmentInformation",
                column: "attachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentInformation_gDInformationId",
                table: "AttachmentInformation",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_divisionId",
                table: "Districts",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_countryId",
                table: "Divisions",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_DNAProfileDetails_manInformationId",
                table: "DNAProfileDetails",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategories_documentTypeId",
                table: "DocumentCategories",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategoryAccessories_documentCategoryId",
                table: "DocumentCategoryAccessories",
                column: "documentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategoryAccessories_documentTypeId",
                table: "DocumentCategoryAccessories",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategoryBrands_documentCategoryId",
                table: "DocumentCategoryBrands",
                column: "documentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategoryBrands_documentTypeId",
                table: "DocumentCategoryBrands",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheBodyColorId",
                table: "DressDescriptions",
                column: "inTheBodyColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheBodyId",
                table: "DressDescriptions",
                column: "inTheBodyId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheHeadColorId",
                table: "DressDescriptions",
                column: "inTheHeadColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheHeadId",
                table: "DressDescriptions",
                column: "inTheHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheLegsColorId",
                table: "DressDescriptions",
                column: "inTheLegsColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheLegsId",
                table: "DressDescriptions",
                column: "inTheLegsId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheThroatColorId",
                table: "DressDescriptions",
                column: "inTheThroatColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheThroatId",
                table: "DressDescriptions",
                column: "inTheThroatId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheWaistColorId",
                table: "DressDescriptions",
                column: "inTheWaistColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_inTheWaistId",
                table: "DressDescriptions",
                column: "inTheWaistId");

            migrationBuilder.CreateIndex(
                name: "IX_DressDescriptions_manInformationId",
                table: "DressDescriptions",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_GDInformation_ApplicationUserId",
                table: "GDInformation",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GDInformation_documentTypeId",
                table: "GDInformation",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GDInformation_gDTypeId",
                table: "GDInformation",
                column: "gDTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GDInformation_productTypeId",
                table: "GDInformation",
                column: "productTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationAttachments_indentifyId",
                table: "IdentificationAttachments",
                column: "indentifyId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentifyInfos_colorsId",
                table: "IndentifyInfos",
                column: "colorsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentifyInfos_gDInformationId",
                table: "IndentifyInfos",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentifyInfos_maritalStatusId",
                table: "IndentifyInfos",
                column: "maritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentifyInfos_occupationId",
                table: "IndentifyInfos",
                column: "occupationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentifyInfos_religionId",
                table: "IndentifyInfos",
                column: "religionId");

            migrationBuilder.CreateIndex(
                name: "IX_ManHabitDetails_habitId",
                table: "ManHabitDetails",
                column: "habitId");

            migrationBuilder.CreateIndex(
                name: "IX_ManHabitDetails_manInformationId",
                table: "ManHabitDetails",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_agePeriodId",
                table: "ManInformation",
                column: "agePeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_gDInformationId",
                table: "ManInformation",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_genderId",
                table: "ManInformation",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_nationalIdentityTypeId",
                table: "ManInformation",
                column: "nationalIdentityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_numberTypeId",
                table: "ManInformation",
                column: "numberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ManInformation_relationTypeId",
                table: "ManInformation",
                column: "relationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ManSpeechDetails_manInformationId",
                table: "ManSpeechDetails",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManSpeechDetails_speechId",
                table: "ManSpeechDetails",
                column: "speechId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleAccessPages_applicationRoleId",
                table: "ModuleAccessPages",
                column: "applicationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleAccessPages_eRPModuleId",
                table: "ModuleAccessPages",
                column: "eRPModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Navbars_moduleId",
                table: "Navbars",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_documentTypeId",
                table: "OtherDocumentDetails",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_gDInformationId",
                table: "OtherDocumentDetails",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPersonInformation_gDInformationId",
                table: "OtherPersonInformation",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPersonInformation_nationalIdentityTypeId",
                table: "OtherPersonInformation",
                column: "nationalIdentityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_beardTypeId",
                table: "PhysicalDescriptions",
                column: "beardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_bodyChinTypeId",
                table: "PhysicalDescriptions",
                column: "bodyChinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_bodyColorId",
                table: "PhysicalDescriptions",
                column: "bodyColorId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_bodyStructureId",
                table: "PhysicalDescriptions",
                column: "bodyStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_earTypeId",
                table: "PhysicalDescriptions",
                column: "earTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_eyeTypeId",
                table: "PhysicalDescriptions",
                column: "eyeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_faceShapeTypeId",
                table: "PhysicalDescriptions",
                column: "faceShapeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_foreHeadTypeId",
                table: "PhysicalDescriptions",
                column: "foreHeadTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_headTypeId",
                table: "PhysicalDescriptions",
                column: "headTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_manInformationId",
                table: "PhysicalDescriptions",
                column: "manInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_moustacheTypeId",
                table: "PhysicalDescriptions",
                column: "moustacheTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_mouthTypeId",
                table: "PhysicalDescriptions",
                column: "mouthTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_neckTypeId",
                table: "PhysicalDescriptions",
                column: "neckTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_noseTypeId",
                table: "PhysicalDescriptions",
                column: "noseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_specialBodyConditionId",
                table: "PhysicalDescriptions",
                column: "specialBodyConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalDescriptions_teethTypeId",
                table: "PhysicalDescriptions",
                column: "teethTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostOffices_districtId",
                table: "PostOffices",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_ReligionCusts_religionId",
                table: "ReligionCusts",
                column: "religionId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceAndTimes_districtId",
                table: "SpaceAndTimes",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceAndTimes_divisionId",
                table: "SpaceAndTimes",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceAndTimes_gDInformationId",
                table: "SpaceAndTimes",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceAndTimes_postOfficeId",
                table: "SpaceAndTimes",
                column: "postOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceAndTimes_thanaId",
                table: "SpaceAndTimes",
                column: "thanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanas_districtId",
                table: "Thanas",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessPages_applicationRoleId",
                table: "UserAccessPages",
                column: "applicationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessPages_navbarId",
                table: "UserAccessPages",
                column: "navbarId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformation_gDInformationId",
                table: "VehicleInformation",
                column: "gDInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformation_vehicleBrandId",
                table: "VehicleInformation",
                column: "vehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformation_vehicleTypeId",
                table: "VehicleInformation",
                column: "vehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_vehicleTypeId",
                table: "VehicleModels",
                column: "vehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressCategories");

            migrationBuilder.DropTable(
                name: "AddressInformation");

            migrationBuilder.DropTable(
                name: "AddressSourceTypes");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttachmentInformation");

            migrationBuilder.DropTable(
                name: "CareTypes");

            migrationBuilder.DropTable(
                name: "Complextions");

            migrationBuilder.DropTable(
                name: "ComputerAccessoriesBrands");

            migrationBuilder.DropTable(
                name: "DeadbodyConditions");

            migrationBuilder.DropTable(
                name: "DeathTypes");

            migrationBuilder.DropTable(
                name: "DNAProfileDetails");

            migrationBuilder.DropTable(
                name: "DocumentCategoryAccessories");

            migrationBuilder.DropTable(
                name: "DocumentCategoryBrands");

            migrationBuilder.DropTable(
                name: "DressDescriptions");

            migrationBuilder.DropTable(
                name: "ElectronicsTypes");

            migrationBuilder.DropTable(
                name: "FileDocumentTypes");

            migrationBuilder.DropTable(
                name: "HairTypes");

            migrationBuilder.DropTable(
                name: "IdentificationAttachments");

            migrationBuilder.DropTable(
                name: "LostAndFoundTypes");

            migrationBuilder.DropTable(
                name: "MailLogs");

            migrationBuilder.DropTable(
                name: "ManBodyParts");

            migrationBuilder.DropTable(
                name: "ManHabitDetails");

            migrationBuilder.DropTable(
                name: "ManSpeechDetails");

            migrationBuilder.DropTable(
                name: "MeasurementTypes");

            migrationBuilder.DropTable(
                name: "MeterialConditions");

            migrationBuilder.DropTable(
                name: "MetropolitanAreas");

            migrationBuilder.DropTable(
                name: "MobilePhoneTypes");

            migrationBuilder.DropTable(
                name: "ModuleAccessPages");

            migrationBuilder.DropTable(
                name: "OtherBrands");

            migrationBuilder.DropTable(
                name: "OtherDocumentDetails");

            migrationBuilder.DropTable(
                name: "OtherPersonInformation");

            migrationBuilder.DropTable(
                name: "PhysicalDescriptions");

            migrationBuilder.DropTable(
                name: "PurposeOfVisites");

            migrationBuilder.DropTable(
                name: "RegistrationLevels");

            migrationBuilder.DropTable(
                name: "ReligionCusts");

            migrationBuilder.DropTable(
                name: "SpaceAndTimes");

            migrationBuilder.DropTable(
                name: "UserAccessPages");

            migrationBuilder.DropTable(
                name: "UserLogHistories");

            migrationBuilder.DropTable(
                name: "VehicleInformation");

            migrationBuilder.DropTable(
                name: "AttachmentTypes");

            migrationBuilder.DropTable(
                name: "DocumentCategories");

            migrationBuilder.DropTable(
                name: "InTheBodies");

            migrationBuilder.DropTable(
                name: "InTheHeads");

            migrationBuilder.DropTable(
                name: "InTheLegs");

            migrationBuilder.DropTable(
                name: "InTheThroats");

            migrationBuilder.DropTable(
                name: "InTheWaists");

            migrationBuilder.DropTable(
                name: "IndentifyInfos");

            migrationBuilder.DropTable(
                name: "Habits");

            migrationBuilder.DropTable(
                name: "Speeches");

            migrationBuilder.DropTable(
                name: "BeardTypes");

            migrationBuilder.DropTable(
                name: "BodyChinTypes");

            migrationBuilder.DropTable(
                name: "BodyColors");

            migrationBuilder.DropTable(
                name: "BodyStructures");

            migrationBuilder.DropTable(
                name: "EarTypes");

            migrationBuilder.DropTable(
                name: "EyeTypes");

            migrationBuilder.DropTable(
                name: "FaceShapeTypes");

            migrationBuilder.DropTable(
                name: "ForeHeadTypes");

            migrationBuilder.DropTable(
                name: "HeadTypes");

            migrationBuilder.DropTable(
                name: "ManInformation");

            migrationBuilder.DropTable(
                name: "MoustacheTypes");

            migrationBuilder.DropTable(
                name: "MouthTypes");

            migrationBuilder.DropTable(
                name: "NeckTypes");

            migrationBuilder.DropTable(
                name: "NoseTypes");

            migrationBuilder.DropTable(
                name: "SpecialBodyConditions");

            migrationBuilder.DropTable(
                name: "TeethTypes");

            migrationBuilder.DropTable(
                name: "PostOffices");

            migrationBuilder.DropTable(
                name: "Thanas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Navbars");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "AgePeriods");

            migrationBuilder.DropTable(
                name: "GDInformation");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "NationalIdentityTypes");

            migrationBuilder.DropTable(
                name: "NumberTypes");

            migrationBuilder.DropTable(
                name: "RelationTypes");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "LAFModules");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "GDTypes");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
