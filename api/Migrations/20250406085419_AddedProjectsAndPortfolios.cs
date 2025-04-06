using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedProjectsAndPortfolios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "StringProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "StringProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyCondition",
                table: "PropertyStateString",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyCondition",
                table: "PropertyStateNumber",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyCondition",
                table: "PropertyStateDate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyCondition",
                table: "PropertyStateBoolean",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "Organization",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "NumberProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "NumberProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "DateProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "DateProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "BooleanProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "BooleanProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortfolioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Portfolio_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_PortfolioId",
                table: "StringProperty",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ProjectId",
                table: "StringProperty",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_PortfolioId",
                table: "Service",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PortfolioId",
                table: "Organization",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_PortfolioId",
                table: "NumberProperty",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ProjectId",
                table: "NumberProperty",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_PortfolioId",
                table: "DateProperty",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ProjectId",
                table: "DateProperty",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_PortfolioId",
                table: "BooleanProperty",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ProjectId",
                table: "BooleanProperty",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PortfolioId",
                table: "Project",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanProperty_Portfolio_PortfolioId",
                table: "BooleanProperty",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanProperty_Project_ProjectId",
                table: "BooleanProperty",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateProperty_Portfolio_PortfolioId",
                table: "DateProperty",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateProperty_Project_ProjectId",
                table: "DateProperty",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumberProperty_Portfolio_PortfolioId",
                table: "NumberProperty",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumberProperty_Project_ProjectId",
                table: "NumberProperty",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Portfolio_PortfolioId",
                table: "Organization",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Portfolio_PortfolioId",
                table: "Service",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StringProperty_Portfolio_PortfolioId",
                table: "StringProperty",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StringProperty_Project_ProjectId",
                table: "StringProperty",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooleanProperty_Portfolio_PortfolioId",
                table: "BooleanProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_BooleanProperty_Project_ProjectId",
                table: "BooleanProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_DateProperty_Portfolio_PortfolioId",
                table: "DateProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_DateProperty_Project_ProjectId",
                table: "DateProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_NumberProperty_Portfolio_PortfolioId",
                table: "NumberProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_NumberProperty_Project_ProjectId",
                table: "NumberProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Portfolio_PortfolioId",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Portfolio_PortfolioId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_StringProperty_Portfolio_PortfolioId",
                table: "StringProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_StringProperty_Project_ProjectId",
                table: "StringProperty");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Portfolio");

            migrationBuilder.DropIndex(
                name: "IX_StringProperty_PortfolioId",
                table: "StringProperty");

            migrationBuilder.DropIndex(
                name: "IX_StringProperty_ProjectId",
                table: "StringProperty");

            migrationBuilder.DropIndex(
                name: "IX_Service_PortfolioId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Organization_PortfolioId",
                table: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_NumberProperty_PortfolioId",
                table: "NumberProperty");

            migrationBuilder.DropIndex(
                name: "IX_NumberProperty_ProjectId",
                table: "NumberProperty");

            migrationBuilder.DropIndex(
                name: "IX_DateProperty_PortfolioId",
                table: "DateProperty");

            migrationBuilder.DropIndex(
                name: "IX_DateProperty_ProjectId",
                table: "DateProperty");

            migrationBuilder.DropIndex(
                name: "IX_BooleanProperty_PortfolioId",
                table: "BooleanProperty");

            migrationBuilder.DropIndex(
                name: "IX_BooleanProperty_ProjectId",
                table: "BooleanProperty");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "StringProperty");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "StringProperty");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "PropertyCondition",
                table: "PropertyStateString");

            migrationBuilder.DropColumn(
                name: "PropertyCondition",
                table: "PropertyStateNumber");

            migrationBuilder.DropColumn(
                name: "PropertyCondition",
                table: "PropertyStateDate");

            migrationBuilder.DropColumn(
                name: "PropertyCondition",
                table: "PropertyStateBoolean");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "NumberProperty");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "NumberProperty");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "DateProperty");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "DateProperty");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "BooleanProperty");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "BooleanProperty");
        }
    }
}
