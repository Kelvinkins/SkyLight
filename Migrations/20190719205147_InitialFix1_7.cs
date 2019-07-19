using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class InitialFix1_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalContactPersons_HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "HospitalContactPersonID1",
                table: "Hospitals");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalContactPersonID",
                table: "Hospitals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalContactPersonID",
                table: "Hospitals",
                column: "HospitalContactPersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_HospitalContactPersons_HospitalContactPersonID",
                table: "Hospitals",
                column: "HospitalContactPersonID",
                principalTable: "HospitalContactPersons",
                principalColumn: "HospitalContactPersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalContactPersons_HospitalContactPersonID",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalContactPersonID",
                table: "Hospitals");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalContactPersonID",
                table: "Hospitals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalContactPersonID1",
                table: "Hospitals",
                nullable: true);

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
    }
}
