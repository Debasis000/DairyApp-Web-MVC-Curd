using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDairyEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DairyEntrys",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking with Joe!", new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9479), "Went Hiking" },
                    { 2, "Went Shopping  with Shopping!", new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9823), "Went Shopping" },
                    { 3, "Went Diving  with Diving!", new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9826), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DairyEntrys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DairyEntrys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DairyEntrys",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
