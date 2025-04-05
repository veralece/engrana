using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class WorkflowMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomFieldEntry");

            migrationBuilder.DropTable(
                name: "CustomField");

            migrationBuilder.DropTable(
                name: "CustomSet");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAddress",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAddress",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "PhysicalAddress",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "PhysicalAddress",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PhysicalAddress",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAddress",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAddress",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PhysicalAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Manufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Manufacturer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Manufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Manufacturer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Manufacturer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Manufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Manufacturer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Manufacturer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ContactInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ContactInformation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "ContactInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ContactInformation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IncidentId",
                table: "ContactInformation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ContactInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ContactInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ContactInformation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ContactInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ConfigurationItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "ConfigurationItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IncidentId",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigurationItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ConfigurationItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ConfigurationItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ConfigurationItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Asset",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Asset",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Asset",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Asset",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Asset",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Asset",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Asset",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Asset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Change",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Change", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompareStatement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CompareStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Incident", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeArticle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_KnowledgeArticle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ServiceRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StringSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Workflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trigger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TriggerEntity = table.Column<int>(type: "int", nullable: false),
                    TriggerType = table.Column<int>(type: "int", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowMessage = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Trigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trigger_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooleanProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IncidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KnowledgeArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FieldLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    HintMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooleanProperty_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_Change_ChangeId",
                        column: x => x.ChangeId,
                        principalTable: "Change",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_ConfigurationItem_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_KnowledgeArticle_KnowledgeArticleId",
                        column: x => x.KnowledgeArticleId,
                        principalTable: "KnowledgeArticle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_PhysicalAddress_PhysicalAddressId",
                        column: x => x.PhysicalAddressId,
                        principalTable: "PhysicalAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooleanProperty_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DateProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IncidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KnowledgeArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FieldLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    HintMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateProperty_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_Change_ChangeId",
                        column: x => x.ChangeId,
                        principalTable: "Change",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_ConfigurationItem_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_DateSet_SetId",
                        column: x => x.SetId,
                        principalTable: "DateSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_KnowledgeArticle_KnowledgeArticleId",
                        column: x => x.KnowledgeArticleId,
                        principalTable: "KnowledgeArticle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_PhysicalAddress_PhysicalAddressId",
                        column: x => x.PhysicalAddressId,
                        principalTable: "PhysicalAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateProperty_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NumberProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IncidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KnowledgeArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FieldLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    HintMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumberProperty_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_Change_ChangeId",
                        column: x => x.ChangeId,
                        principalTable: "Change",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_ConfigurationItem_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_KnowledgeArticle_KnowledgeArticleId",
                        column: x => x.KnowledgeArticleId,
                        principalTable: "KnowledgeArticle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_NumberSet_SetId",
                        column: x => x.SetId,
                        principalTable: "NumberSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_PhysicalAddress_PhysicalAddressId",
                        column: x => x.PhysicalAddressId,
                        principalTable: "PhysicalAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NumberProperty_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StringProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IncidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KnowledgeArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FieldLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    HintMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringProperty_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_Change_ChangeId",
                        column: x => x.ChangeId,
                        principalTable: "Change",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_ConfigurationItem_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalTable: "ConfigurationItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_ContactInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_KnowledgeArticle_KnowledgeArticleId",
                        column: x => x.KnowledgeArticleId,
                        principalTable: "KnowledgeArticle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_PhysicalAddress_PhysicalAddressId",
                        column: x => x.PhysicalAddressId,
                        principalTable: "PhysicalAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringProperty_StringSet_SetId",
                        column: x => x.SetId,
                        principalTable: "StringSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkflowStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_WorkflowStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowStep_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkflowStep_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Workflow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BooleanEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<bool>(type: "bit", nullable: false),
                    BooleanPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooleanEntry_BooleanProperty_BooleanPropertyId",
                        column: x => x.BooleanPropertyId,
                        principalTable: "BooleanProperty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DateEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateEntry_DateProperty_DatePropertyId",
                        column: x => x.DatePropertyId,
                        principalTable: "DateProperty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NumberEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    NumberPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumberEntry_NumberProperty_NumberPropertyId",
                        column: x => x.NumberPropertyId,
                        principalTable: "NumberProperty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StringEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringEntry_StringProperty_StringPropertyId",
                        column: x => x.StringPropertyId,
                        principalTable: "StringProperty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyStateBoolean",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkflowStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCustomProperty = table.Column<bool>(type: "bit", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStateBoolean", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyStateBoolean_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyStateBoolean_WorkflowStep_WorkflowStepId",
                        column: x => x.WorkflowStepId,
                        principalTable: "WorkflowStep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyStateDate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkflowStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCustomProperty = table.Column<bool>(type: "bit", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStateDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyStateDate_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyStateDate_WorkflowStep_WorkflowStepId",
                        column: x => x.WorkflowStepId,
                        principalTable: "WorkflowStep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyStateNumber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkflowStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCustomProperty = table.Column<bool>(type: "bit", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStateNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyStateNumber_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyStateNumber_WorkflowStep_WorkflowStepId",
                        column: x => x.WorkflowStepId,
                        principalTable: "WorkflowStep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyStateString",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkflowStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCustomProperty = table.Column<bool>(type: "bit", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStateString", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyStateString_CompareStatement_CompareStatementId",
                        column: x => x.CompareStatementId,
                        principalTable: "CompareStatement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyStateString_WorkflowStep_WorkflowStepId",
                        column: x => x.WorkflowStepId,
                        principalTable: "WorkflowStep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_IncidentId",
                table: "ContactInformation",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItem_IncidentId",
                table: "ConfigurationItem",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanEntry_BooleanPropertyId",
                table: "BooleanEntry",
                column: "BooleanPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_AssetId",
                table: "BooleanProperty",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ChangeId",
                table: "BooleanProperty",
                column: "ChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ConfigurationItemId",
                table: "BooleanProperty",
                column: "ConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ContactInformationId",
                table: "BooleanProperty",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_IncidentId",
                table: "BooleanProperty",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_KnowledgeArticleId",
                table: "BooleanProperty",
                column: "KnowledgeArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ManufacturerId",
                table: "BooleanProperty",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_OrganizationId",
                table: "BooleanProperty",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_PhysicalAddressId",
                table: "BooleanProperty",
                column: "PhysicalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ServiceRequestId",
                table: "BooleanProperty",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DateEntry_DatePropertyId",
                table: "DateEntry",
                column: "DatePropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_AssetId",
                table: "DateProperty",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ChangeId",
                table: "DateProperty",
                column: "ChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ConfigurationItemId",
                table: "DateProperty",
                column: "ConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ContactInformationId",
                table: "DateProperty",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_IncidentId",
                table: "DateProperty",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_KnowledgeArticleId",
                table: "DateProperty",
                column: "KnowledgeArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ManufacturerId",
                table: "DateProperty",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_OrganizationId",
                table: "DateProperty",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_PhysicalAddressId",
                table: "DateProperty",
                column: "PhysicalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ServiceRequestId",
                table: "DateProperty",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_SetId",
                table: "DateProperty",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberEntry_NumberPropertyId",
                table: "NumberEntry",
                column: "NumberPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_AssetId",
                table: "NumberProperty",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ChangeId",
                table: "NumberProperty",
                column: "ChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ConfigurationItemId",
                table: "NumberProperty",
                column: "ConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ContactInformationId",
                table: "NumberProperty",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_IncidentId",
                table: "NumberProperty",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_KnowledgeArticleId",
                table: "NumberProperty",
                column: "KnowledgeArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ManufacturerId",
                table: "NumberProperty",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_OrganizationId",
                table: "NumberProperty",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_PhysicalAddressId",
                table: "NumberProperty",
                column: "PhysicalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ServiceRequestId",
                table: "NumberProperty",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_SetId",
                table: "NumberProperty",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateBoolean_CompareStatementId",
                table: "PropertyStateBoolean",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateBoolean_WorkflowStepId",
                table: "PropertyStateBoolean",
                column: "WorkflowStepId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateDate_CompareStatementId",
                table: "PropertyStateDate",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateDate_WorkflowStepId",
                table: "PropertyStateDate",
                column: "WorkflowStepId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateNumber_CompareStatementId",
                table: "PropertyStateNumber",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateNumber_WorkflowStepId",
                table: "PropertyStateNumber",
                column: "WorkflowStepId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateString_CompareStatementId",
                table: "PropertyStateString",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStateString_WorkflowStepId",
                table: "PropertyStateString",
                column: "WorkflowStepId");

            migrationBuilder.CreateIndex(
                name: "IX_StringEntry_StringPropertyId",
                table: "StringEntry",
                column: "StringPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_AssetId",
                table: "StringProperty",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ChangeId",
                table: "StringProperty",
                column: "ChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ConfigurationItemId",
                table: "StringProperty",
                column: "ConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ContactInformationId",
                table: "StringProperty",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_IncidentId",
                table: "StringProperty",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_KnowledgeArticleId",
                table: "StringProperty",
                column: "KnowledgeArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ManufacturerId",
                table: "StringProperty",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_OrganizationId",
                table: "StringProperty",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_PhysicalAddressId",
                table: "StringProperty",
                column: "PhysicalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ServiceRequestId",
                table: "StringProperty",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_SetId",
                table: "StringProperty",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Trigger_CompareStatementId",
                table: "Trigger",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStep_CompareStatementId",
                table: "WorkflowStep",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStep_WorkflowId",
                table: "WorkflowStep",
                column: "WorkflowId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationItem_Incident_IncidentId",
                table: "ConfigurationItem",
                column: "IncidentId",
                principalTable: "Incident",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformation_Incident_IncidentId",
                table: "ContactInformation",
                column: "IncidentId",
                principalTable: "Incident",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationItem_Incident_IncidentId",
                table: "ConfigurationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformation_Incident_IncidentId",
                table: "ContactInformation");

            migrationBuilder.DropTable(
                name: "BooleanEntry");

            migrationBuilder.DropTable(
                name: "DateEntry");

            migrationBuilder.DropTable(
                name: "NumberEntry");

            migrationBuilder.DropTable(
                name: "PropertyStateBoolean");

            migrationBuilder.DropTable(
                name: "PropertyStateDate");

            migrationBuilder.DropTable(
                name: "PropertyStateNumber");

            migrationBuilder.DropTable(
                name: "PropertyStateString");

            migrationBuilder.DropTable(
                name: "StringEntry");

            migrationBuilder.DropTable(
                name: "Trigger");

            migrationBuilder.DropTable(
                name: "BooleanProperty");

            migrationBuilder.DropTable(
                name: "DateProperty");

            migrationBuilder.DropTable(
                name: "NumberProperty");

            migrationBuilder.DropTable(
                name: "WorkflowStep");

            migrationBuilder.DropTable(
                name: "StringProperty");

            migrationBuilder.DropTable(
                name: "DateSet");

            migrationBuilder.DropTable(
                name: "NumberSet");

            migrationBuilder.DropTable(
                name: "CompareStatement");

            migrationBuilder.DropTable(
                name: "Workflow");

            migrationBuilder.DropTable(
                name: "Change");

            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "KnowledgeArticle");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "ServiceRequest");

            migrationBuilder.DropTable(
                name: "StringSet");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformation_IncidentId",
                table: "ContactInformation");

            migrationBuilder.DropIndex(
                name: "IX_ConfigurationItem_IncidentId",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PhysicalAddress");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "IncidentId",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "IncidentId",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ConfigurationItem");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Asset");

            migrationBuilder.CreateTable(
                name: "CustomSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomField",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfigurationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Entity = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
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
                    BoolValue = table.Column<bool>(type: "bit", nullable: true),
                    CustomFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateValue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultiValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
        }
    }
}
