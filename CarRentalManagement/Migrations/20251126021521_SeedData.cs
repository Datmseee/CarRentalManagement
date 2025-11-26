using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 15, 20, 183, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 11, 26, 10, 15, 20, 183, DateTimeKind.Local).AddTicks(9998), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(2), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(2), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(275), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(277), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(396), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(397), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(398), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(399), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(400), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(401), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(403), new DateTime(2025, 11, 26, 10, 15, 20, 184, DateTimeKind.Local).AddTicks(403), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
