using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAssetModel_CIModelCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Asset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConfigurationItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationItemConfigurationItem",
                columns: table => new
                {
                    DownstreamConfigurationItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpstreamConfigurationItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationItemConfigurationItem", x => new { x.DownstreamConfigurationItemsId, x.UpstreamConfigurationItemsId });
                    table.ForeignKey(
                        name: "FK_ConfigurationItemConfigurationItem_ConfigurationItem_DownstreamConfigurationItemsId",
                        column: x => x.DownstreamConfigurationItemsId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigurationItemConfigurationItem_ConfigurationItem_UpstreamConfigurationItemsId",
                        column: x => x.UpstreamConfigurationItemsId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItemConfigurationItem_UpstreamConfigurationItemsId",
                table: "ConfigurationItemConfigurationItem",
                column: "UpstreamConfigurationItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigurationItemConfigurationItem");

            migrationBuilder.DropTable(
                name: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Asset");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
