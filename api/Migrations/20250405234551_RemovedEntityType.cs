using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RemovedEntityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "WorkflowStep");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Workflow");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Trigger");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "StringSet");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "StringProperty");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "StringEntry");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PropertyStateString");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PropertyStateNumber");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PropertyStateDate");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PropertyStateBoolean");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "NumberSet");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "NumberProperty");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "NumberEntry");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "KnowledgeArticle");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DateSet");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DateProperty");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DateEntry");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "CompareStatement");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Change");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BooleanProperty");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BooleanEntry");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Asset");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "WorkflowStep",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Workflow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Trigger",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "StringSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "StringProperty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "StringEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ServiceRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PropertyStateString",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PropertyStateNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PropertyStateDate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PropertyStateBoolean",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PhysicalAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Organization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "NumberSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "NumberProperty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "NumberEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Manufacturer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "KnowledgeArticle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Incident",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "DateSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "DateProperty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "DateEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ContactInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ConfigurationItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "CompareStatement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Change",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "BooleanProperty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "BooleanEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Asset",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
