using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SplitWorkflowSteps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateBoolean_CompareStatement_CompareStatementId",
                table: "PropertyStateBoolean");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateBoolean_WorkflowStep_WorkflowStepId",
                table: "PropertyStateBoolean");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateDate_CompareStatement_CompareStatementId",
                table: "PropertyStateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateDate_WorkflowStep_WorkflowStepId",
                table: "PropertyStateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateNumber_CompareStatement_CompareStatementId",
                table: "PropertyStateNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateNumber_WorkflowStep_WorkflowStepId",
                table: "PropertyStateNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateString_CompareStatement_CompareStatementId",
                table: "PropertyStateString");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateString_WorkflowStep_WorkflowStepId",
                table: "PropertyStateString");

            migrationBuilder.DropForeignKey(
                name: "FK_Trigger_CompareStatement_CompareStatementId",
                table: "Trigger");

            migrationBuilder.DropTable(
                name: "WorkflowStep");

            migrationBuilder.DropTable(
                name: "CompareStatement");

            migrationBuilder.RenameColumn(
                name: "TriggerType",
                table: "Trigger",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "CompareStatementId",
                table: "Trigger",
                newName: "ConditionStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_Trigger_CompareStatementId",
                table: "Trigger",
                newName: "IX_Trigger_ConditionStatementId");

            migrationBuilder.RenameColumn(
                name: "WorkflowStepId",
                table: "PropertyStateString",
                newName: "DataStepId");

            migrationBuilder.RenameColumn(
                name: "CompareStatementId",
                table: "PropertyStateString",
                newName: "ConditionStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateString_WorkflowStepId",
                table: "PropertyStateString",
                newName: "IX_PropertyStateString_DataStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateString_CompareStatementId",
                table: "PropertyStateString",
                newName: "IX_PropertyStateString_ConditionStatementId");

            migrationBuilder.RenameColumn(
                name: "WorkflowStepId",
                table: "PropertyStateNumber",
                newName: "DataStepId");

            migrationBuilder.RenameColumn(
                name: "CompareStatementId",
                table: "PropertyStateNumber",
                newName: "ConditionStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateNumber_WorkflowStepId",
                table: "PropertyStateNumber",
                newName: "IX_PropertyStateNumber_DataStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateNumber_CompareStatementId",
                table: "PropertyStateNumber",
                newName: "IX_PropertyStateNumber_ConditionStatementId");

            migrationBuilder.RenameColumn(
                name: "WorkflowStepId",
                table: "PropertyStateDate",
                newName: "DataStepId");

            migrationBuilder.RenameColumn(
                name: "CompareStatementId",
                table: "PropertyStateDate",
                newName: "ConditionStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateDate_WorkflowStepId",
                table: "PropertyStateDate",
                newName: "IX_PropertyStateDate_DataStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateDate_CompareStatementId",
                table: "PropertyStateDate",
                newName: "IX_PropertyStateDate_ConditionStatementId");

            migrationBuilder.RenameColumn(
                name: "WorkflowStepId",
                table: "PropertyStateBoolean",
                newName: "DataStepId");

            migrationBuilder.RenameColumn(
                name: "CompareStatementId",
                table: "PropertyStateBoolean",
                newName: "ConditionStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateBoolean_WorkflowStepId",
                table: "PropertyStateBoolean",
                newName: "IX_PropertyStateBoolean_DataStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateBoolean_CompareStatementId",
                table: "PropertyStateBoolean",
                newName: "IX_PropertyStateBoolean_ConditionStatementId");

            migrationBuilder.AddColumn<int>(
                name: "WorkflowType",
                table: "Workflow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConditionStatement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ConditionStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataStep_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Workflow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConditionStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConditionStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionStep_ConditionStatement_ConditionStatementId",
                        column: x => x.ConditionStatementId,
                        principalTable: "ConditionStatement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConditionStep_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Workflow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConditionStep_ConditionStatementId",
                table: "ConditionStep",
                column: "ConditionStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionStep_WorkflowId",
                table: "ConditionStep",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_DataStep_WorkflowId",
                table: "DataStep",
                column: "WorkflowId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateBoolean_ConditionStatement_ConditionStatementId",
                table: "PropertyStateBoolean",
                column: "ConditionStatementId",
                principalTable: "ConditionStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateBoolean_DataStep_DataStepId",
                table: "PropertyStateBoolean",
                column: "DataStepId",
                principalTable: "DataStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateDate_ConditionStatement_ConditionStatementId",
                table: "PropertyStateDate",
                column: "ConditionStatementId",
                principalTable: "ConditionStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateDate_DataStep_DataStepId",
                table: "PropertyStateDate",
                column: "DataStepId",
                principalTable: "DataStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateNumber_ConditionStatement_ConditionStatementId",
                table: "PropertyStateNumber",
                column: "ConditionStatementId",
                principalTable: "ConditionStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateNumber_DataStep_DataStepId",
                table: "PropertyStateNumber",
                column: "DataStepId",
                principalTable: "DataStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateString_ConditionStatement_ConditionStatementId",
                table: "PropertyStateString",
                column: "ConditionStatementId",
                principalTable: "ConditionStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateString_DataStep_DataStepId",
                table: "PropertyStateString",
                column: "DataStepId",
                principalTable: "DataStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trigger_ConditionStatement_ConditionStatementId",
                table: "Trigger",
                column: "ConditionStatementId",
                principalTable: "ConditionStatement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateBoolean_ConditionStatement_ConditionStatementId",
                table: "PropertyStateBoolean");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateBoolean_DataStep_DataStepId",
                table: "PropertyStateBoolean");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateDate_ConditionStatement_ConditionStatementId",
                table: "PropertyStateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateDate_DataStep_DataStepId",
                table: "PropertyStateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateNumber_ConditionStatement_ConditionStatementId",
                table: "PropertyStateNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateNumber_DataStep_DataStepId",
                table: "PropertyStateNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateString_ConditionStatement_ConditionStatementId",
                table: "PropertyStateString");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStateString_DataStep_DataStepId",
                table: "PropertyStateString");

            migrationBuilder.DropForeignKey(
                name: "FK_Trigger_ConditionStatement_ConditionStatementId",
                table: "Trigger");

            migrationBuilder.DropTable(
                name: "ConditionStep");

            migrationBuilder.DropTable(
                name: "DataStep");

            migrationBuilder.DropTable(
                name: "ConditionStatement");

            migrationBuilder.DropColumn(
                name: "WorkflowType",
                table: "Workflow");

            migrationBuilder.RenameColumn(
                name: "ConditionStatementId",
                table: "Trigger",
                newName: "CompareStatementId");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "Trigger",
                newName: "TriggerType");

            migrationBuilder.RenameIndex(
                name: "IX_Trigger_ConditionStatementId",
                table: "Trigger",
                newName: "IX_Trigger_CompareStatementId");

            migrationBuilder.RenameColumn(
                name: "DataStepId",
                table: "PropertyStateString",
                newName: "WorkflowStepId");

            migrationBuilder.RenameColumn(
                name: "ConditionStatementId",
                table: "PropertyStateString",
                newName: "CompareStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateString_DataStepId",
                table: "PropertyStateString",
                newName: "IX_PropertyStateString_WorkflowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateString_ConditionStatementId",
                table: "PropertyStateString",
                newName: "IX_PropertyStateString_CompareStatementId");

            migrationBuilder.RenameColumn(
                name: "DataStepId",
                table: "PropertyStateNumber",
                newName: "WorkflowStepId");

            migrationBuilder.RenameColumn(
                name: "ConditionStatementId",
                table: "PropertyStateNumber",
                newName: "CompareStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateNumber_DataStepId",
                table: "PropertyStateNumber",
                newName: "IX_PropertyStateNumber_WorkflowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateNumber_ConditionStatementId",
                table: "PropertyStateNumber",
                newName: "IX_PropertyStateNumber_CompareStatementId");

            migrationBuilder.RenameColumn(
                name: "DataStepId",
                table: "PropertyStateDate",
                newName: "WorkflowStepId");

            migrationBuilder.RenameColumn(
                name: "ConditionStatementId",
                table: "PropertyStateDate",
                newName: "CompareStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateDate_DataStepId",
                table: "PropertyStateDate",
                newName: "IX_PropertyStateDate_WorkflowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateDate_ConditionStatementId",
                table: "PropertyStateDate",
                newName: "IX_PropertyStateDate_CompareStatementId");

            migrationBuilder.RenameColumn(
                name: "DataStepId",
                table: "PropertyStateBoolean",
                newName: "WorkflowStepId");

            migrationBuilder.RenameColumn(
                name: "ConditionStatementId",
                table: "PropertyStateBoolean",
                newName: "CompareStatementId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateBoolean_DataStepId",
                table: "PropertyStateBoolean",
                newName: "IX_PropertyStateBoolean_WorkflowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyStateBoolean_ConditionStatementId",
                table: "PropertyStateBoolean",
                newName: "IX_PropertyStateBoolean_CompareStatementId");

            migrationBuilder.CreateTable(
                name: "CompareStatement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompareStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompareStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStep_CompareStatementId",
                table: "WorkflowStep",
                column: "CompareStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStep_WorkflowId",
                table: "WorkflowStep",
                column: "WorkflowId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateBoolean_CompareStatement_CompareStatementId",
                table: "PropertyStateBoolean",
                column: "CompareStatementId",
                principalTable: "CompareStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateBoolean_WorkflowStep_WorkflowStepId",
                table: "PropertyStateBoolean",
                column: "WorkflowStepId",
                principalTable: "WorkflowStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateDate_CompareStatement_CompareStatementId",
                table: "PropertyStateDate",
                column: "CompareStatementId",
                principalTable: "CompareStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateDate_WorkflowStep_WorkflowStepId",
                table: "PropertyStateDate",
                column: "WorkflowStepId",
                principalTable: "WorkflowStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateNumber_CompareStatement_CompareStatementId",
                table: "PropertyStateNumber",
                column: "CompareStatementId",
                principalTable: "CompareStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateNumber_WorkflowStep_WorkflowStepId",
                table: "PropertyStateNumber",
                column: "WorkflowStepId",
                principalTable: "WorkflowStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateString_CompareStatement_CompareStatementId",
                table: "PropertyStateString",
                column: "CompareStatementId",
                principalTable: "CompareStatement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStateString_WorkflowStep_WorkflowStepId",
                table: "PropertyStateString",
                column: "WorkflowStepId",
                principalTable: "WorkflowStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trigger_CompareStatement_CompareStatementId",
                table: "Trigger",
                column: "CompareStatementId",
                principalTable: "CompareStatement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
