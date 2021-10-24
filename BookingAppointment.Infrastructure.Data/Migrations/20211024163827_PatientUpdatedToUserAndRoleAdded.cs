using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingAppointment.Infrastructure.Data.Migrations
{
    public partial class PatientUpdatedToUserAndRoleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoleId",
                table: "Patients",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Roles_RoleId",
                table: "Patients",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Roles_RoleId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Patients_RoleId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Patients");
        }
    }
}
