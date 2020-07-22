using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalRecordSystem.Data.Migrations
{
    public partial class Update_Appointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Appointments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Appointments");
        }
    }
}
