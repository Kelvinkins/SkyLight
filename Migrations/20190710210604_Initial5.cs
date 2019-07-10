using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Hospitals_HospitalId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Visits_VisitID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Hospitals_HospitalId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Location_LocationID",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Location_HospitalId",
                table: "Locations",
                newName: "IX_Locations_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_VisitID",
                table: "Appointments",
                newName: "IX_Appointments_VisitID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_HospitalId",
                table: "Appointments",
                newName: "IX_Appointments_HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Hospitals_HospitalId",
                table: "Appointments",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Visits_VisitID",
                table: "Appointments",
                column: "VisitID",
                principalTable: "Visits",
                principalColumn: "VisitID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Hospitals_HospitalId",
                table: "Locations",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Locations_LocationID",
                table: "Visits",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Hospitals_HospitalId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Visits_VisitID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Hospitals_HospitalId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Locations_LocationID",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_HospitalId",
                table: "Location",
                newName: "IX_Location_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_VisitID",
                table: "Appointment",
                newName: "IX_Appointment_VisitID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_HospitalId",
                table: "Appointment",
                newName: "IX_Appointment_HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Hospitals_HospitalId",
                table: "Appointment",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Visits_VisitID",
                table: "Appointment",
                column: "VisitID",
                principalTable: "Visits",
                principalColumn: "VisitID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Hospitals_HospitalId",
                table: "Location",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Location_LocationID",
                table: "Visits",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
