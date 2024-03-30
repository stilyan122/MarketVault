using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class UpdateOperationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Operations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 32, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 107, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ProductId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 115, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 39, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 41, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                column: "ProductId",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                column: "ProductId",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 53, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                column: "ProductId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 107, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 78, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                column: "ProductId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 31, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ProductId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 74, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "ProductId",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                column: "ProductId",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "ProductId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                column: "Value",
                value: "777777777777");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 67, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 129, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 144, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                column: "Value",
                value: "111111111111");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateMade", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(502), "1db5c825-2f5e-4646-98dc-52bf094f9bf6" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateMade", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(542), "1db5c825-2f5e-4646-98dc-52bf094f9bf6" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateMade", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(545), "1db5c825-2f5e-4646-98dc-52bf094f9bf6" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateMade", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(547), "7bc64720-42fc-4617-bdfa-a7eb00e7e9de" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateMade", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(549), "7bc64720-42fc-4617-bdfa-a7eb00e7e9de" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(815), 284m, 113m, 340.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(828), 266m, 170m, 319.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(833), 10m, 108m, 12.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(837), 231m, 134m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(840), 9m, 153m, 10.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(844), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(845), 119m, 100m, 142.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(849), 140m, 70m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(852), 97m, 46m, 116.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(856), 226m, 166m, 271.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(859), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(860), 63m, 78m, 75.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(863), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(864), 11m, 20m, 13.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(867), 155m, 21m, 186.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(871), 209m, 138m, 250.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(875), 77m, 76m, 92.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(877), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(878), 130m, 17m, 156.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(881), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(882), 121m, 46m, 145.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(886), 39m, 115m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(890), 19m, 30m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(893), 264m, 8m, 316.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(918), 296m, 135m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(922), 88m, 52m, 105.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(925), 189m, 181m, 226.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(928), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(929), 123m, 155m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(932), 179m, 84m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(936), 5m, 89m, 6.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(939), 131m, 136m, 157.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(943), 22m, 165m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(947), 147m, 75m, 176.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(951), 283m, 116m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(954), 15m, 5m, 18.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(958), 238m, 14m, 285.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(961), 206m, 55m, 247.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(964), 22m, 97m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(969), 264m, 125m, 316.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(972), 16m, 7m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(976), 274m, 5m, 328.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(979), 224m, 45m, 268.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(983), 183m, 115m, 219.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(987), 186m, 107m, 223.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(990), 140m, 84m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1030), 29m, 47m, 34.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1034), 225m, 86m, 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1037), 223m, 94m, 267.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1041), 245m, 155m, 294.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1045), 196m, 37m, 235.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1048), 31m, 181m, 37.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1052), 79m, 93m, 94.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1055), 113m, 175m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1059), 16m, 92m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1062), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1063), 179m, 57m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1066), 96m, 24m, 115.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1070), 169m, 150m, 202.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1074), 184m, 54m, 220.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1077), 155m, 81m, 186.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1080), 153m, 56m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1084), 299m, 85m, 358.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1088), 107m, 49m, 128.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1091), 192m, 37m, 230.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1095), 120m, 43m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1099), 135m, 53m, 162.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1102), 43m, 33m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1125), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1126), 37m, 102m, 44.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1129), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1130), 237m, 90m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1134), 294m, 52m, 352.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1137), 273m, 64m, 327.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1141), 123m, 161m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1144), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1145), 205m, 144m, 246.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1148), 98m, 136m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1151), 182m, 163m, 218.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1153), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1154), 94m, 6m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1158), 123m, 21m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1161), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1162), 153m, 77m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1166), 39m, 20m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1169), 44m, 187m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1173), 163m, 175m, 195.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1176), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1177), 280m, 9m, 336.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1180), 34m, 68m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1184), 188m, 152m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1186), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1187), 221m, 77m, 265.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1190), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1191), 9m, 15m, 10.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1214), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1216), 62m, 5m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1219), 281m, 126m, 337.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1222), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1223), 258m, 104m, 309.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1226), 215m, 44m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1229), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1230), 151m, 47m, 181.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1233), 111m, 55m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1237), 233m, 62m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1240), 68m, 14m, 81.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1244), 111m, 182m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1246), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1247), 190m, 40m, 228.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1250), 119m, 53m, 142.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1254), 80m, 154m, 96.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1256), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1257), 26m, 154m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1261), 274m, 68m, 328.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1264), 85m, 127m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1268), 260m, 57m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1270), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1271), 61m, 38m, 73.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1275), 31m, 3m, 37.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1278), 116m, 0m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1281), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1282), 52m, 109m, 62.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1284), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1286), 300m, 105m, 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1309), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1310), 102m, 107m, 122.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1313), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1314), 90m, 92m, 108.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1317), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1318), 149m, 139m, 178.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1322), 134m, 132m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1324), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1325), 156m, 114m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1327), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1328), 167m, 160m, 200.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1332), 142m, 176m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1336), 10m, 179m, 12.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1339), 284m, 13m, 340.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1341), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1342), 247m, 45m, 296.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1345), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1346), 59m, 107m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1350), 233m, 118m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1353), 253m, 49m, 303.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1356), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1357), 171m, 159m, 205.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1360), 272m, 194m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1363), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1364), 235m, 187m, 282.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1368), 25m, 173m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1372), 57m, 159m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1376), 287m, 135m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1379), 202m, 8m, 242.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1381), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1382), 274m, 186m, 328.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1386), 38m, 161m, 45.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1411), 188m, 56m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1414), 184m, 113m, 220.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1418), 26m, 35m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1421), 114m, 38m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1424), 44m, 20m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1428), 300m, 16m, 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1432), 237m, 158m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1435), 217m, 199m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1439), 283m, 143m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1442), 287m, 139m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1446), 15m, 55m, 18.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1449), 81m, 28m, 97.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1453), 112m, 119m, 134.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1456), 36m, 52m, 43.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1460), 156m, 51m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1463), 283m, 75m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1466), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1467), 39m, 171m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1501), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1502), 155m, 100m, 186.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1505), 34m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1509), 184m, 114m, 220.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1511), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1512), 151m, 22m, 181.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1515), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1516), 16m, 50m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1518), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1519), 288m, 112m, 345.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1523), 74m, 148m, 88.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1525), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1527), 65m, 105m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1530), 210m, 59m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 3, 30, 13, 12, 28, 592, DateTimeKind.Local).AddTicks(1533), 239m, 85m, 286.80m });

            migrationBuilder.CreateIndex(
                name: "IX_Operations_UserId",
                table: "Operations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_AspNetUsers_UserId",
                table: "Operations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_AspNetUsers_UserId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_UserId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Operations");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 78, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 52, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 99, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ProductId",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                column: "ProductId",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                column: "ProductId",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 41, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                column: "ProductId",
                value: 139);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 52, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 15, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                column: "ProductId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 22, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ProductId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "ProductId",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 43, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 79, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                column: "ProductId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "ProductId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                column: "Value",
                value: "555555555555");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                column: "Value",
                value: "999999999999");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 115, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateMade",
                value: new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateMade",
                value: new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateMade",
                value: new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateMade",
                value: new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateMade",
                value: new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9125), 149m, 12m, 178.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9139), 90m, 82m, 108.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9143), 201m, 72m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9147), 57m, 132m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9151), 199m, 130m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9156), 255m, 119m, 306.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9160), 236m, 16m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9164), 225m, 188m, 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9168), 33m, 128m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9172), 2m, 189m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9176), 77m, 141m, 92.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9180), 14m, 184m, 16.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9184), 246m, 59m, 295.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9188), 152m, 66m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9191), 272m, 11m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9386), 101m, 16m, 121.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9399), 279m, 72m, 334.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9406), 53m, 86m, 63.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9410), 43m, 93m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9413), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9414), 164m, 197m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9417), 104m, 20m, 124.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9421), 101m, 79m, 121.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9425), 54m, 154m, 64.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9429), 128m, 92m, 153.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9433), 39m, 109m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9436), 240m, 124m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9440), 262m, 3m, 314.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9444), 170m, 40m, 204.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9447), 285m, 151m, 342.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9450), 26m, 67m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9454), 162m, 112m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9458), 208m, 37m, 249.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9462), 281m, 31m, 337.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9466), 276m, 45m, 331.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9470), 285m, 21m, 342.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9644), 224m, 189m, 268.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9653), 181m, 119m, 217.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9657), 176m, 61m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9660), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9661), 294m, 76m, 352.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9664), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9665), 138m, 92m, 165.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9669), 93m, 142m, 111.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9673), 66m, 10m, 79.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9676), 28m, 183m, 33.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9679), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9680), 114m, 48m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9684), 228m, 108m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9688), 152m, 93m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9692), 75m, 18m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9695), 67m, 179m, 80.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9699), 140m, 198m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9702), 110m, 34m, 132.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9706), 102m, 144m, 122.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9710), 210m, 4m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9712), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9713), 195m, 165m, 234.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9717), 15m, 91m, 18.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9720), 167m, 70m, 200.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9724), 127m, 127m, 152.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9727), 287m, 0m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(84), 257m, 172m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(89), 80m, 37m, 96.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(93), 45m, 60m, 54.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(97), 132m, 180m, 158.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(101), 225m, 177m, 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(105), 288m, 132m, 345.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(109), 179m, 28m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(112), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(113), 2m, 149m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(119), 22m, 20m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(123), 282m, 97m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(127), 264m, 30m, 316.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(129), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(130), 14m, 190m, 16.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(134), 257m, 35m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(137), 152m, 52m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(141), 230m, 72m, 276.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(144), 117m, 158m, 140.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(148), 128m, 82m, 153.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(152), 111m, 119m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(193), 242m, 102m, 290.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(197), 168m, 73m, 201.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(201), 296m, 82m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(205), 19m, 182m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(208), 161m, 54m, 193.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(211), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(212), 18m, 99m, 21.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(216), 283m, 176m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(220), 39m, 98m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(223), 24m, 192m, 28.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(227), 122m, 158m, 146.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(231), 220m, 96m, 264.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(234), 56m, 6m, 67.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(238), 272m, 51m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(242), 190m, 7m, 228.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(244), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(245), 174m, 19m, 208.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(249), 160m, 198m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(252), 2m, 125m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(256), 1m, 64m, 1.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(259), 277m, 93m, 332.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(263), 61m, 187m, 73.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(266), 271m, 115m, 325.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(270), 137m, 118m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(676), 230m, 19m, 276.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(683), 224m, 81m, 268.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(687), 258m, 144m, 309.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(691), 14m, 157m, 16.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(695), 71m, 77m, 85.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(698), 160m, 174m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(702), 170m, 174m, 204.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(706), 253m, 105m, 303.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(710), 263m, 194m, 315.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(713), 230m, 132m, 276.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(717), 18m, 178m, 21.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(721), 44m, 40m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(724), 120m, 175m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(728), 140m, 101m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(732), 281m, 8m, 337.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(735), 95m, 154m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(738), 136m, 130m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(742), 4m, 50m, 4.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(745), 142m, 114m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(749), 246m, 136m, 295.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(752), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(753), 269m, 115m, 322.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(755), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(756), 85m, 86m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1128), 296m, 99m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1134), 46m, 29m, 55.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1138), 168m, 156m, 201.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1142), 250m, 27m, 300.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1144), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1145), 218m, 174m, 261.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1149), 57m, 142m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1153), 91m, 95m, 109.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1157), 117m, 119m, 140.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1161), 199m, 0m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1164), 32m, 168m, 38.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1169), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1171), 202m, 99m, 242.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1175), 94m, 20m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1178), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1179), 55m, 69m, 66.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1183), 7m, 112m, 8.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1186), 248m, 25m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1190), 297m, 79m, 356.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1548), 283m, 47m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1556), 27m, 129m, 32.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1560), 87m, 93m, 104.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1563), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1564), 35m, 176m, 42.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1568), 41m, 180m, 49.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1572), 290m, 6m, 348.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1576), 236m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1579), 236m, 179m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1583), 59m, 196m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1586), 113m, 199m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1589), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1590), 298m, 165m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1594), 293m, 161m, 351.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1597), 229m, 62m, 274.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1601), 76m, 135m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1604), 52m, 22m, 62.40m });
        }
    }
}
