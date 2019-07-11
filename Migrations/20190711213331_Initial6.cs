using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CauseOfDeath",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDeath",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deceased",
                table: "Patients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Patients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarkedBy",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientType",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    AllergyID = table.Column<string>(nullable: false),
                    AllergyName = table.Column<string>(nullable: true),
                    Reaction = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    VisitID = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.AllergyID);
                    table.ForeignKey(
                        name: "FK_Allergies_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allergies_Visits_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visits",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    AttachmentID = table.Column<string>(nullable: false),
                    AttachmentCaption = table.Column<string>(nullable: true),
                    FileUrl = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    VisitID = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.AttachmentID);
                    table.ForeignKey(
                        name: "FK_Attachments_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachments_Visits_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visits",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionID = table.Column<string>(nullable: false),
                    ConditionName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    VisitID = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionID);
                    table.ForeignKey(
                        name: "FK_Conditions_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_Visits_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visits",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_HospitalId",
                table: "Allergies",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_VisitID",
                table: "Allergies",
                column: "VisitID");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_HospitalId",
                table: "Attachments",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_VisitID",
                table: "Attachments",
                column: "VisitID");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_HospitalId",
                table: "Conditions",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_VisitID",
                table: "Conditions",
                column: "VisitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropColumn(
                name: "CauseOfDeath",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateOfDeath",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Deceased",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MarkedBy",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientType",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Patients");
        }
    }
}
