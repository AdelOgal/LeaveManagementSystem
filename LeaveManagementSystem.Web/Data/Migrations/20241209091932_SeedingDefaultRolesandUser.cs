using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05afcd56-4f48-49cd-8dfc-87daf49a4ed5", null, "Supervisor", "SUPERVISOR" },
                    { "278cfc70-3750-4469-9542-8df20d978aae", null, "Administrator", "ADMINISTRATOR" },
                    { "4773b096-25de-44f8-ad56-64fe1410695e", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3477060b-f3a7-407a-bb83-033332353800", 0, "46a54e6a-1f80-45fb-afa2-d507ac27d9a0", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGAm3SVzowFxTOoN2O7mVl4wL09S77iMjh4YP+J/0EedTQJobPUXJx2b/GlU4e/UKw==", null, false, "b2d3a0dc-6f05-447c-a741-3ea1159edffb", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "278cfc70-3750-4469-9542-8df20d978aae", "3477060b-f3a7-407a-bb83-033332353800" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05afcd56-4f48-49cd-8dfc-87daf49a4ed5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4773b096-25de-44f8-ad56-64fe1410695e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "278cfc70-3750-4469-9542-8df20d978aae", "3477060b-f3a7-407a-bb83-033332353800" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "278cfc70-3750-4469-9542-8df20d978aae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3477060b-f3a7-407a-bb83-033332353800");
        }
    }
}
