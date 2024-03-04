using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class NewColumnsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date when the product was added");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date when the product was last modified");

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
                column: "ProductId",
                value: 122);

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
                column: "ProductId",
                value: 56);

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 53, "999999999999" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 117, "666666666666" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "888888888888" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "888888888888" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "333333333333" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "ProductId",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "555555555555" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "888888888888" });

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
                column: "ProductId",
                value: 51);

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
                column: "ProductId",
                value: 76);

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
                column: "Value",
                value: "111111111111");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "ProductId",
                value: 68);

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
                column: "ProductId",
                value: 76);

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "ProductId",
                value: 77);

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "111111111111" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "888888888888" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "555555555555" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "222222222222" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                column: "Value",
                value: "222222222222");

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                column: "Value",
                value: "555555555555");

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
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8598), 171m, 8m, 205.20m });

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
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8739), 8m, 181m, 9.60m });

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
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(8746), 175m, 187m, 210.00m });

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
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 3, 4, 10, 45, 3, 652, DateTimeKind.Local).AddTicks(9310), 112m, 134.40m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 34, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 106, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 134, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductId",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 136, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                column: "ProductId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 86, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 63, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 79, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 6, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 74, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 43, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 22, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 134, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "ProductId",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 98, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 7, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                column: "ProductId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 25, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ProductId",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                column: "Value",
                value: "222222222222");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "ProductId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 129, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                column: "ProductId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "ProductId",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 32, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 21, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 24, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 115, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                column: "Value",
                value: "666666666666");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 108, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                column: "Value",
                value: "666666666666");

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
                values: new object[] { 136, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 139, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 68, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 99, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 250m, 64m, 300.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 262m, 112m, 314.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 278m, 124m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 86m, 64m, 103.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 177m, 71m, 212.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 151m, 54m, 181.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 120m, 55m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 188m, 144m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 154m, 33m, 184.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 282m, 90m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 69m, 143m, 82.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 254m, 13m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 230m, 110m, 276.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 257m, 155m, 308.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 228m, 135m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 239m, 199m, 286.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 282m, 108m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 195m, 53m, 234.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 44m, 32m, 52.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 114m, 119m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 150m, 130m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 292m, 71m, 350.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 131m, 155m, 157.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 278m, 165m, 333.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 118m, 51m, 141.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 217m, 166m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 298m, 136m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 143m, 99m, 171.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 113m, 124m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 116m, 140m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 221m, 163m, 265.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 270m, 57m, 324.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 103m, 172m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 260m, 125m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 284m, 102m, 340.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 150m, 153m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 17m, 155m, 20.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 137m, 146m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 74m, 116m, 88.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 50m, 132m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 120m, 76m, 144.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 246m, 109m, 295.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 180m, 41m, 216.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 9m, 4m, 10.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 172m, 79m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 164m, 63m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 60m, 141m, 72.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 43m, 111m, 51.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 212m, 104m, 254.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 141m, 3m, 169.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 246m, 6m, 295.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 122m, 121m, 146.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 34m, 9m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 264m, 128m, 316.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 231m, 119m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 93m, 184m, 111.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 170m, 138m, 204.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 125m, 180m, 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 142m, 83m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 25m, 46m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 80m, 58m, 96.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 135m, 2m, 162.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 40m, 46m, 48.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 59m, 161m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 238m, 165m, 285.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 41m, 15m, 49.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 76m, 42m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 176m, 98m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 210m, 23m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 285m, 194m, 342.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 109m, 52m, 130.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 215m, 35m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 231m, 125m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 260m, 102m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 90m, 117m, 108.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 14m, 16m, 16.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 163m, 9m, 195.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 283m, 31m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 82m, 169m, 98.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 187m, 3m, 224.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 168m, 167m, 201.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 136m, 200m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 277m, 171m, 332.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 213m, 160m, 255.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 226m, 122m, 271.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 179m, 147m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 4m, 66m, 4.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 63m, 166m, 75.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 240m, 6m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 63m, 38m, 75.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 191m, 49m, 229.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 25m, 130m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 148m, 158m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 162m, 55m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 76m, 193m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 233m, 163m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 22m, 88m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 172m, 152m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 164m, 113m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 283m, 133m, 339.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 104m, 121m, 124.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 83m, 171m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 58m, 4m, 69.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 255m, 46m, 306.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 4m, 90m, 4.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 76m, 135m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 251m, 43m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 108m, 100m, 129.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 38m, 128m, 45.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 45m, 48m, 54.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 95m, 57m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 269m, 155m, 322.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 94m, 11m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 31m, 132m, 37.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 231m, 89m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 279m, 89m, 334.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 297m, 53m, 356.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 126m, 70m, 151.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 104m, 80m, 124.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 296m, 131m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 157m, 195m, 188.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 116m, 133m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 92m, 55m, 110.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 156m, 170m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 139m, 105m, 166.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 21m, 83m, 25.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 241m, 148m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 298m, 74m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 100m, 200m, 120.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 32m, 145m, 38.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 273m, 84m, 327.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 129m, 192m, 154.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 156m, 157m, 187.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 22m, 30m, 26.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 29m, 116m, 34.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 298m, 164m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 76m, 81m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 90m, 20m, 108.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 287m, 199m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 259m, 20m, 310.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 179m, 140m, 214.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 180m, 38m, 216.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PurchasePrice", "SalePrice" },
                values: new object[] { 252m, 302.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 254m, 122m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 241m, 9m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 271m, 113m, 325.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 204m, 184m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 40m, 174m, 48.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 213m, 74m, 255.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { 140m, 140m, 168.00m });
        }
    }
}
