using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeterReadManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptTerms = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CityTown = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CountyId = table.Column<byte>(type: "tinyint", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Counties_CountyId",
                        column: x => x.CountyId,
                        principalTable: "Counties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterNumber = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    MeterTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meters_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meters_MeterTypes_MeterTypeId",
                        column: x => x.MeterTypeId,
                        principalTable: "MeterTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeterReadings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MeterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterReadings_Meters_MeterId",
                        column: x => x.MeterId,
                        principalTable: "Meters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadingLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterId = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingLogs_Meters_MeterId",
                        column: x => x.MeterId,
                        principalTable: "Meters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AcceptTerms", "Created", "Email", "FirstName", "LastName", "PasswordHash", "PasswordReset", "ResetToken", "ResetTokenExpires", "Role", "Title", "Updated", "VerificationToken", "Verified" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), "Admin@hotmail.com", "Admin", "Admin", "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), "C3B17085E1C1371B8875D1374FB96F3450F33E072ABD0C964444E62C0CA855800A118C8C7E7146CE", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 0, "Mr", null, "", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified) },
                    { 2, true, new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), "Customer@hotmail.com", "Customer", "Customer", "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), "C3B17085E1C1371B8875D1374FB96F3450F33E072ABD0C964444E62C0CA855800A118C8C7E7146CE", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 1, "Mr", null, "", new DateTime(2023, 1, 1, 12, 39, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "England" },
                    { 2, "Scotland" },
                    { 3, "Wales" },
                    { 4, "Northern Ireland" }
                });

            migrationBuilder.InsertData(
                table: "MeterTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electric" },
                    { 2, "Gas" },
                    { 3, "Water" },
                    { 4, "Gas/Electric" }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { (byte)1, 1, "West Yorkshire" },
                    { (byte)2, 1, "North Yorkshire" },
                    { (byte)3, 2, "Aberdeenshire" },
                    { (byte)4, 2, "Ross and Cromarty" },
                    { (byte)5, 3, "Breconshire" },
                    { (byte)6, 3, "Gwynedd" },
                    { (byte)7, 4, "Armagh" },
                    { (byte)8, 4, "Londonderry" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddedDate", "Address1", "Address2", "Address3", "CityTown", "CountyId", "Email", "FirstName", "ModifiedDate", "Postcode", "Surname" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2080), "24 Long Road", "Carlton", "East Town", "Leeds", (byte)1, "jackie.jones@hotmail.com", "Jackie", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2128), "LS4 RH4", "Jones" },
                    { 2L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2136), "1 Catoral Close", "Grangestone", "Lower Baildon", "York", (byte)2, "ahmed.patel@hotmail.com", "Ahmed", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2138), "BD34 F45", "Patel" },
                    { 3L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2142), "143 Short Street", "Middleton", null, "Aberdeen", (byte)3, "tony.amos@@hotmail.com", "Tony", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2143), "AD6 CE3", "Amos" },
                    { 4L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2146), "28 Brush Lane", "West Town", null, "Inverurie", (byte)4, "jane.green@hotmail.com", "Jane", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2147), "RS3 NT5", "Green" },
                    { 5L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2150), "65 Carlton Avenue", "Cawley", null, "Hay-on-Wye", (byte)5, "keith.bernstien@hotmail.com", "Keith", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2151), "HY09 PL9", "Bernstien" },
                    { 6L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2156), "36 Mixen Lane", "Soothill", null, "Brecon", (byte)6, "jenny.harper@hotmail.com", "Jenny", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2157), "BR2 KB2", "Harper" },
                    { 7L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2160), "5 Margton Street", "Niverton", null, "Bannfoot", (byte)7, "sandy.denny@hotmail.com", "Sandy", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2162), "BN6 CG5", "Denny" },
                    { 8L, new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2165), "84 Hollow Avenue", "Overton", null, "Bessbrook", (byte)8, "brian.opsoto@hotmail.com", "Brian", new DateTime(2023, 3, 6, 12, 44, 8, 724, DateTimeKind.Local).AddTicks(2166), "BN1 SC3", "Opsoto" }
                });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "Id", "CustomerId", "MeterNumber", "MeterTypeId" },
                values: new object[,]
                {
                    { 1L, 1L, "234378901", 1 },
                    { 2L, 1L, "234378902", 1 },
                    { 3L, 1L, "234378903", 1 },
                    { 4L, 1L, "234378904", 1 },
                    { 5L, 2L, "426565605", 2 },
                    { 6L, 2L, "426565606", 2 },
                    { 7L, 2L, "426565607", 2 },
                    { 8L, 2L, "426565608", 2 },
                    { 9L, 3L, "542356015", 3 },
                    { 10L, 3L, "683534603", 3 },
                    { 11L, 3L, "823234647", 3 },
                    { 12L, 3L, "453459768", 3 },
                    { 13L, 4L, "956756343", 4 },
                    { 14L, 4L, "956756344", 4 },
                    { 15L, 4L, "956756345", 4 },
                    { 16L, 4L, "956756346", 4 },
                    { 17L, 5L, "532787542", 2 },
                    { 18L, 5L, "532787548", 1 },
                    { 19L, 5L, "532787549", 3 },
                    { 20L, 5L, "532787545", 2 },
                    { 21L, 6L, "532787345", 2 },
                    { 22L, 6L, "532784567", 2 },
                    { 23L, 6L, "532781144", 3 },
                    { 24L, 6L, "532783474", 2 },
                    { 25L, 7L, "153397451", 1 },
                    { 26L, 7L, "153397450", 2 },
                    { 27L, 7L, "153397454", 1 },
                    { 28L, 7L, "153397458", 2 },
                    { 29L, 8L, "812234863", 3 },
                    { 30L, 8L, "812234236", 2 },
                    { 31L, 8L, "812234908", 1 },
                    { 32L, 8L, "812234631", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CountryId",
                table: "Counties",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountyId",
                table: "Customers",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterReadings_MeterId",
                table: "MeterReadings",
                column: "MeterId");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_CustomerId",
                table: "Meters",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_MeterTypeId",
                table: "Meters",
                column: "MeterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingLogs_MeterId",
                table: "ReadingLogs",
                column: "MeterId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AccountId",
                table: "RefreshToken",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterReadings");

            migrationBuilder.DropTable(
                name: "ReadingLogs");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Meters");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MeterTypes");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
