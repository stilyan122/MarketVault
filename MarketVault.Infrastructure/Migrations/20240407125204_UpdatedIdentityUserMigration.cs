using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class UpdatedIdentityUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 22, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 115, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductId",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 74, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 144, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                column: "ProductId",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                column: "ProductId",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                column: "ProductId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 148, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 79, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 144, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "ProductId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                column: "ProductId",
                value: 113);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 32, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 67, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 39, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 117, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 52, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                column: "ProductId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 144, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "ProductId",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                column: "Value",
                value: "111111111111");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                column: "Value",
                value: "777777777777");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 107, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 67, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                column: "ProductId",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                column: "ProductId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                column: "ProductId",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                column: "ProductId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1083), 50m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1100), 41m, 108m, 49.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1105), 108m, 19m, 129.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1110), 111m, 11m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1113), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1114), 289m, 67m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1119), 210m, 136m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1122), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1123), 86m, 189m, 103.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1127), 145m, 144m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1131), 232m, 178m, 278.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1136), 39m, 127m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1139), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1140), 278m, 68m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1143), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1144), 237m, 60m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1149), 141m, 101m, 169.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1153), 176m, 27m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1157), 210m, 0m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1159), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1160), 61m, 170m, 73.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1164), 252m, 43m, 302.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1206), 140m, 184m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1208), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1209), 170m, 186m, 204.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1212), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1213), 294m, 187m, 352.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1217), 54m, 131m, 64.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1221), 20m, 116m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1223), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1225), 229m, 191m, 274.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1229), 115m, 2m, 138.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1231), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1233), 212m, 86m, 254.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1237), 289m, 48m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1240), 196m, 48m, 235.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1244), 134m, 130m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1248), 47m, 43m, 56.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1253), 197m, 86m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1256), 34m, 197m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1260), 293m, 128m, 351.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1264), 69m, 15m, 82.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1269), 248m, 148m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1273), 283m, 6m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1276), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1277), 226m, 121m, 271.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1799), 73m, 109m, 87.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1809), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1811), 112m, 188m, 134.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1813), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1815), 270m, 9m, 324.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1818), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1819), 62m, 128m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1822), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1823), 281m, 149m, 337.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1827), 66m, 21m, 79.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1829), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1831), 150m, 1m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1834), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1835), 174m, 121m, 208.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1837), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1838), 172m, 101m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1841), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1842), 111m, 162m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1847), 88m, 117m, 105.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1851), 97m, 154m, 116.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1854), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1855), 73m, 149m, 87.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1858), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1859), 213m, 86m, 255.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1862), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1863), 230m, 165m, 276.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1867), 145m, 128m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1871), 217m, 90m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1876), 205m, 8m, 246.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1879), 103m, 114m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1883), 198m, 169m, 237.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1887), 11m, 98m, 13.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(1891), 16m, 84m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2243), 122m, 58m, 146.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2251), 33m, 92m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2257), 92m, 118m, 110.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2263), 81m, 39m, 97.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2267), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2268), 16m, 89m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2271), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2272), 164m, 192m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2276), 13m, 114m, 15.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2283), 37m, 99m, 44.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2288), 20m, 36m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2291), 13m, 131m, 15.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2294), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2295), 6m, 118m, 7.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2299), 286m, 15m, 343.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2303), 56m, 64m, 67.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2306), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2307), 240m, 153m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2310), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2311), 57m, 129m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2315), 238m, 124m, 285.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2317), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2319), 12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2323), 248m, 172m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2327), 289m, 86m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2803), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2806), 83m, 117m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2811), 210m, 9m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2813), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2814), 238m, 103m, 285.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2817), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2818), 41m, 169m, 49.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2821), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2823), 282m, 135m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2827), 96m, 120m, 115.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2831), 145m, 136m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2835), 290m, 55m, 348.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2839), 44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2842), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2843), 223m, 63m, 267.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2848), 153m, 26m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2850), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2852), 147m, 197m, 176.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2855), 228m, 160m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2858), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2859), 127m, 38m, 152.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2862), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2863), 233m, 162m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2867), 268m, 115m, 321.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2871), 242m, 4m, 290.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2874), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2875), 34m, 6m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2878), 152m, 199m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2882), 103m, 85m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(2886), 49m, 29m, 58.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3326), 146m, 52m, 175.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3335), 154m, 119m, 184.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3340), 23m, 1m, 27.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3342), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3344), 199m, 169m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3348), 169m, 160m, 202.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3352), 201m, 189m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3356), 103m, 179m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3360), 224m, 63m, 268.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3364), 110m, 113m, 132.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3368), 164m, 51m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3372), 268m, 182m, 321.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3374), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3375), 239m, 133m, 286.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3379), 118m, 112m, 141.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3382), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3383), 188m, 156m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3386), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3387), 163m, 32m, 195.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3389), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3391), 100m, 138m, 120.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3394), 197m, 147m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3397), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3399), 202m, 198m, 242.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3402), 244m, 61m, 292.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3406), 237m, 27m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3410), 12m, 74m, 14.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3413), 208m, 91m, 249.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3623), 292m, 8m, 350.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3633), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3635), 143m, 99m, 171.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3640), 156m, 98m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3644), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3646), 204m, 58m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3652), 251m, 138m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3655), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3657), 94m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3661), 229m, 67m, 274.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3665), 279m, 65m, 334.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3668), 123m, 165m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3676), 256m, 189m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3680), 198m, 98m, 237.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3683), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3684), 267m, 96m, 320.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3687), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3688), 1m, 177m, 1.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3692), 145m, 49m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3695), 156m, 190m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3699), 26m, 155m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(3703), 165m, 133m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4117), 117m, 59m, 140.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4122), 148m, 16m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4125), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4126), 164m, 196m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4131), 192m, 28m, 230.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4135), 256m, 91m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4139), 116m, 186m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4143), 12m, 16m, 14.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4147), 216m, 15m, 259.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4151), 231m, 191m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4155), 287m, 43m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4159), 280m, 148m, 336.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4163), 249m, 17m, 298.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 4, 7, 15, 52, 2, 569, DateTimeKind.Local).AddTicks(4167), 147m, 30m, 176.40m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 53, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 41, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 43, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 46, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 58, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 52, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                column: "ProductId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                column: "ProductId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                column: "ProductId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 67, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 22, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 96, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 52, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "ProductId",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                column: "ProductId",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 26, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 39, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                column: "ProductId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 115, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 58, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 79, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "ProductId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 9, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                column: "Value",
                value: "222222222222");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 147, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                column: "Value",
                value: "444444444444");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 126, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                column: "ProductId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                column: "ProductId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 39, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                column: "ProductId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                column: "ProductId",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(258), 272m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(280), 240m, 195m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(285), 278m, 49m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(289), 62m, 199m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(293), 31m, 64m, 37.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(297), 70m, 154m, 84.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(301), 229m, 39m, 274.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(304), 197m, 17m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(308), 16m, 90m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(313), 189m, 170m, 226.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(316), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(317), 257m, 146m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(321), 96m, 118m, 115.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(325), 29m, 43m, 34.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(327), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(328), 287m, 63m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(366), 19m, 148m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(370), 28m, 160m, 33.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(374), 76m, 10m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(377), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(378), 253m, 102m, 303.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(382), 290m, 142m, 348.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(386), 193m, 70m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(389), 201m, 118m, 241.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(393), 171m, 149m, 205.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(397), 139m, 178m, 166.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(401), 79m, 81m, 94.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(405), 254m, 56m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(409), 39m, 196m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(411), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(413), 282m, 33m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(415), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(416), 88m, 66m, 105.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(420), 39m, 91m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(424), 54m, 116m, 64.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(427), 193m, 40m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(431), 237m, 99m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(435), 196m, 28m, 235.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(439), 103m, 131m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(479), 47m, 135m, 56.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(483), 237m, 49m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(487), 247m, 60m, 296.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(490), 243m, 42m, 291.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(493), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(494), 145m, 81m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(498), 242m, 56m, 290.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(501), 42m, 146m, 50.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(505), 100m, 5m, 120.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(509), 6m, 109m, 7.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(512), 268m, 55m, 321.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(516), 299m, 85m, 358.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(520), 215m, 133m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(524), 278m, 10m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(528), 49m, 91m, 58.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(531), 54m, 198m, 64.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(535), 222m, 135m, 266.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(539), 66m, 66m, 79.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(542), 222m, 134m, 266.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(546), 2m, 101m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(550), 279m, 84m, 334.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(554), 109m, 172m, 130.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(591), 248m, 3m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(595), 194m, 140m, 232.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(599), 231m, 104m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(601), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(602), 124m, 150m, 148.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(606), 259m, 103m, 310.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(609), 47m, 116m, 56.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(613), 86m, 128m, 103.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(616), 82m, 61m, 98.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(620), 105m, 56m, 126.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(624), 245m, 95m, 294.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(628), 22m, 92m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(632), 68m, 70m, 81.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(635), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(636), 158m, 85m, 189.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(639), 40m, 26m, 48.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(643), 250m, 90m, 300.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(646), 85m, 173m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(650), 249m, 33m, 298.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(654), 59m, 99m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(658), 241m, 15m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(710), 23m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(713), 255m, 24m, 306.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(717), 62m, 177m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(721), 194m, 118m, 232.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(724), 46m, 154m, 55.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(728), 294m, 45m, 352.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(732), 164m, 139m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(736), 154m, 87m, 184.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(740), 94m, 197m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(744), 256m, 10m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(748), 154m, 170m, 184.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(751), 27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(755), 120m, 169m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(758), 57m, 165m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(762), 140m, 175m, 168.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(766), 263m, 90m, 315.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(769), 136m, 178m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(773), 207m, 100m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(775), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(776), 285m, 2m, 342.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(780), 99m, 110m, 118.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(783), 176m, 85m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(787), 300m, 89m, 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(825), 34m, 48m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(829), 164m, 96m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(833), 65m, 159m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(836), 60m, 194m, 72.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(840), 257m, 144m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(844), 207m, 192m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(848), 219m, 26m, 262.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(851), 212m, 110m, 254.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(855), 244m, 46m, 292.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(859), 128m, 96m, 153.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(862), 29m, 66m, 34.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(866), 35m, 104m, 42.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(869), 19m, 21m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(873), 218m, 180m, 261.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(876), 65m, 50m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(880), 207m, 168m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(883), 222m, 5m, 266.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(886), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(887), 172m, 162m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(891), 26m, 175m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(895), 265m, 150m, 318.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(897), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(898), 185m, 149m, 222.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(936), 98m, 102m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(940), 105m, 116m, 126.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(944), 248m, 80m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(948), 127m, 33m, 152.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(951), 176m, 2m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(955), 83m, 80m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(959), 152m, 168m, 182.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(962), 55m, 151m, 66.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(965), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(966), 98m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(969), 235m, 68m, 282.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(972), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(973), 132m, 88m, 158.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(976), 219m, 32m, 262.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(981), 265m, 75m, 318.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(985), 55m, 69m, 66.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(988), 273m, 20m, 327.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(992), 18m, 6m, 21.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(995), 228m, 123m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1032), 257m, 78m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1036), 123m, 175m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1040), 123m, 43m, 147.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1044), 298m, 41m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1047), 142m, 133m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1051), 57m, 76m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1055), 114m, 115m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1058), 166m, 162m, 199.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1062), 147m, 67m, 176.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1066), 135m, 128m, 162.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1069), 34m, 132m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1073), 158m, 193m, 189.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1076), 248m, 157m, 297.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1080), 102m, 22m, 122.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1083), 46m, 52m, 55.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1087), 234m, 81m, 280.80m });
        }
    }
}
