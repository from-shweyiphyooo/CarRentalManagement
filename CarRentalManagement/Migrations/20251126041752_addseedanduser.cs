using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addseedanduser : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7139974d-ae1f-4859-8251-9fa88f5e9552", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELdwq2R7nqVOWpayOVhyH6n1xagNcdfDanZIIzz8gE5YxC36nfNj3drLpEbrk6S5pg==", null, false, "a2fcddcf-79fa-467c-8e6a-8199d37650d4", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8248), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8265), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8429), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8431), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8498), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8500), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8502), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8503), new DateTime(2025, 11, 26, 12, 17, 52, 262, DateTimeKind.Local).AddTicks(8503) });

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
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(538), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(777), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(844), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(847), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(849), new DateTime(2025, 11, 26, 11, 36, 19, 866, DateTimeKind.Local).AddTicks(849) });
        }
    }
}
