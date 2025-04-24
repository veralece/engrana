using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class EngranaModelsSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "StringProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedQueueId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedResourceId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceCategoryId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceCategoryId",
                table: "Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceOwnerId",
                table: "Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "NumberProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PrimaryContactId",
                table: "Incident",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "DateProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "Change",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "BooleanProperty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrganizationQueue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_OrganizationQueue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationQueue_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCategoryOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_ServiceCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceCategory_Organization_ServiceCategoryOwnerId",
                        column: x => x.ServiceCategoryOwnerId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationQueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Profile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profile_OrganizationQueue_OrganizationQueueId",
                        column: x => x.OrganizationQueueId,
                        principalTable: "OrganizationQueue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Profile_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StringProperty_ProfileId",
                table: "StringProperty",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequest_AssignedQueueId",
                table: "ServiceRequest",
                column: "AssignedQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequest_AssignedResourceId",
                table: "ServiceRequest",
                column: "AssignedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequest_ProjectId",
                table: "ServiceRequest",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequest_ServiceCategoryId",
                table: "ServiceRequest",
                column: "ServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequest_ServiceId",
                table: "ServiceRequest",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceCategoryId",
                table: "Service",
                column: "ServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceOwnerId",
                table: "Service",
                column: "ServiceOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberProperty_ProfileId",
                table: "NumberProperty",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_PrimaryContactId",
                table: "Incident",
                column: "PrimaryContactId");

            migrationBuilder.CreateIndex(
                name: "IX_DateProperty_ProfileId",
                table: "DateProperty",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Change_ProjectId",
                table: "Change",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanProperty_ProfileId",
                table: "BooleanProperty",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationQueue_OrganizationId",
                table: "OrganizationQueue",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_OrganizationId",
                table: "Profile",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_OrganizationQueueId",
                table: "Profile",
                column: "OrganizationQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCategory_ServiceCategoryOwnerId",
                table: "ServiceCategory",
                column: "ServiceCategoryOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanProperty_Profile_ProfileId",
                table: "BooleanProperty",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Change_Project_ProjectId",
                table: "Change",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateProperty_Profile_ProfileId",
                table: "DateProperty",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_ContactInformation_PrimaryContactId",
                table: "Incident",
                column: "PrimaryContactId",
                principalTable: "ContactInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NumberProperty_Profile_ProfileId",
                table: "NumberProperty",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Organization_ServiceOwnerId",
                table: "Service",
                column: "ServiceOwnerId",
                principalTable: "Organization",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServiceCategory_ServiceCategoryId",
                table: "Service",
                column: "ServiceCategoryId",
                principalTable: "ServiceCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequest_OrganizationQueue_AssignedQueueId",
                table: "ServiceRequest",
                column: "AssignedQueueId",
                principalTable: "OrganizationQueue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequest_Profile_AssignedResourceId",
                table: "ServiceRequest",
                column: "AssignedResourceId",
                principalTable: "Profile",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequest_Project_ProjectId",
                table: "ServiceRequest",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequest_ServiceCategory_ServiceCategoryId",
                table: "ServiceRequest",
                column: "ServiceCategoryId",
                principalTable: "ServiceCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequest_Service_ServiceId",
                table: "ServiceRequest",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StringProperty_Profile_ProfileId",
                table: "StringProperty",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooleanProperty_Profile_ProfileId",
                table: "BooleanProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Change_Project_ProjectId",
                table: "Change");

            migrationBuilder.DropForeignKey(
                name: "FK_DateProperty_Profile_ProfileId",
                table: "DateProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_ContactInformation_PrimaryContactId",
                table: "Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_NumberProperty_Profile_ProfileId",
                table: "NumberProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Organization_ServiceOwnerId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServiceCategory_ServiceCategoryId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequest_OrganizationQueue_AssignedQueueId",
                table: "ServiceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequest_Profile_AssignedResourceId",
                table: "ServiceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequest_Project_ProjectId",
                table: "ServiceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequest_ServiceCategory_ServiceCategoryId",
                table: "ServiceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequest_Service_ServiceId",
                table: "ServiceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_StringProperty_Profile_ProfileId",
                table: "StringProperty");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "ServiceCategory");

            migrationBuilder.DropTable(
                name: "OrganizationQueue");

            migrationBuilder.DropIndex(
                name: "IX_StringProperty_ProfileId",
                table: "StringProperty");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequest_AssignedQueueId",
                table: "ServiceRequest");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequest_AssignedResourceId",
                table: "ServiceRequest");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequest_ProjectId",
                table: "ServiceRequest");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequest_ServiceCategoryId",
                table: "ServiceRequest");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequest_ServiceId",
                table: "ServiceRequest");

            migrationBuilder.DropIndex(
                name: "IX_Service_ServiceCategoryId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ServiceOwnerId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_NumberProperty_ProfileId",
                table: "NumberProperty");

            migrationBuilder.DropIndex(
                name: "IX_Incident_PrimaryContactId",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_DateProperty_ProfileId",
                table: "DateProperty");

            migrationBuilder.DropIndex(
                name: "IX_Change_ProjectId",
                table: "Change");

            migrationBuilder.DropIndex(
                name: "IX_BooleanProperty_ProfileId",
                table: "BooleanProperty");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "StringProperty");

            migrationBuilder.DropColumn(
                name: "AssignedQueueId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "AssignedResourceId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ServiceCategoryId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ServiceCategoryId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ServiceOwnerId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "NumberProperty");

            migrationBuilder.DropColumn(
                name: "PrimaryContactId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "DateProperty");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Change");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "BooleanProperty");
        }
    }
}
