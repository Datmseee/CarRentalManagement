using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "01a71358-bb3d-4025-b185-1befb115b2e5", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAGgTm3EulaUbqf22EvqptbWDfgoZtYrWK/bOi92nNj4GKQq6Cel4PZcFctUrmOwAA==", null, false, "3f8fb76a-8e8c-4ea8-92bb-0d4653954992", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3228), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3238), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3356), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3358), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3407), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3408), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3409), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3410), new DateTime(2025, 11, 30, 22, 41, 37, 973, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2439), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2449), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2563), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2564), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2627), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2628), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2629), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2631), new DateTime(2025, 11, 30, 22, 33, 21, 318, DateTimeKind.Local).AddTicks(2631) });
        }
    }
}
