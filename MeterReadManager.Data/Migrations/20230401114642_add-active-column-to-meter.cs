using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeterReadManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class addactivecolumntometer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RevokedByIp",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReplacedByToken",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByIp",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StatusMessage",
                table: "ReadingLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Meters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ResetToken",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4561), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 4, 1, 12, 46, 42, 209, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Meters",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Active",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Meters");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RevokedByIp",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReplacedByToken",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByIp",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusMessage",
                table: "ReadingLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResetToken",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
