using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class Initial : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(258), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 272m, 127m, 326.40m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(280), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 240m, 195m, 288.00m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(285), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 278m, 49m, 333.60m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(289), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 62m, 199m, 74.40m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(293), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 31m, 64m, 37.20m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(297), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 70m, 154m, 84.00m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(301), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 229m, 39m, 274.80m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(304), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 197m, 17m, 236.40m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(308), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 16m, 90m, 19.20m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(313), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 189m, 170m, 226.80m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(316), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(317), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 257m, 146m, 308.40m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(321), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 96m, 118m, 115.20m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(325), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 29m, 43m, 34.80m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(327), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(328), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 287m, 63m, 344.40m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(366), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 19m, 148m, 22.80m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(370), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 28m, 160m, 33.60m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(374), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 76m, 10m, 91.20m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(377), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(378), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 253m, 102m, 303.60m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(382), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 290m, 142m, 348.00m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(386), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 193m, 70m, 231.60m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(389), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 201m, 118m, 241.20m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(393), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 171m, 149m, 205.20m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(397), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 139m, 178m, 166.80m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(401), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 79m, 81m, 94.80m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(405), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 254m, 56m, 304.80m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(409), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 39m, 196m, 46.80m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(411), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(413), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 282m, 33m, 338.40m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(415), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(416), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 88m, 66m, 105.60m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(420), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 39m, 91m, 46.80m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(424), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 54m, 116m, 64.80m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(427), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 193m, 40m, 231.60m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(431), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 237m, 99m, 284.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(435), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 196m, 28m, 235.20m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(439), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 103m, 131m, 123.60m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(479), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 47m, 135m, 56.40m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(483), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 237m, 49m, 284.40m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(487), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 247m, 60m, 296.40m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(490), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 243m, 42m, 291.60m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(493), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(494), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 145m, 81m, 174.00m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(498), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 242m, 56m, 290.40m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(501), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 42m, 146m, 50.40m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(505), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 100m, 5m, 120.00m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(509), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 6m, 109m, 7.20m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(512), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 268m, 55m, 321.60m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(516), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 299m, 85m, 358.80m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(520), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 215m, 133m, 258.00m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(524), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 278m, 10m, 333.60m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(528), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 49m, 91m, 58.80m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(531), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 54m, 198m, 64.80m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(535), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 222m, 135m, 266.40m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(539), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 66m, 66m, 79.20m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(542), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 222m, 134m, 266.40m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(546), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 2m, 101m, 2.40m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(550), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 279m, 84m, 334.80m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(554), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 109m, 172m, 130.80m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(591), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 248m, 3m, 297.60m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(595), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 194m, 140m, 232.80m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(599), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 231m, 104m, 277.20m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(601), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(602), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 124m, 150m, 148.80m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(606), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 259m, 103m, 310.80m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(609), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 47m, 116m, 56.40m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(613), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 86m, 128m, 103.20m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(616), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 82m, 61m, 98.40m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(620), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 105m, 56m, 126.00m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(624), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 245m, 95m, 294.00m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(628), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 22m, 92m, 26.40m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(632), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 68m, 70m, 81.60m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(635), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(636), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 158m, 85m, 189.60m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(639), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 40m, 26m, 48.00m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(643), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 250m, 90m, 300.00m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(646), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 85m, 173m, 102.00m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(650), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 249m, 33m, 298.80m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(654), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 59m, 99m, 70.80m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(658), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 241m, 15m, 289.20m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(710), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 225m, 23m, 270.00m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(713), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 255m, 24m, 306.00m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(717), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 62m, 177m, 74.40m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(721), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 194m, 118m, 232.80m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(724), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 46m, 154m, 55.20m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(728), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 294m, 45m, 352.80m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(732), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 164m, 139m, 196.80m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(736), "Description about product - French Baguette", true, 9, "French Baguette", 82, 154m, 87m, 184.80m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(740), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 94m, 197m, 112.80m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(744), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 256m, 10m, 307.20m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(748), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 154m, 170m, 184.80m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(751), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 187m, 27m, 224.40m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(755), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 120m, 169m, 144.00m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(758), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 57m, 165m, 68.40m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(762), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 140m, 175m, 168.00m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(766), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 263m, 90m, 315.60m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(769), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 136m, 178m, 163.20m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(773), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 207m, 100m, 248.40m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(775), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(776), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 285m, 2m, 342.00m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(780), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 99m, 110m, 118.80m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(783), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 176m, 85m, 211.20m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(787), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 300m, 89m, 360.00m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(825), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 34m, 48m, 40.80m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(829), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 164m, 96m, 196.80m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(833), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 65m, 159m, 78.00m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(836), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 60m, 194m, 72.00m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(840), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 257m, 144m, 308.40m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(844), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 207m, 192m, 248.40m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(848), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 219m, 26m, 262.80m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(851), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 212m, 110m, 254.40m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(855), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 244m, 46m, 292.80m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(859), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 128m, 96m, 153.60m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(862), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 29m, 66m, 34.80m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(866), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 35m, 104m, 42.00m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(869), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 19m, 21m, 22.80m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(873), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 218m, 180m, 261.60m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(876), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 65m, 50m, 78.00m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(880), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 207m, 168m, 248.40m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(883), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 222m, 5m, 266.40m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(886), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(887), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 172m, 162m, 206.40m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(891), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 26m, 175m, 31.20m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(895), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 265m, 150m, 318.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(897), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(898), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 185m, 149m, 222.00m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(936), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 98m, 102m, 117.60m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(940), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 105m, 116m, 126.00m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(944), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 248m, 80m, 297.60m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(948), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 127m, 33m, 152.40m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(951), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 176m, 2m, 211.20m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(955), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 83m, 80m, 99.60m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(959), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 152m, 168m, 182.40m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(962), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 55m, 151m, 66.00m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(965), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(966), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 98m, 9m, 117.60m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(969), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 235m, 68m, 282.00m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(972), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(973), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 132m, 88m, 158.40m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(976), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 219m, 32m, 262.80m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(981), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 265m, 75m, 318.00m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(985), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 55m, 69m, 66.00m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(988), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 273m, 20m, 327.60m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(992), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 18m, 6m, 21.60m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(995), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 228m, 123m, 273.60m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1032), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 257m, 78m, 308.40m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1036), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 123m, 175m, 147.60m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1040), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 123m, 43m, 147.60m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1044), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 298m, 41m, 357.60m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1047), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 142m, 133m, 170.40m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1051), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 57m, 76m, 68.40m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1055), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 114m, 115m, 136.80m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1058), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 166m, 162m, 199.20m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1062), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 147m, 67m, 176.40m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1066), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 135m, 128m, 162.00m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1069), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 34m, 132m, 40.80m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1073), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 158m, 193m, 189.60m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1076), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 248m, 157m, 297.60m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1080), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 102m, 22m, 122.40m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1083), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 46m, 52m, 55.20m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 4, 2, 18, 40, 48, 715, DateTimeKind.Local).AddTicks(1087), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 234m, 81m, 280.80m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 62, "333333333333" },
                    { 2, true, 34, "222222222222" },
                    { 3, true, 84, "888888888888" },
                    { 4, true, 61, "999999999999" },
                    { 5, true, 143, "666666666666" },
                    { 6, true, 6, "555555555555" },
                    { 7, true, 97, "777777777777" },
                    { 8, true, 61, "888888888888" },
                    { 9, true, 53, "666666666666" },
                    { 10, true, 116, "555555555555" },
                    { 11, true, 4, "111111111111" },
                    { 12, true, 105, "555555555555" },
                    { 13, true, 41, "222222222222" },
                    { 14, true, 11, "333333333333" },
                    { 15, true, 60, "222222222222" },
                    { 16, true, 57, "666666666666" },
                    { 17, true, 143, "222222222222" },
                    { 18, true, 112, "999999999999" },
                    { 19, true, 76, "777777777777" },
                    { 20, true, 146, "555555555555" },
                    { 21, true, 59, "111111111111" },
                    { 22, true, 38, "777777777777" },
                    { 23, true, 109, "777777777777" },
                    { 24, true, 102, "444444444444" },
                    { 25, true, 43, "444444444444" },
                    { 26, true, 130, "888888888888" },
                    { 27, true, 46, "888888888888" },
                    { 28, true, 2, "222222222222" },
                    { 29, true, 149, "666666666666" },
                    { 30, true, 58, "111111111111" },
                    { 31, true, 145, "222222222222" },
                    { 32, true, 52, "888888888888" },
                    { 33, true, 139, "888888888888" },
                    { 34, true, 24, "555555555555" },
                    { 35, true, 113, "222222222222" },
                    { 36, true, 131, "111111111111" },
                    { 37, true, 24, "666666666666" },
                    { 38, true, 19, "999999999999" },
                    { 39, true, 119, "888888888888" },
                    { 40, true, 140, "666666666666" },
                    { 41, true, 41, "222222222222" },
                    { 42, true, 14, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 149, "777777777777" },
                    { 44, true, 68, "222222222222" },
                    { 45, true, 67, "777777777777" },
                    { 46, true, 4, "999999999999" },
                    { 47, true, 38, "555555555555" },
                    { 48, true, 140, "999999999999" },
                    { 49, true, 124, "444444444444" },
                    { 50, true, 147, "222222222222" },
                    { 51, true, 36, "444444444444" },
                    { 52, true, 95, "555555555555" },
                    { 53, true, 22, "666666666666" },
                    { 54, true, 116, "333333333333" },
                    { 55, true, 60, "888888888888" },
                    { 56, true, 19, "111111111111" },
                    { 57, true, 124, "333333333333" },
                    { 58, true, 30, "222222222222" },
                    { 59, true, 81, "999999999999" },
                    { 60, true, 114, "888888888888" },
                    { 61, true, 29, "111111111111" },
                    { 62, true, 75, "999999999999" },
                    { 63, true, 57, "111111111111" },
                    { 64, true, 4, "111111111111" },
                    { 65, true, 113, "777777777777" },
                    { 66, true, 96, "444444444444" },
                    { 67, true, 52, "444444444444" },
                    { 68, true, 40, "777777777777" },
                    { 69, true, 73, "222222222222" },
                    { 70, true, 80, "444444444444" },
                    { 71, true, 101, "444444444444" },
                    { 72, true, 119, "111111111111" },
                    { 73, true, 33, "888888888888" },
                    { 74, true, 28, "444444444444" },
                    { 75, true, 96, "444444444444" },
                    { 76, true, 89, "999999999999" },
                    { 77, true, 59, "222222222222" },
                    { 78, true, 104, "111111111111" },
                    { 79, true, 54, "222222222222" },
                    { 80, true, 89, "444444444444" },
                    { 81, true, 26, "999999999999" },
                    { 82, true, 9, "111111111111" },
                    { 83, true, 28, "333333333333" },
                    { 84, true, 106, "555555555555" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 5, "333333333333" },
                    { 86, true, 105, "999999999999" },
                    { 87, true, 39, "444444444444" },
                    { 88, true, 27, "555555555555" },
                    { 89, true, 64, "222222222222" },
                    { 90, true, 63, "888888888888" },
                    { 91, true, 102, "555555555555" },
                    { 92, true, 82, "777777777777" },
                    { 93, true, 21, "777777777777" },
                    { 94, true, 14, "222222222222" },
                    { 95, true, 149, "777777777777" },
                    { 96, true, 16, "333333333333" },
                    { 97, true, 91, "222222222222" },
                    { 98, true, 77, "777777777777" },
                    { 99, true, 130, "222222222222" },
                    { 100, true, 30, "888888888888" },
                    { 101, true, 12, "888888888888" },
                    { 102, true, 115, "333333333333" },
                    { 103, true, 58, "444444444444" },
                    { 104, true, 141, "666666666666" },
                    { 105, true, 5, "555555555555" },
                    { 106, true, 79, "222222222222" },
                    { 107, true, 107, "444444444444" },
                    { 108, true, 69, "333333333333" },
                    { 109, true, 126, "666666666666" },
                    { 110, true, 17, "111111111111" },
                    { 111, true, 42, "111111111111" },
                    { 112, true, 30, "777777777777" },
                    { 113, true, 9, "777777777777" },
                    { 114, true, 109, "888888888888" },
                    { 115, true, 63, "222222222222" },
                    { 116, true, 16, "222222222222" },
                    { 117, true, 105, "222222222222" },
                    { 118, true, 140, "999999999999" },
                    { 119, true, 119, "333333333333" },
                    { 120, true, 36, "444444444444" },
                    { 121, true, 149, "111111111111" },
                    { 122, true, 120, "444444444444" },
                    { 123, true, 64, "111111111111" },
                    { 124, true, 11, "222222222222" },
                    { 125, true, 147, "333333333333" },
                    { 126, true, 60, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 10, "111111111111" },
                    { 128, true, 141, "444444444444" },
                    { 129, true, 76, "222222222222" },
                    { 130, true, 142, "444444444444" },
                    { 131, true, 126, "222222222222" },
                    { 132, true, 28, "333333333333" },
                    { 133, true, 49, "555555555555" },
                    { 134, true, 72, "333333333333" },
                    { 135, true, 119, "444444444444" },
                    { 136, true, 123, "222222222222" },
                    { 137, true, 141, "999999999999" },
                    { 138, true, 37, "777777777777" },
                    { 139, true, 50, "888888888888" },
                    { 140, true, 100, "333333333333" },
                    { 141, true, 43, "999999999999" },
                    { 142, true, 27, "111111111111" },
                    { 143, true, 39, "999999999999" },
                    { 144, true, 118, "777777777777" },
                    { 145, true, 69, "999999999999" },
                    { 146, true, 94, "333333333333" },
                    { 147, true, 115, "333333333333" },
                    { 148, true, 73, "888888888888" },
                    { 149, true, 112, "222222222222" },
                    { 150, true, 13, "222222222222" }
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
