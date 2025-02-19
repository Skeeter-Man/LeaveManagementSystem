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
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c84d3b1f-ac0f-4d52-b242-d0913ef35a87",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbfc1e73-3e32-46c6-bdd8-c2994c3200b9", new DateOnly(1948, 1, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEFAGhatAavjZuu4lvFoOruPmEzCTD3h5GRdHeSt2fuAr84EHUkMKROHokEdA/V/00g==", "f2af02ae-b80b-4f6f-8867-08a911ad1b57" });
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
                keyValue: "c84d3b1f-ac0f-4d52-b242-d0913ef35a87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b93cde1-8479-4f02-a847-c65323997777", "AQAAAAIAAYagAAAAEAJjjvRVIqg3yp6HOr4BAwexHkYwCnrX78ft+ToLsWRFOvWJiu0vitBuxSKtgBlH7A==", "ac8f2bf4-9c1f-4fdf-9352-71cca4ec881d" });
        }
    }
}
