using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingAppointment.Infrastructure.Data.Migrations
{
    public partial class FixedDbAndAddedDateOfBurnToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBorn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBorn",
                table: "Users");
        }
    }
}
