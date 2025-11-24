using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2041), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2054), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2056), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2057), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2207), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2208), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2209), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2210), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2276), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2278), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2278), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2280), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 11, 24, 15, 42, 13, 770, DateTimeKind.Local).AddTicks(2281), "C-HR", "System" }
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
