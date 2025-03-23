using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AssetId",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Asset",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetTag",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "Asset",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Urls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInformation_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalAddress_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalAddress_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomField",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Entity = table.Column<int>(type: "int", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomField_ConfigurationItem_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomField_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomField_CustomSet_SetId",
                        column: x => x.SetId,
                        principalTable: "CustomSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomField_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomField_PhysicalAddress_PhysicalAddressId",
                        column: x => x.PhysicalAddressId,
                        principalTable: "PhysicalAddress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateValue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoolValue = table.Column<bool>(type: "bit", nullable: true),
                    MultiValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFieldEntry_CustomField_CustomFieldId",
                        column: x => x.CustomFieldId,
                        principalTable: "CustomField",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItem_AssetId",
                table: "ConfigurationItem",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItem_ManufacturerId",
                table: "ConfigurationItem",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AddressId",
                table: "Asset",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_ManufacturerId",
                table: "Asset",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_ManufacturerId",
                table: "ContactInformation",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_AssetId",
                table: "CustomField",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_ConfigurationItemId",
                table: "CustomField",
                column: "ConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_ContactInformationId",
                table: "CustomField",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_ManufacturerId",
                table: "CustomField",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_PhysicalAddressId",
                table: "CustomField",
                column: "PhysicalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField_SetId",
                table: "CustomField",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFieldEntry_CustomFieldId",
                table: "CustomFieldEntry",
                column: "CustomFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAddress_ContactInformationId",
                table: "PhysicalAddress",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAddress_ManufacturerId",
                table: "PhysicalAddress",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Manufacturer_ManufacturerId",
                table: "Asset",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_PhysicalAddress_AddressId",
                table: "Asset",
                column: "AddressId",
                principalTable: "PhysicalAddress",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationItem_Asset_AssetId",
                table: "ConfigurationItem",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationItem_Manufacturer_ManufacturerId",
                table: "ConfigurationItem",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Manufacturer_ManufacturerId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_PhysicalAddress_AddressId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationItem_Asset_AssetId",
                table: "ConfigurationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationItem_Manufacturer_ManufacturerId",
                table: "ConfigurationItem");

            migrationBuilder.DropTable(
                name: "CustomFieldEntry");

            migrationBuilder.DropTable(
                name: "CustomField");

            migrationBuilder.DropTable(
                name: "CustomSet");

            migrationBuilder.DropTable(
                name: "PhysicalAddress");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropIndex(
                name: "IX_ConfigurationItem_AssetId",
                table: "ConfigurationItem");

            migrationBuilder.DropIndex(
                name: "IX_ConfigurationItem_ManufacturerId",
                table: "ConfigurationItem");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AddressId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_ManufacturerId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetTag",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Asset");
        }
    }
}
