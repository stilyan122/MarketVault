using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Address Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Address Town Name"),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Address Street Name"),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", maxLength: 9999, nullable: false, comment: "Address Street Number"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                },
                comment: "Address Entity Class");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "DocumentType Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "DocumentType Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                },
                comment: "DocumentType Entity Class");

            migrationBuilder.CreateTable(
                name: "ItemGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "ItemGroup Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "ItemGroup Name"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroups", x => x.Id);
                },
                comment: "ItemGroup Entity Class");

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Measure Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, comment: "Measure Name"),
                    CanBeDecimal = table.Column<bool>(type: "bit", nullable: false, comment: "Bool flag - decimal"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.Id);
                },
                comment: "Measure Entity Class");

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Bank Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Bank Name"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity"),
                    AddressId = table.Column<int>(type: "int", nullable: false, comment: "AddressId - FK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Bank Entity Class");

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Firm Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Firm Name"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Firm Phone Number"),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false, comment: "Firm Email"),
                    ResponsiblePersonName = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false, comment: "Firm Responsible Person Name"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity"),
                    AddressId = table.Column<int>(type: "int", nullable: false, comment: "AddressId - FK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firms_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Firm Entity Class");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product Name"),
                    CashRegisterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Product Cash Register Name"),
                    ArticleNumber = table.Column<int>(type: "int", nullable: false, comment: "Product Article Number"),
                    NomenclatureNumber = table.Column<int>(type: "int", nullable: false, comment: "Product Nomenclature Number"),
                    CodeForScales = table.Column<int>(type: "int", nullable: false, comment: "Product Code for scales"),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product Purchase Price"),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product Sale Price"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Product Description"),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product Quantity"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity"),
                    ItemGroupId = table.Column<int>(type: "int", nullable: false, comment: "ItemGroupId - FK"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the product was added"),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the product was last modified")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Product Entity Class");

            migrationBuilder.CreateTable(
                name: "CounterParties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "CounterParty Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity"),
                    VATNumber = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    ValueAddedTaxLawId = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false, comment: "BankId - FK"),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankIBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmId = table.Column<int>(type: "int", nullable: false, comment: "BankId - FK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounterParties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounterParties_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CounterParties_Firms_FirmId",
                        column: x => x.FirmId,
                        principalTable: "Firms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "CounterParty Entity Class");

            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Barcode Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Barcode Value"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flag for activity"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "ProductId - FK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barcodes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Barcode Entity Class");

            migrationBuilder.CreateTable(
                name: "ProductsMeasures",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product Id"),
                    MeasureId = table.Column<int>(type: "int", nullable: false, comment: "Measure Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsMeasures", x => new { x.MeasureId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsMeasures_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsMeasures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "ProductMeasure Entity Class");

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Operation Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false, comment: "DocumentTypeId - FK"),
                    CounterPartyId = table.Column<int>(type: "int", nullable: false, comment: "CounterPartyId - FK"),
                    TotalSalePriceWithoutVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "TotalSalePriceWithoutVAT"),
                    TotalSalePriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "TotalSalePriceWithVAT"),
                    TotalPurchasePriceWithoutVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "TotalPurchasePriceWithoutVAT"),
                    TotalPurchasePriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "TotalPurchasePriceWithVAT"),
                    DateMade = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DateTime when made"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operations_CounterParties_CounterPartyId",
                        column: x => x.CounterPartyId,
                        principalTable: "CounterParties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operations_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Operation Entity Class");

            migrationBuilder.CreateTable(
                name: "ProductsOperations",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product Id"),
                    OperationId = table.Column<int>(type: "int", nullable: false, comment: "Operation Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOperations", x => new { x.OperationId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsOperations_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOperations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "ProductOperation Entity Class");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "IsActive", "StreetName", "StreetNumber", "TownName" },
                values: new object[,]
                {
                    { 1, true, "Main Street", "12, 34", "London" },
                    { 2, true, "Local Street", "45", "Warsaw" },
                    { 3, true, "Maple Avenue", "123", "Springfield" },
                    { 4, true, "Oak Street", "4467, 5645", "Brooksville" },
                    { 5, true, "Pine Road", "789", "Lakeside" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tax invoice" },
                    { 2, "Bill of goods" },
                    { 3, "Waste" },
                    { 4, "Discharge" }
                });

            migrationBuilder.InsertData(
                table: "ItemGroups",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Ice Cream" },
                    { 2, true, "Fizzy Drinks" },
                    { 3, true, "Alcohol" },
                    { 4, true, "Dairy" },
                    { 5, true, "Sausages" },
                    { 6, true, "Laundry" },
                    { 7, true, "Nuts" },
                    { 8, true, "Cigarettes" },
                    { 9, true, "Bread" },
                    { 10, true, "Fruits and vegetables" }
                });

            migrationBuilder.InsertData(
                table: "Measures",
                columns: new[] { "Id", "CanBeDecimal", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, true, "kg" },
                    { 2, false, true, "no" }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "AddressId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "Evergreen Financial" },
                    { 2, 4, true, "Summit Savings & Loan" },
                    { 3, 5, true, "Golden Gate Bank" },
                    { 4, 2, true, "Heritage Community Bank" },
                    { 5, 4, true, "Unity Bank" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "Id", "AddressId", "Email", "IsActive", "Name", "PhoneNumber", "ResponsiblePersonName" },
                values: new object[,]
                {
                    { 1, 1, "contact@horizonbank.com", true, "Horizon", "+1 (555) 123-4567", "Jennifer Anderson" },
                    { 2, 5, "contact@heritagecommunitybank.com", true, "Heritage Community", "+1 (555) 901-2345", "Olivia Rodriguez" },
                    { 3, 2, "help@goldengate.com", true, "Golden Gate", " +1 (555) 678-9012", " Alexander Lee" },
                    { 4, 2, "feedback@unity.com", true, "Unity", "+1 (555) 012-3456", "Matthew White" },
                    { 5, 4, "customerservice@libertynational.com", true, "Liberty National", "+1 (555) 567-8901", "Emily Smith" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5699), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 156m, 44m, 187.20m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5723), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 5m, 124m, 6.00m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5730), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 159m, 156m, 190.80m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5733), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5735), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 58m, 173m, 69.60m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5737), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5738), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 31m, 95m, 37.20m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5743), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 247m, 115m, 296.40m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5796), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 195m, 84m, 234.00m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5804), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 224m, 75m, 268.80m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5808), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 54m, 101m, 64.80m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5811), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5812), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 102m, 151m, 122.40m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5816), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 285m, 65m, 342.00m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5819), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5820), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 54m, 186m, 64.80m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5823), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5824), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 7m, 16m, 8.40m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5828), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 97m, 181m, 116.40m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5832), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 80m, 166m, 96.00m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5836), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 247m, 36m, 296.40m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5838), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5840), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 203m, 188m, 243.60m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5843), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5845), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 190m, 120m, 228.00m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5847), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5848), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 77m, 138m, 92.40m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5852), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 107m, 39m, 128.40m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5854), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5856), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 300m, 145m, 360.00m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5858), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5859), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 93m, 35m, 111.60m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5863), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 211m, 94m, 253.20m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5867), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 220m, 11m, 264.00m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5869), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5870), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 6m, 14m, 7.20m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5874), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 221m, 4m, 265.20m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5876), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5877), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 100m, 158m, 120.00m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5908), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 55m, 104m, 66.00m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5911), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5912), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 42m, 46m, 50.40m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5916), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 125m, 178m, 150.00m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5919), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 174m, 23m, 208.80m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5923), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 38m, 158m, 45.60m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5927), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 73m, 74m, 87.60m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5931), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 255m, 102m, 306.00m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5934), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5935), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 278m, 134m, 333.60m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5938), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 45m, 40m, 54.00m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5942), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 38m, 60m, 45.60m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5946), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 40m, 132m, 48.00m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5948), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5949), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 282m, 47m, 338.40m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5953), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 218m, 183m, 261.60m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5956), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 224m, 54m, 268.80m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5960), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 274m, 72m, 328.80m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5964), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 65m, 122m, 78.00m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5967), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 297m, 144m, 356.40m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5971), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 168m, 65m, 201.60m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5975), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 283m, 135m, 339.60m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5979), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 158m, 105m, 189.60m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(5982), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 217m, 103m, 260.40m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6025), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 292m, 98m, 350.40m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6028), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6029), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 235m, 23m, 282.00m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6032), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 18m, 136m, 21.60m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6036), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 94m, 155m, 112.80m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6040), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 280m, 12m, 336.00m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6043), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 294m, 171m, 352.80m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6047), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 219m, 103m, 262.80m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6050), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 254m, 120m, 304.80m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6054), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 192m, 23m, 230.40m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6058), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 229m, 178m, 274.80m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6060), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6061), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 255m, 5m, 306.00m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6064), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 51m, 96m, 61.20m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6067), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6068), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 69m, 94m, 82.80m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6071), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 87m, 198m, 104.40m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6075), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 153m, 162m, 183.60m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6077), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6078), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 42m, 141m, 50.40m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6081), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 19m, 130m, 22.80m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6088), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 284m, 187m, 340.80m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6152), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6154), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 135m, 21m, 162.00m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6156), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6157), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 260m, 21m, 312.00m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6161), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 240m, 46m, 288.00m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6163), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6164), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 42m, 194m, 50.40m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6168), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 41m, 113m, 49.20m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6172), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 86m, 12m, 103.20m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6175), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 78m, 48m, 93.60m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6178), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6179), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 176m, 20m, 211.20m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6181), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6183), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 260m, 65m, 312.00m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6185), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6186), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 222m, 47m, 266.40m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6189), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 91m, 65m, 109.20m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6192), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6193), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 273m, 183m, 327.60m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6196), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6197), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 53m, 189m, 63.60m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6201), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 241m, 108m, 289.20m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6204), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 79m, 146m, 94.80m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6208), "Description about product - French Baguette", true, 9, "French Baguette", 82, 32m, 150m, 38.40m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6214), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 174m, 1m, 208.80m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6217), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6218), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 297m, 36m, 356.40m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6221), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 2m, 52m, 2.40m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6225), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 101m, 126m, 121.20m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6228), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 215m, 76m, 258.00m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6230), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6232), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 110m, 48m, 132.00m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6257), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 269m, 196m, 322.80m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6261), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 221m, 88m, 265.20m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6264), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6265), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 59m, 45m, 70.80m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6268), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 192m, 94m, 230.40m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6272), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 195m, 91m, 234.00m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6276), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 262m, 94m, 314.40m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6279), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 296m, 198m, 355.20m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6283), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 107m, 161m, 128.40m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6286), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 80m, 44m, 96.00m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6290), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 183m, 104m, 219.60m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6293), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6294), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 245m, 168m, 294.00m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6298), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 208m, 68m, 249.60m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6302), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 59m, 11m, 70.80m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6304), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6305), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 93m, 159m, 111.60m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6309), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 142m, 108m, 170.40m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6311), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6312), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 300m, 49m, 360.00m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6316), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 166m, 38m, 199.20m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6319), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 54m, 164m, 64.80m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6322), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6323), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 52m, 20m, 62.40m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6326), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 258m, 191m, 309.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6330), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 101m, 83m, 121.20m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6372), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6373), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 229m, 92m, 274.80m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6377), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6378), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 166m, 173m, 199.20m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6382), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 75m, 10m, 90.00m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6384), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6385), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 203m, 17m, 243.60m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6389), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 159m, 10m, 190.80m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6393), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 266m, 25m, 319.20m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6397), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 292m, 164m, 350.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6400), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 7m, 102m, 8.40m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6402), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6404), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 8m, 173m, 9.60m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6407), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 219m, 12m, 262.80m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6410), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 234m, 95m, 280.80m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6414), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 198m, 30m, 237.60m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6417), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 42m, 149m, 50.40m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6421), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 157m, 28m, 188.40m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6424), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 183m, 156m, 219.60m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6428), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 227m, 46m, 272.40m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6432), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 9m, 49m, 10.80m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6435), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 31m, 46m, 37.20m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6439), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 266m, 21m, 319.20m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6443), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 235m, 165m, 282.00m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6504), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6506), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 237m, 190m, 284.40m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6509), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 299m, 150m, 358.80m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6512), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6513), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 223m, 194m, 267.60m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6517), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 179m, 41m, 214.80m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6520), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 109m, 163m, 130.80m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6523), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6524), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 126m, 40m, 151.20m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6528), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 49m, 4m, 58.80m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6531), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 49m, 190m, 58.80m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6535), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 25m, 113m, 30.00m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6538), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6539), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 191m, 43m, 229.20m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6543), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 111m, 111m, 133.20m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6546), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 81m, 43m, 97.20m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6550), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 235m, 86m, 282.00m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6553), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 40m, 89m, 48.00m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6557), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 274m, 81m, 328.80m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6561), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 110m, 162m, 132.00m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6564), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 249m, 150m, 298.80m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6568), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 131m, 58m, 157.20m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6572), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 232m, 162m, 278.40m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6637), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 30m, 144m, 36.00m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 3, 31, 16, 13, 31, 19, DateTimeKind.Local).AddTicks(6641), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 190m, 113m, 228.00m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 114, "777777777777" },
                    { 2, true, 25, "222222222222" },
                    { 3, true, 61, "444444444444" },
                    { 4, true, 111, "444444444444" },
                    { 5, true, 56, "333333333333" },
                    { 6, true, 74, "333333333333" },
                    { 7, true, 76, "888888888888" },
                    { 8, true, 72, "444444444444" },
                    { 9, true, 74, "666666666666" },
                    { 10, true, 40, "333333333333" },
                    { 11, true, 86, "888888888888" },
                    { 12, true, 58, "555555555555" },
                    { 13, true, 56, "444444444444" },
                    { 14, true, 34, "666666666666" },
                    { 15, true, 80, "222222222222" },
                    { 16, true, 32, "111111111111" },
                    { 17, true, 136, "888888888888" },
                    { 18, true, 45, "888888888888" },
                    { 19, true, 53, "555555555555" },
                    { 20, true, 123, "777777777777" },
                    { 21, true, 32, "777777777777" },
                    { 22, true, 126, "444444444444" },
                    { 23, true, 74, "999999999999" },
                    { 24, true, 7, "222222222222" },
                    { 25, true, 119, "111111111111" },
                    { 26, true, 14, "333333333333" },
                    { 27, true, 4, "222222222222" },
                    { 28, true, 55, "555555555555" },
                    { 29, true, 34, "888888888888" },
                    { 30, true, 56, "111111111111" },
                    { 31, true, 24, "666666666666" },
                    { 32, true, 100, "666666666666" },
                    { 33, true, 85, "777777777777" },
                    { 34, true, 63, "666666666666" },
                    { 35, true, 22, "777777777777" },
                    { 36, true, 70, "111111111111" },
                    { 37, true, 97, "444444444444" },
                    { 38, true, 145, "888888888888" },
                    { 39, true, 63, "999999999999" },
                    { 40, true, 47, "666666666666" },
                    { 41, true, 107, "555555555555" },
                    { 42, true, 127, "999999999999" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 113, "999999999999" },
                    { 44, true, 141, "999999999999" },
                    { 45, true, 72, "333333333333" },
                    { 46, true, 70, "666666666666" },
                    { 47, true, 121, "444444444444" },
                    { 48, true, 31, "555555555555" },
                    { 49, true, 53, "888888888888" },
                    { 50, true, 123, "444444444444" },
                    { 51, true, 51, "333333333333" },
                    { 52, true, 65, "111111111111" },
                    { 53, true, 67, "222222222222" },
                    { 54, true, 88, "555555555555" },
                    { 55, true, 80, "555555555555" },
                    { 56, true, 72, "444444444444" },
                    { 57, true, 20, "999999999999" },
                    { 58, true, 32, "111111111111" },
                    { 59, true, 80, "555555555555" },
                    { 60, true, 32, "444444444444" },
                    { 61, true, 44, "777777777777" },
                    { 62, true, 79, "888888888888" },
                    { 63, true, 34, "666666666666" },
                    { 64, true, 149, "666666666666" },
                    { 65, true, 108, "333333333333" },
                    { 66, true, 118, "111111111111" },
                    { 67, true, 87, "555555555555" },
                    { 68, true, 59, "888888888888" },
                    { 69, true, 65, "111111111111" },
                    { 70, true, 87, "222222222222" },
                    { 71, true, 23, "888888888888" },
                    { 72, true, 62, "777777777777" },
                    { 73, true, 58, "666666666666" },
                    { 74, true, 118, "444444444444" },
                    { 75, true, 139, "444444444444" },
                    { 76, true, 27, "333333333333" },
                    { 77, true, 106, "555555555555" },
                    { 78, true, 122, "777777777777" },
                    { 79, true, 42, "555555555555" },
                    { 80, true, 101, "888888888888" },
                    { 81, true, 120, "111111111111" },
                    { 82, true, 18, "222222222222" },
                    { 83, true, 7, "333333333333" },
                    { 84, true, 77, "999999999999" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 54, "333333333333" },
                    { 86, true, 41, "333333333333" },
                    { 87, true, 37, "555555555555" },
                    { 88, true, 123, "888888888888" },
                    { 89, true, 109, "888888888888" },
                    { 90, true, 3, "333333333333" },
                    { 91, true, 101, "111111111111" },
                    { 92, true, 112, "555555555555" },
                    { 93, true, 87, "222222222222" },
                    { 94, true, 129, "555555555555" },
                    { 95, true, 2, "888888888888" },
                    { 96, true, 113, "444444444444" },
                    { 97, true, 58, "111111111111" },
                    { 98, true, 71, "222222222222" },
                    { 99, true, 88, "777777777777" },
                    { 100, true, 65, "999999999999" },
                    { 101, true, 108, "444444444444" },
                    { 102, true, 22, "999999999999" },
                    { 103, true, 123, "888888888888" },
                    { 104, true, 112, "888888888888" },
                    { 105, true, 66, "333333333333" },
                    { 106, true, 119, "777777777777" },
                    { 107, true, 37, "888888888888" },
                    { 108, true, 53, "222222222222" },
                    { 109, true, 30, "444444444444" },
                    { 110, true, 96, "888888888888" },
                    { 111, true, 125, "777777777777" },
                    { 112, true, 92, "555555555555" },
                    { 113, true, 2, "555555555555" },
                    { 114, true, 15, "777777777777" },
                    { 115, true, 126, "888888888888" },
                    { 116, true, 90, "777777777777" },
                    { 117, true, 95, "333333333333" },
                    { 118, true, 91, "999999999999" },
                    { 119, true, 139, "333333333333" },
                    { 120, true, 143, "777777777777" },
                    { 121, true, 77, "888888888888" },
                    { 122, true, 96, "555555555555" },
                    { 123, true, 24, "888888888888" },
                    { 124, true, 11, "777777777777" },
                    { 125, true, 57, "333333333333" },
                    { 126, true, 117, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 29, "999999999999" },
                    { 128, true, 150, "777777777777" },
                    { 129, true, 58, "222222222222" },
                    { 130, true, 74, "111111111111" },
                    { 131, true, 146, "333333333333" },
                    { 132, true, 80, "888888888888" },
                    { 133, true, 99, "222222222222" },
                    { 134, true, 2, "333333333333" },
                    { 135, true, 103, "888888888888" },
                    { 136, true, 146, "999999999999" },
                    { 137, true, 132, "888888888888" },
                    { 138, true, 141, "666666666666" },
                    { 139, true, 49, "333333333333" },
                    { 140, true, 113, "444444444444" },
                    { 141, true, 43, "333333333333" },
                    { 142, true, 3, "999999999999" },
                    { 143, true, 1, "666666666666" },
                    { 144, true, 2, "888888888888" },
                    { 145, true, 73, "777777777777" },
                    { 146, true, 72, "222222222222" },
                    { 147, true, 6, "333333333333" },
                    { 148, true, 23, "888888888888" },
                    { 149, true, 12, "333333333333" },
                    { 150, true, 49, "888888888888" }
                });

            migrationBuilder.InsertData(
                table: "CounterParties",
                columns: new[] { "Id", "BankCode", "BankIBAN", "BankId", "FirmId", "IsActive", "Name", "VATNumber", "ValueAddedTaxLawId" },
                values: new object[,]
                {
                    { 1, "ABCDEFGH", "GB29NWBK60161331926819", 1, 2, true, "Martinez Capital Management", "GB123456789", "GB123456789" },
                    { 2, "123456789012345678", "SE3550000000054910000003", 2, 3, true, "Brown Investment Partners", "NL123456789B01", "NL123456789B01" },
                    { 3, "12345678", "IT60X0542811101000000123456", 3, 4, true, "Taylor Financial Solutions", "FR12345678901", "FR12345678901" },
                    { 4, "DE12345678901234567890", "ESX1234567X", 4, 5, true, "Greenberg Holdings Ltd", "SE123456789012", "SE123456789012" },
                    { 5, "01234-567", "CHE-123.456.789", 5, 1, true, "Hall Trading Corporation", "IT12345678901", "IT12345678901" }
                });

            migrationBuilder.InsertData(
                table: "ProductsMeasures",
                columns: new[] { "MeasureId", "ProductId" },
                values: new object[,]
                {
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 1, 43 }
                });

            migrationBuilder.InsertData(
                table: "ProductsMeasures",
                columns: new[] { "MeasureId", "ProductId" },
                values: new object[,]
                {
                    { 1, 44 },
                    { 1, 45 },
                    { 1, 46 },
                    { 1, 47 },
                    { 1, 48 },
                    { 1, 49 },
                    { 1, 50 },
                    { 1, 81 },
                    { 1, 82 },
                    { 1, 83 },
                    { 1, 84 },
                    { 1, 85 },
                    { 1, 86 },
                    { 1, 87 },
                    { 1, 88 },
                    { 1, 89 },
                    { 1, 90 },
                    { 1, 91 },
                    { 1, 92 },
                    { 1, 93 },
                    { 1, 94 },
                    { 1, 95 },
                    { 1, 96 },
                    { 1, 97 },
                    { 1, 98 },
                    { 1, 99 },
                    { 1, 100 },
                    { 1, 101 },
                    { 1, 102 },
                    { 1, 103 },
                    { 1, 104 },
                    { 1, 105 },
                    { 1, 106 },
                    { 1, 107 },
                    { 1, 108 },
                    { 1, 109 },
                    { 1, 110 },
                    { 1, 111 },
                    { 1, 112 },
                    { 1, 113 },
                    { 1, 114 },
                    { 1, 115 }
                });

            migrationBuilder.InsertData(
                table: "ProductsMeasures",
                columns: new[] { "MeasureId", "ProductId" },
                values: new object[,]
                {
                    { 1, 116 },
                    { 1, 117 },
                    { 1, 118 },
                    { 1, 119 },
                    { 1, 120 },
                    { 1, 121 },
                    { 1, 122 },
                    { 1, 123 },
                    { 1, 124 },
                    { 1, 125 },
                    { 1, 126 },
                    { 1, 127 },
                    { 1, 128 },
                    { 1, 129 },
                    { 1, 130 },
                    { 1, 131 },
                    { 1, 132 },
                    { 1, 133 },
                    { 1, 134 },
                    { 1, 135 },
                    { 1, 136 },
                    { 1, 137 },
                    { 1, 138 },
                    { 1, 139 },
                    { 1, 140 },
                    { 1, 141 },
                    { 1, 142 },
                    { 1, 143 },
                    { 1, 144 },
                    { 1, 145 },
                    { 1, 146 },
                    { 1, 147 },
                    { 1, 148 },
                    { 1, 149 },
                    { 1, 150 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "ProductsMeasures",
                columns: new[] { "MeasureId", "ProductId" },
                values: new object[,]
                {
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 2, 51 },
                    { 2, 52 },
                    { 2, 53 },
                    { 2, 54 },
                    { 2, 55 },
                    { 2, 56 },
                    { 2, 57 },
                    { 2, 58 },
                    { 2, 59 },
                    { 2, 60 },
                    { 2, 61 },
                    { 2, 62 },
                    { 2, 63 },
                    { 2, 64 },
                    { 2, 65 },
                    { 2, 66 },
                    { 2, 67 },
                    { 2, 68 },
                    { 2, 69 }
                });

            migrationBuilder.InsertData(
                table: "ProductsMeasures",
                columns: new[] { "MeasureId", "ProductId" },
                values: new object[,]
                {
                    { 2, 70 },
                    { 2, 71 },
                    { 2, 72 },
                    { 2, 73 },
                    { 2, 74 },
                    { 2, 75 },
                    { 2, 76 },
                    { 2, 77 },
                    { 2, 78 },
                    { 2, 79 },
                    { 2, 80 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_AddressId",
                table: "Banks",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_ProductId",
                table: "Barcodes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterParties_BankId",
                table: "CounterParties",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterParties_FirmId",
                table: "CounterParties",
                column: "FirmId");

            migrationBuilder.CreateIndex(
                name: "IX_Firms_AddressId",
                table: "Firms",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CounterPartyId",
                table: "Operations",
                column: "CounterPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_DocumentTypeId",
                table: "Operations",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_UserId",
                table: "Operations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ItemGroupId",
                table: "Products",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMeasures_ProductId",
                table: "ProductsMeasures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOperations_ProductId",
                table: "ProductsOperations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropTable(
                name: "ProductsMeasures");

            migrationBuilder.DropTable(
                name: "ProductsOperations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CounterParties");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
