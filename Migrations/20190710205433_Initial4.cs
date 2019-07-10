using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationID",
                table: "Visits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientID",
                table: "Visits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    Provider = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    VisitID = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Visits_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visits",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<string>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Location_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_LocationID",
                table: "Visits",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientID",
                table: "Visits",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_HospitalId",
                table: "Appointment",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_VisitID",
                table: "Appointment",
                column: "VisitID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_HospitalId",
                table: "Location",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Location_LocationID",
                table: "Visits",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patients_PatientID",
                table: "Visits",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Location_LocationID",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patients_PatientID",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Visits_LocationID",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PatientID",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Visits");
        }
    }
}
