using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class OTHERDOCUMENTMODIFY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bodyType",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "brandName",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "color",
                table: "OtherDocumentDetails");

            migrationBuilder.RenameColumn(
                name: "structureType",
                table: "OtherDocumentDetails",
                newName: "serialNo");

            migrationBuilder.RenameColumn(
                name: "identificationMark",
                table: "OtherDocumentDetails",
                newName: "productNumber");

            migrationBuilder.AddColumn<int>(
                name: "colorsId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "currency",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(50)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "documentCategoryBrandId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "electronicsTypeId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fileDocumentTypeId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mobilePhoneTypeId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "otherBrandId",
                table: "OtherDocumentDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_colorsId",
                table: "OtherDocumentDetails",
                column: "colorsId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_documentCategoryBrandId",
                table: "OtherDocumentDetails",
                column: "documentCategoryBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_electronicsTypeId",
                table: "OtherDocumentDetails",
                column: "electronicsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_fileDocumentTypeId",
                table: "OtherDocumentDetails",
                column: "fileDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_mobilePhoneTypeId",
                table: "OtherDocumentDetails",
                column: "mobilePhoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentDetails_otherBrandId",
                table: "OtherDocumentDetails",
                column: "otherBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_Colors_colorsId",
                table: "OtherDocumentDetails",
                column: "colorsId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_DocumentCategoryBrands_documentCategoryBrandId",
                table: "OtherDocumentDetails",
                column: "documentCategoryBrandId",
                principalTable: "DocumentCategoryBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_ElectronicsTypes_electronicsTypeId",
                table: "OtherDocumentDetails",
                column: "electronicsTypeId",
                principalTable: "ElectronicsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_FileDocumentTypes_fileDocumentTypeId",
                table: "OtherDocumentDetails",
                column: "fileDocumentTypeId",
                principalTable: "FileDocumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_MobilePhoneTypes_mobilePhoneTypeId",
                table: "OtherDocumentDetails",
                column: "mobilePhoneTypeId",
                principalTable: "MobilePhoneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocumentDetails_OtherBrands_otherBrandId",
                table: "OtherDocumentDetails",
                column: "otherBrandId",
                principalTable: "OtherBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_Colors_colorsId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_DocumentCategoryBrands_documentCategoryBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_ElectronicsTypes_electronicsTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_FileDocumentTypes_fileDocumentTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_MobilePhoneTypes_mobilePhoneTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentDetails_OtherBrands_otherBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_colorsId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_documentCategoryBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_electronicsTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_fileDocumentTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_mobilePhoneTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropIndex(
                name: "IX_OtherDocumentDetails_otherBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "colorsId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "currency",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "documentCategoryBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "electronicsTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "fileDocumentTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "mobilePhoneTypeId",
                table: "OtherDocumentDetails");

            migrationBuilder.DropColumn(
                name: "otherBrandId",
                table: "OtherDocumentDetails");

            migrationBuilder.RenameColumn(
                name: "serialNo",
                table: "OtherDocumentDetails",
                newName: "structureType");

            migrationBuilder.RenameColumn(
                name: "productNumber",
                table: "OtherDocumentDetails",
                newName: "identificationMark");

            migrationBuilder.AddColumn<string>(
                name: "bodyType",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "brandName",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "OtherDocumentDetails",
                type: "NVARCHAR(100)",
                nullable: true);
        }
    }
}
