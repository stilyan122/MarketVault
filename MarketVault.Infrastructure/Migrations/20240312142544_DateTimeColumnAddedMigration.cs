using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class DateTimeColumnAddedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateMade",
                table: "Operations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "DateTime when made");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ProductId",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 78, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 31, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                column: "ProductId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                column: "ProductId",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 43, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                column: "ProductId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                column: "ProductId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 129, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 78, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 137, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                column: "ProductId",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                column: "ProductId",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                column: "ProductId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 25, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                column: "ProductId",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 129, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "ProductId",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                column: "ProductId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "ProductId",
                value: 128);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                column: "ProductId",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                column: "ProductId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                column: "ProductId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 78, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                column: "ProductId",
                value: 114);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 74, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                column: "ProductId",
                value: 118);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 129, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateMade",
                value: new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateMade",
                value: new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateMade",
                value: new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateMade",
                value: new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateMade",
                value: new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5270), 48m, 128m, 57.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5287), 215m, 142m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5291), 97m, 53m, 116.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5294), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5295), 207m, 98m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5299), 51m, 123m, 61.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5304), 62m, 60m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5308), 157m, 63m, 188.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5311), 56m, 83m, 67.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5315), 51m, 83m, 61.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5319), 201m, 59m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5323), 289m, 20m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5326), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5327), 240m, 158m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5352), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5354), 273m, 192m, 327.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5358), 153m, 178m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5362), 265m, 112m, 318.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5365), 223m, 107m, 267.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5368), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5369), 259m, 109m, 310.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5373), 147m, 153m, 176.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5376), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5377), 261m, 67m, 313.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5381), 123m, 36m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5384), 49m, 85m, 58.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5388), 189m, 76m, 226.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5391), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5392), 187m, 54m, 224.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5395), 217m, 179m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5398), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5399), 78m, 32m, 93.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5402), 179m, 31m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5405), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5406), 271m, 132m, 325.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5410), 155m, 139m, 186.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5412), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5413), 246m, 8m, 295.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5417), 137m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5421), 136m, 9m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5423), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5424), 78m, 6m, 93.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5427), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5428), 120m, 77m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5453), 220m, 28m, 264.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5457), 291m, 68m, 349.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5460), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5461), 137m, 192m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5464), 252m, 2m, 302.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5467), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5468), 202m, 85m, 242.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5471), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5472), 8m, 62m, 9.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5475), 197m, 11m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5477), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5479), 164m, 139m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5482), 186m, 32m, 223.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5485), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5486), 72m, 137m, 86.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5490), 87m, 177m, 104.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5493), 176m, 28m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5496), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5497), 37m, 79m, 44.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5500), 57m, 107m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5504), 197m, 98m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5508), 33m, 62m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5512), 67m, 137m, 80.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5515), 235m, 78m, 282.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5518), 209m, 88m, 250.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5522), 204m, 161m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5526), 10m, 143m, 12.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5554), 26m, 161m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5559), 262m, 116m, 314.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5562), 38m, 129m, 45.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5565), 193m, 190m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5569), 24m, 89m, 28.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5573), 19m, 95m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5577), 251m, 7m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5580), 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5584), 160m, 181m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5588), 142m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5592), 95m, 84m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5596), 252m, 134m, 302.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5600), 99m, 197m, 118.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5604), 24m, 194m, 28.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5607), 207m, 81m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5611), 66m, 193m, 79.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5614), 237m, 57m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5618), 277m, 27m, 332.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5643), 188m, 148m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5648), 261m, 51m, 313.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5651), 103m, 107m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5655), 31m, 97m, 37.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5658), 241m, 143m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5662), 23m, 152m, 27.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5666), 40m, 31m, 48.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5669), 174m, 156m, 208.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5673), 202m, 179m, 242.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5675), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5677), 237m, 23m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5679), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5680), 173m, 41m, 207.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5682), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5683), 11m, 69m, 13.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5686), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5687), 105m, 84m, 126.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5690), 272m, 31m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5693), 241m, 112m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5697), 197m, 133m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5700), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5701), 203m, 25m, 243.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5705), 15m, 168m, 18.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5708), 162m, 77m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5712), 138m, 185m, 165.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5715), 174m, 196m, 208.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5719), 193m, 24m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5744), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5745), 6m, 111m, 7.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5748), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5749), 78m, 56m, 93.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5752), 298m, 3m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5757), 27m, 46m, 32.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5759), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5760), 193m, 147m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5762), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5763), 97m, 161m, 116.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5767), 295m, 119m, 354.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5771), 131m, 72m, 157.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5774), 88m, 66m, 105.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5778), 43m, 16m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5781), 82m, 20m, 98.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5785), 10m, 104m, 12.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5789), 233m, 148m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5791), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5792), 112m, 46m, 134.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5794), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5795), 75m, 112m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5799), 166m, 16m, 199.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5802), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5803), 35m, 69m, 42.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5806), 74m, 55m, 88.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5810), 228m, 178m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5812), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5813), 79m, 107m, 94.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5817), 249m, 98m, 298.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5821), 226m, 193m, 271.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5854), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5855), 96m, 98m, 115.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5857), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5859), 162m, 34m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5861), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5862), 98m, 27m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5866), 125m, 200m, 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5869), 25m, 129m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5872), 97m, 116m, 116.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5876), 245m, 2m, 294.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5879), 34m, 10m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5883), 259m, 170m, 310.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5886), 47m, 22m, 56.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5889), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5890), 94m, 35m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5894), 85m, 167m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5897), 233m, 163m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5902), 142m, 26m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5906), 229m, 124m, 274.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5909), 291m, 110m, 349.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5938), 65m, 96m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5942), 259m, 5m, 310.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5945), 244m, 55m, 292.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5948), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5949), 294m, 133m, 352.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5953), 225m, 136m, 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5956), 136m, 167m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5960), 131m, 45m, 157.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5963), 101m, 194m, 121.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5967), 278m, 140m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5970), 217m, 159m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5973), 248m, 131m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5977), 138m, 42m, 165.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5981), 233m, 61m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5984), 226m, 159m, 271.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5988), 258m, 111m, 309.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5991), 107m, 11m, 128.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5994), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5995), 111m, 41m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 3, 12, 16, 25, 43, 383, DateTimeKind.Local).AddTicks(5998), 231m, 111m, 277.20m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateMade",
                table: "Operations");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 31, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 22, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ProductId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 46, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 74, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                column: "ProductId",
                value: 145);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                column: "ProductId",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                column: "ProductId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                column: "ProductId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 150, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                column: "ProductId",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                column: "ProductId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 32, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                column: "ProductId",
                value: 146);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                column: "ProductId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 46, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                column: "ProductId",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 31, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 136, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "ProductId",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                column: "ProductId",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 39, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "ProductId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                column: "ProductId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                column: "ProductId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                column: "ProductId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                column: "ProductId",
                value: 141);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 53, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                column: "ProductId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 117, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8395), 169m, 25m, 202.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8415), 124m, 76m, 148.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8420), 232m, 51m, 278.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8425), 204m, 62m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8429), 6m, 146m, 7.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8433), 211m, 126m, 253.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8465), 160m, 170m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8469), 59m, 179m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8472), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8473), 234m, 194m, 280.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8476), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8477), 43m, 36m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8481), 191m, 159m, 229.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8485), 288m, 129m, 345.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8487), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8488), 208m, 56m, 249.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8492), 44m, 183m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8495), 2m, 103m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8499), 201m, 13m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8502), 239m, 22m, 286.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8506), 45m, 26m, 54.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8510), 55m, 187m, 66.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8513), 199m, 33m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8516), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8517), 178m, 33m, 213.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8520), 77m, 41m, 92.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8524), 154m, 152m, 184.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8527), 80m, 168m, 96.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8532), 153m, 170m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8535), 166m, 35m, 199.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8586), 144m, 165m, 172.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8591), 45m, 117m, 54.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8594), 134m, 21m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8598), 171m, 205.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8601), 56m, 171m, 67.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8605), 183m, 11m, 219.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8609), 194m, 129m, 232.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8613), 32m, 25m, 38.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8616), 300m, 46m, 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8620), 46m, 127m, 55.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8624), 136m, 132m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8628), 211m, 44m, 253.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8631), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8632), 152m, 140m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8635), 96m, 144m, 115.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8639), 211m, 193m, 253.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8642), 105m, 177m, 126.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8646), 197m, 159m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8649), 201m, 167m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8653), 48m, 131m, 57.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8656), 187m, 70m, 224.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8660), 89m, 166m, 106.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8688), 283m, 188m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8692), 191m, 142m, 229.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8696), 77m, 52m, 92.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8699), 251m, 195m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8703), 252m, 152m, 302.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8706), 65m, 186m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8709), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8710), 197m, 80m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8714), 150m, 188m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8717), 183m, 69m, 219.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8721), 216m, 81m, 259.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8724), 215m, 172m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8728), 4m, 136m, 4.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8731), 209m, 44m, 250.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8735), 276m, 105m, 331.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8739), 181m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8742), 271m, 80m, 325.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8746), 187m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8749), 91m, 63m, 109.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8754), 282m, 23m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8815), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8817), 169m, 181m, 202.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8820), 274m, 145m, 328.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8824), 42m, 182m, 50.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8827), 75m, 59m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8830), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8831), 91m, 4m, 109.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8834), 35m, 41m, 42.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8838), 119m, 63m, 142.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8842), 190m, 33m, 228.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8845), 289m, 142m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8849), 56m, 61m, 67.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8852), 95m, 0m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8856), 152m, 187m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8860), 203m, 95m, 243.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8862), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8863), 157m, 6m, 188.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8865), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8866), 20m, 20m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8869), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8870), 134m, 48m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8872), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8873), 162m, 75m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8876), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8877), 72m, 49m, 86.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8881), 271m, 108m, 325.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8884), 260m, 123m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8887), 267m, 61m, 320.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8944), 84m, 55m, 100.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8948), 83m, 91m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8952), 36m, 130m, 43.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8954), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8956), 85m, 133m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8958), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8959), 223m, 125m, 267.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8963), 87m, 190m, 104.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8966), 143m, 169m, 171.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8970), 287m, 138m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8972), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8973), 188m, 192m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8976), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8977), 231m, 127m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8979), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8981), 35m, 189m, 42.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8984), 199m, 126m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8988), 34m, 139m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8991), 44m, 88m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8993), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8994), 48m, 20m, 57.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8998), 83m, 60m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9002), 143m, 54m, 171.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9005), 76m, 176m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9008), 181m, 2m, 217.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9012), 165m, 103m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9015), 30m, 3m, 36.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9019), 290m, 184m, 348.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9091), 261m, 106m, 313.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9094), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9095), 274m, 184m, 328.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9099), 286m, 68m, 343.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9103), 172m, 116m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9105), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9106), 119m, 200m, 142.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9110), 212m, 165m, 254.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9114), 4m, 184m, 4.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9118), 94m, 173m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9121), 210m, 138m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9124), 69m, 87m, 82.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9128), 51m, 30m, 61.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9131), 239m, 115m, 286.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9135), 166m, 118m, 199.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9138), 13m, 58m, 15.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9142), 233m, 91m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9145), 291m, 180m, 349.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9148), 142m, 25m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9152), 160m, 191m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9155), 148m, 162m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9159), 157m, 139m, 188.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9264), 204m, 50m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9268), 223m, 66m, 267.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9272), 72m, 81m, 86.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9275), 297m, 152m, 356.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9278), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9279), 74m, 164m, 88.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9282), 13m, 119m, 15.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9284), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9285), 160m, 95m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9289), 219m, 187m, 262.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9292), 236m, 200m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9296), 258m, 112m, 309.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9299), 95m, 33m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9303), 43m, 141m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9306), 20m, 152m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9310), 112m, 158m, 134.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9313), 110m, 63m, 132.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9316), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9317), 53m, 21m, 63.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9321), 93m, 1m, 111.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9325), 98m, 24m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9409), 210m, 70m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9412), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9413), 67m, 142m, 80.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9415), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9416), 269m, 50m, 322.80m });
        }
    }
}
