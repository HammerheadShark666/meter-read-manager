using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeterReadManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class locationmeterdatecreatedmeterreadinglog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ReadingLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Meters",
                type: "nvarchar(250)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1846), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1921), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1931), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 3, 7, 16, 34, 3, 424, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "1 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "2 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "3 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "4 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "1 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "2 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "3 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "4 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "1 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "2 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "3 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 2L, "4 Main Street, Laoth" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "10 Lower Lane, Heaton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "11 Lower Lane, Heaton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "12 Lower Lane, Heaton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "13 Lower Lane, Heaton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "14 Marlon Lane, Larchfield" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "15 Marlon Lane, Larchfield" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "16 Marlon Lane, Larchfield" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "17 Marlon Lane, Larchfield" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "18 Jones Close, Kilton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "19 Jones Close, Kilton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "20 Jones Close, Kilton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "21 Jones Close, Kilton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "38 Derby Street, Milton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "42 Derby Street, Milton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "53 Derby Street, Milton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "62 Derby Street, Milton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "118 Harly Avenue, Olton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "119 Harly Avenue, Olton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "120 Harly Avenue, Olton" });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AccountId", "Location" },
                values: new object[] { 3L, "121 Harly Avenue, Olton" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ReadingLogs");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Meters");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 3, 6, 16, 22, 16, 503, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AccountId",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AccountId",
                value: 0L);
        }
    }
}
