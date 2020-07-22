using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalRecordSystem.Data.Migrations
{
    public partial class UpdatedMd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "MedicalHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "MedicalHistories");
        }
    }
}
