using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HospitalCode",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HospitalContactPersonID",
                table: "Hospitals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HospitalContactPersonID1",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Hospitals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Hospitals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Hospitals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "HospitalContactPersons",
                columns: table => new
                {
                    HospitalContactPersonID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalContactPersons", x => x.HospitalContactPersonID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalContactPersonID1",
                table: "Hospitals",
                column: "HospitalContactPersonID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_HospitalContactPersons_HospitalContactPersonID1",
                table: "Hospitals",
                column: "HospitalContactPersonID1",
                principalTable: "HospitalContactPersons",
                principalColumn: "HospitalContactPersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalContactPersons_HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.DropTable(
                name: "HospitalContactPersons");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "HospitalCode",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "HospitalContactPersonID",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Hospitals");
        }
    }
}
