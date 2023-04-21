using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeterReadManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class addaccountidtometer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeterReadings_Meters_MeterId",
                table: "MeterReadings");

            migrationBuilder.DropIndex(
                name: "IX_MeterReadings_MeterId",
                table: "MeterReadings");

            migrationBuilder.AddColumn<long>(
                name: "AccountId",
                table: "Meters",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Meters");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2136), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.CreateIndex(
                name: "IX_MeterReadings_MeterId",
                table: "MeterReadings",
                column: "MeterId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeterReadings_Meters_MeterId",
                table: "MeterReadings",
                column: "MeterId",
                principalTable: "Meters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
