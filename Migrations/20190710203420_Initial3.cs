using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FamilyName",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientAddressTwo",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UnIdentified",
                table: "Patients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    RelativeID = table.Column<string>(nullable: false),
                    RelativeName = table.Column<string>(nullable: true),
                    RelativeAddress = table.Column<string>(nullable: true),
                    RelationshipType = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false),
                    PatientID1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.RelativeID);
                    table.ForeignKey(
                        name: "FK_Relatives_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relatives_Patients_PatientID1",
                        column: x => x.PatientID1,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitID = table.Column<string>(nullable: false),
                    VisitNote = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    By = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitID);
                    table.ForeignKey(
                        name: "FK_Visits_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vitals",
                columns: table => new
                {
                    VitalID = table.Column<string>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    BMI = table.Column<double>(nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    Pulse = table.Column<double>(nullable: false),
                    RespiratoryRate = table.Column<double>(nullable: false),
                    BloodPressure = table.Column<double>(nullable: false),
                    BloodOxygenSaturation = table.Column<double>(nullable: false),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true),
                    PatientID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitals", x => x.VitalID);
                    table.ForeignKey(
                        name: "FK_Vitals_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vitals_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    DiagnosisID = table.Column<string>(nullable: false),
                    DiagnosisName = table.Column<string>(nullable: true),
                    Primary = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false),
                    VisitID = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.DiagnosisID);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Visits_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visits",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_HospitalId",
                table: "Diagnoses",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_VisitID",
                table: "Diagnoses",
                column: "VisitID");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_HospitalId",
                table: "Relatives",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_PatientID1",
                table: "Relatives",
                column: "PatientID1");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_HospitalId",
                table: "Visits",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Vitals_HospitalId",
                table: "Vitals",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Vitals_PatientID",
                table: "Vitals",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "Vitals");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "FamilyName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAddressTwo",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UnIdentified",
                table: "Patients");
        }
    }
}
