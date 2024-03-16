using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class ChangesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Firms",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Firm Phone Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Firm Phone Number");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "333333333333" });

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
                values: new object[] { 121, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 31, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 107, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 27, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 88, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ProductId",
                value: 118);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                column: "ProductId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 117, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 43, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 97, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 150, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 49, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                column: "ProductId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 58, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 117, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 40, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 5, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 103, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 107, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 58, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 56, "555555555555" });

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
                values: new object[] { 17, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 146, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                column: "ProductId",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                column: "Value",
                value: "555555555555");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 50, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 77, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "ProductId",
                value: 116);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 145, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 15, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 109, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                column: "ProductId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "ProductId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "ProductId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                column: "Value",
                value: "333333333333");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "333333333333" });

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
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 69, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 71, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 122, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 48, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 14, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 76, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 73, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 85, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 124, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                column: "ProductId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 113, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 58, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 87, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 134, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8940), 13m, 91m, 15.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8954), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8955), 159m, 151m, 190.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8958), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8959), 111m, 193m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8963), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8964), 195m, 44m, 234.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8967), 209m, 180m, 250.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8972), 72m, 43m, 86.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8976), 126m, 102m, 151.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8979), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8980), 69m, 19m, 82.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8983), 287m, 162m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8988), 225m, 41m, 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8992), 164m, 148m, 196.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8996), 75m, 98m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9000), 254m, 172m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9567), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9570), 194m, 44m, 232.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9576), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9578), 87m, 108m, 104.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9581), 94m, 35m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9585), 119m, 121m, 142.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9591), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9592), 296m, 176m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9596), 206m, 170m, 247.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9600), 173m, 95m, 207.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9604), 232m, 190m, 278.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9608), 159m, 141m, 190.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9611), 256m, 146m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9615), 218m, 113m, 261.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9619), 45m, 63m, 54.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9621), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9622), 217m, 153m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9626), 98m, 69m, 117.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9629), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9630), 233m, 83m, 279.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9634), 106m, 86m, 127.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9638), 131m, 135m, 157.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9642), 171m, 139m, 205.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9646), 19m, 52m, 22.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9649), 258m, 0m, 309.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9691), 107m, 87m, 128.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9695), 34m, 36m, 40.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9698), 254m, 162m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9702), 158m, 97m, 189.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9706), 199m, 160m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9709), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9710), 77m, 92m, 92.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9712), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9713), 33m, 77m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9717), 211m, 14m, 253.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9721), 114m, 160m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9723), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9724), 185m, 52m, 222.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9727), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9728), 91m, 12m, 109.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9731), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9732), 57m, 66m, 68.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9736), 117m, 45m, 140.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9740), 128m, 66m, 153.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9743), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9744), 193m, 76m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9748), 64m, 188m, 76.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9751), 266m, 65m, 319.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9755), 275m, 14m, 330.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9758), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9759), 20m, 171m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9761), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9762), 204m, 199m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9766), 92m, 196m, 110.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9804), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9805), 213m, 105m, 255.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9810), 101m, 134m, 121.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9813), 150m, 163m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9816), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9817), 115m, 103m, 138.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9821), 101m, 160m, 121.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9824), 198m, 61m, 237.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9828), 177m, 15m, 212.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9830), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9832), 132m, 118m, 158.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9835), 284m, 90m, 340.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9838), 289m, 77m, 346.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9842), 28m, 158m, 33.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9846), 73m, 152m, 87.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9850), 9m, 132m, 10.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9853), 49m, 108m, 58.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9857), 62m, 136m, 74.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9860), 122m, 190m, 146.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9864), 147m, 182m, 176.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9867), 75m, 164m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9871), 103m, 157m, 123.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9910), 222m, 185m, 266.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9914), 236m, 113m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9917), 184m, 71m, 220.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9921), 215m, 15m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9924), 291m, 93m, 349.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9928), 165m, 81m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9932), 240m, 97m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9935), 245m, 81m, 294.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9938), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9939), 25m, 25m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9942), 256m, 7m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9946), 219m, 38m, 262.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9950), 162m, 46m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9954), 237m, 108m, 284.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9957), 15m, 96m, 18.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9961), 89m, 119m, 106.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9964), 187m, 200m, 224.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9968), 217m, 93m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9972), 247m, 74m, 296.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9975), 127m, 21m, 152.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9978), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9979), 293m, 75m, 351.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9983), 53m, 24m, 63.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 3, 16, 14, 23, 11, 935, DateTimeKind.Local).AddTicks(9986), 136m, 142m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(25), 63m, 148m, 75.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(29), 170m, 82m, 204.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(32), 141m, 161m, 169.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(36), 153m, 153m, 183.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(39), 236m, 197m, 283.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(43), 16m, 149m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(47), 151m, 0m, 181.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(51), 95m, 13m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(54), 137m, 151m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(58), 174m, 34m, 208.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(61), 296m, 192m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(65), 269m, 132m, 322.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(69), 172m, 184m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(73), 193m, 75m, 231.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(76), 137m, 111m, 164.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(80), 81m, 81m, 97.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(84), 134m, 117m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(87), 182m, 92m, 218.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(91), 263m, 23m, 315.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(94), 117m, 9m, 140.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(98), 110m, 48m, 132.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(674), 6m, 75m, 7.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(683), 231m, 116m, 277.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(687), 113m, 31m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(690), 130m, 160m, 156.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(695), 160m, 46m, 192.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(698), 14m, 65m, 16.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(702), 148m, 69m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(706), 215m, 111m, 258.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(710), 207m, 62m, 248.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(714), 129m, 130m, 154.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(718), 104m, 118m, 124.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(721), 24m, 9m, 28.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(725), 280m, 66m, 336.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(731), 52m, 116m, 62.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(735), 65m, 182m, 78.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(738), 102m, 161m, 122.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(742), 127m, 140m, 152.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(795), 116m, 75m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(799), 39m, 75m, 46.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(803), 182m, 79m, 218.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(807), 190m, 67m, 228.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(810), 295m, 151m, 354.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(814), 112m, 74m, 134.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(818), 298m, 125m, 357.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(821), 188m, 59m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(825), 136m, 161m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(829), 46m, 9m, 55.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(832), 282m, 35m, 338.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(836), 251m, 24m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(838), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(840), 51m, 138m, 61.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(842), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(843), 30m, 22m, 36.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(847), 125m, 199m, 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(850), 92m, 185m, 110.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 3, 16, 14, 23, 11, 936, DateTimeKind.Local).AddTicks(854), 278m, 134m, 333.60m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Firms",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Firm Phone Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Firm Phone Number");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 59, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 61, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 62, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 28, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 119, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 144, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 92, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 95, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 29, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 33, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 114, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 2, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductId",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ProductId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 134, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 37,
                column: "ProductId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 131, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 133, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 11, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 137, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 46, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 23, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 123, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 150, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 102, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 149, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 54,
                column: "ProductId",
                value: 145);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 101, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 128, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 70, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 75, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 140, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 60, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 38, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 136, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 81, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 37, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 143, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 130, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 65, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 90, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 82, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 91, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 19, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 116, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 15, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 36, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 45, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 86,
                column: "ProductId",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 104, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 89, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 92,
                column: "Value",
                value: "222222222222");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 17, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 83, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 44, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 138, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 57, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "ProductId",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 64, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 100, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 55, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 106,
                column: "ProductId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "ProductId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 12, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "ProductId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 110,
                column: "Value",
                value: "777777777777");

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 120, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 105, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 127, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 110, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 93, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 8, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 51, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 66, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 10, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 72, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 125, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 132, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 118, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 18, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 84, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 16, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 94, "555555555555" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "111111111111" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 20, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 54, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 80, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 142, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 4, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 35, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 139,
                column: "ProductId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 141, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 121, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 46, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 47, "999999999999" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 111, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 30, "777777777777" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 112, "888888888888" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, "666666666666" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 135, "333333333333" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 13, "444444444444" });

            migrationBuilder.UpdateData(
                table: "Barcodes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 42, "222222222222" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateMade",
                value: new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5048), 261m, 177m, 313.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5063), 53m, 147m, 63.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5068), 113m, 49m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5072), 40m, 56m, 48.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5076), 250m, 66m, 300.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5081), 79m, 26m, 94.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5084), 110m, 99m, 132.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5088), 20m, 101m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5092), 187m, 81m, 224.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5097), 23m, 38m, 27.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5100), 181m, 9m, 217.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5104), 296m, 5m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5132), 85m, 56m, 102.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5136), 50m, 111m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5139), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5140), 78m, 140m, 93.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5143), 265m, 24m, 318.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5147), 268m, 26m, 321.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5151), 181m, 107m, 217.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5155), 130m, 21m, 156.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5159), 287m, 104m, 344.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5163), 75m, 122m, 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5167), 118m, 152m, 141.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5171), 84m, 26m, 100.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5175), 129m, 1m, 154.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5179), 269m, 39m, 322.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5182), 216m, 31m, 259.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5186), 276m, 24m, 331.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5189), 150m, 80m, 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5192), 256m, 93m, 307.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5196), 165m, 171m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5199), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5200), 114m, 197m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5204), 61m, 80m, 73.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5208), 7m, 103m, 8.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5235), 93m, 133m, 111.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5238), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5239), 232m, 60m, 278.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5243), 165m, 196m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5246), 213m, 102m, 255.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5250), 290m, 49m, 348.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5253), 149m, 82m, 178.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5257), 217m, 93m, 260.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5261), 27m, 99m, 32.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5263), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5264), 138m, 100m, 165.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5267), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5268), 269m, 9m, 322.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5272), 24m, 69m, 28.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5274), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5275), 124m, 140m, 148.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5279), 84m, 183m, 100.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5282), 204m, 17m, 244.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5286), 264m, 56m, 316.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5289), 95m, 138m, 114.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5293), 84m, 5m, 100.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5297), 135m, 187m, 162.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5301), 115m, 41m, 138.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5304), 50m, 72m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5308), 272m, 185m, 326.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5334), 50m, 162m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5338), 270m, 148m, 324.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5341), 244m, 147m, 292.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5345), 296m, 121m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5348), 240m, 184m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5352), 192m, 198m, 230.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5355), 72m, 187m, 86.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5359), 133m, 17m, 159.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5361), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5363), 253m, 14m, 303.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5366), 129m, 105m, 154.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5370), 118m, 137m, 141.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5373), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5374), 136m, 82m, 163.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5378), 210m, 168m, 252.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5381), 76m, 22m, 91.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5384), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5385), 121m, 164m, 145.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5388), 142m, 107m, 170.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5392), 59m, 126m, 70.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5395), 148m, 159m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5423), 16m, 91m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5427), 296m, 191m, 355.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5429), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5431), 240m, 39m, 288.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5433), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5434), 162m, 51m, 194.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5438), 273m, 84m, 327.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5441), 102m, 156m, 122.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5445), 222m, 91m, 266.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5449), 82m, 40m, 98.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5453), 157m, 125m, 188.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5457), 158m, 133m, 189.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5459), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5460), 176m, 196m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5464), 2m, 140m, 2.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5467), 93m, 92m, 111.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5469), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5471), 198m, 99m, 237.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5474), 26m, 4m, 31.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5477), 199m, 137m, 238.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5481), 165m, 187m, 198.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5483), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5484), 251m, 106m, 301.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5486), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5487), 148m, 184m, 177.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5491), 260m, 137m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5495), 113m, 94m, 135.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5498), 191m, 137m, 229.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5537), 190m, 33m, 228.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5541), 94m, 109m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5545), 130m, 195m, 156.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5549), 253m, 170m, 303.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5552), 25m, 192m, 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5556), 260m, 93m, 312.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5560), 200m, 190m, 240.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5562), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5563), 281m, 70m, 337.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5567), 214m, 127m, 256.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5570), 33m, 187m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5574), 81m, 99m, 97.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5576), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5578), 196m, 160m, 235.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5580), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5581), 99m, 133m, 118.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5585), 188m, 53m, 225.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5588), 114m, 170m, 136.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5592), 145m, 93m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5594), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5595), 181m, 199m, 217.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5598), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5599), 241m, 19m, 289.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5602), 108m, 15m, 129.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5606), 42m, 101m, 50.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5610), 172m, 93m, 206.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5614), 20m, 20m, 24.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5641), 247m, 69m, 296.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5645), 280m, 87m, 336.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5648), 116m, 118m, 139.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5652), 111m, 57m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5656), 176m, 1m, 211.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5659), 189m, 77m, 226.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5664), 177m, 58m, 212.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5668), 228m, 178m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5672), 16m, 40m, 19.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5675), 141m, 120m, 169.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5678), 177m, 106m, 212.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5681), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5682), 83m, 156m, 99.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5685), 145m, 155m, 174.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5690), 50m, 26m, 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5694), 109m, 120m, 130.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5697), 297m, 48m, 356.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5724), 33m, 89m, 39.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5728), 94m, 41m, 112.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5732), 178m, 70m, 213.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5736), 134m, 80m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5739), 228m, 91m, 273.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5743), 254m, 140m, 304.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5747), 279m, 48m, 334.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5750), 111m, 30m, 133.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5754), 197m, 78m, 236.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5757), 51m, 175m, 61.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5761), 47m, 38m, 56.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5764), 134m, 105m, 160.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5768), 151m, 57m, 181.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5771), 78m, 173m, 93.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5775), 5m, 158m, 6.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5778), 41m, 1m, 49.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5781), 144m, 125m, 172.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateAdded", "DateModified", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[] { new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5785), 135m, 11m, 162.00m });
        }
    }
}
