using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dbf33bc-8bd9-4084-8d4d-b622cdc52489", null, "Administrator", "ADMINISTRATOR" },
                    { "c8330efd-b2b4-463b-a30f-debf9ebb9ecd", null, "Employee", "EMPLOYEE" },
                    { "db650501-46b7-4c01-a0bf-1c940c665f57", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c84d3b1f-ac0f-4d52-b242-d0913ef35a87", 0, "8b93cde1-8479-4f02-a847-c65323997777", "admin@localhost", true, false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEAJjjvRVIqg3yp6HOr4BAwexHkYwCnrX78ft+ToLsWRFOvWJiu0vitBuxSKtgBlH7A==", null, false, "ac8f2bf4-9c1f-4fdf-9352-71cca4ec881d", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3dbf33bc-8bd9-4084-8d4d-b622cdc52489", "c84d3b1f-ac0f-4d52-b242-d0913ef35a87" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8330efd-b2b4-463b-a30f-debf9ebb9ecd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db650501-46b7-4c01-a0bf-1c940c665f57");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dbf33bc-8bd9-4084-8d4d-b622cdc52489", "c84d3b1f-ac0f-4d52-b242-d0913ef35a87" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dbf33bc-8bd9-4084-8d4d-b622cdc52489");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c84d3b1f-ac0f-4d52-b242-d0913ef35a87");
        }
    }
}
