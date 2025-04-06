using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedServiceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationItem_Manufacturer_ManufacturerId",
                table: "ConfigurationItem");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "ConfigurationItem",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigurationItem_ManufacturerId",
                table: "ConfigurationItem",
                newName: "IX_ConfigurationItem_ServiceId");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "StringProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "NumberProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "DateProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "BooleanProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ServiceId",
                table: "StringProperty",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ServiceId",
                table: "NumberProperty",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ServiceId",
                table: "DateProperty",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ServiceId",
                table: "BooleanProperty",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ManufacturerId",
                table: "Service",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanProperty_Service_ServiceId",
                table: "BooleanProperty",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationItem_Service_ServiceId",
                table: "ConfigurationItem",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateProperty_Service_ServiceId",
                table: "DateProperty",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumberProperty_Service_ServiceId",
                table: "NumberProperty",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StringProperty_Service_ServiceId",
                table: "StringProperty",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooleanProperty_Service_ServiceId",
                table: "BooleanProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationItem_Service_ServiceId",
                table: "ConfigurationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DateProperty_Service_ServiceId",
                table: "DateProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_NumberProperty_Service_ServiceId",
                table: "NumberProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_StringProperty_Service_ServiceId",
                table: "StringProperty");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropIndex(
                name: "IX_StringProperty_ServiceId",
                table: "StringProperty");

            migrationBuilder.DropIndex(
                name: "IX_NumberProperty_ServiceId",
                table: "NumberProperty");

            migrationBuilder.DropIndex(
                name: "IX_DateProperty_ServiceId",
                table: "DateProperty");

            migrationBuilder.DropIndex(
                name: "IX_BooleanProperty_ServiceId",
                table: "BooleanProperty");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "StringProperty");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "NumberProperty");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "DateProperty");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "BooleanProperty");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "ConfigurationItem",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigurationItem_ServiceId",
                table: "ConfigurationItem",
                newName: "IX_ConfigurationItem_ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationItem_Manufacturer_ManufacturerId",
                table: "ConfigurationItem",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");
        }
    }
}
