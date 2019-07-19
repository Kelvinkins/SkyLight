using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Hospitals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    OperationCode = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    Extra = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    HospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_Logs_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_HospitalId",
                table: "Logs",
                column: "HospitalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Hospitals");
        }
    }
}
