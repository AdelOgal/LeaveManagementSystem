using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3477060b-f3a7-407a-bb83-033332353800",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2230fa70-6b2b-4bfe-9961-ff1815dbca9f", new DateOnly(2001, 12, 6), "Default", "Admin", "AQAAAAIAAYagAAAAEJrz8uvq7VTBNmrwutyVYb1WphmWhGcFk7G9ATQJS30yHrinhSQRdzWkot0CecqzOQ==", "ef9f6eae-8d77-4323-afe8-3055ac2db1ef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3477060b-f3a7-407a-bb83-033332353800",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46a54e6a-1f80-45fb-afa2-d507ac27d9a0", "AQAAAAIAAYagAAAAEGAm3SVzowFxTOoN2O7mVl4wL09S77iMjh4YP+J/0EedTQJobPUXJx2b/GlU4e/UKw==", "b2d3a0dc-6f05-447c-a741-3ea1159edffb" });
        }
    }
}
