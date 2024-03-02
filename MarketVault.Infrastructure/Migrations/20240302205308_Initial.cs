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
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "ItemGroup Name"),
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
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Firm Phone Number"),
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
                    ItemGroupId = table.Column<int>(type: "int", nullable: false, comment: "ItemGroupId - FK")
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
                    TotalPurchasePriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "TotalPurchasePriceWithVAT")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
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
                    { 10, true, "Fruts and vegetables" }
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
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, "Chocolate Ice Cream", 0, "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 250m, 64m, 300.00m },
                    { 2, 2, "Vanilla Ice Cream", 0, "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 262m, 112m, 314.40m },
                    { 3, 3, "Strawberry Ice Cream", 0, "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 278m, 124m, 333.60m },
                    { 4, 4, "Mint Ice Cream", 0, "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 86m, 64m, 103.20m },
                    { 5, 5, "Cookies Ice Cream", 0, "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 177m, 71m, 212.40m },
                    { 6, 6, "Rocky Ice Cream", 0, "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 151m, 54m, 181.20m },
                    { 7, 7, "Neapolitan Ice Cream", 0, "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 120m, 55m, 144.00m },
                    { 8, 8, "Butter Ice Cream", 0, "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 188m, 144m, 225.60m },
                    { 9, 9, "Pistachio Ice Cream", 0, "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 154m, 33m, 184.80m },
                    { 10, 10, "Salted Ice Cream", 0, "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 282m, 90m, 338.40m },
                    { 11, 11, "Coca-Cola Classic", 0, "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 69m, 143m, 82.80m },
                    { 12, 12, "Pepsi Cola", 0, "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 254m, 13m, 304.80m },
                    { 13, 13, "Sprite Soda", 0, "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 230m, 110m, 276.00m },
                    { 14, 14, "Fanta Soda", 0, "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 257m, 155m, 308.40m },
                    { 15, 15, "Mountain Soda", 0, "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 228m, 135m, 273.60m },
                    { 16, 16, "Dr. Pepper Soda", 0, "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 239m, 199m, 286.80m },
                    { 17, 17, "Canada Ale", 0, "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 282m, 108m, 338.40m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 195m, 53m, 234.00m },
                    { 19, 19, "Root Beer Soda", 0, "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 44m, 32m, 52.80m },
                    { 20, 20, "Red Bull Drink", 0, "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 114m, 119m, 136.80m },
                    { 21, 21, "Budweiser Beer", 0, "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 150m, 130m, 180.00m },
                    { 22, 22, "Jack Whiskey", 0, "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 292m, 71m, 350.40m },
                    { 23, 23, "Grey Goose Vodka", 0, "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 131m, 155m, 157.20m },
                    { 24, 24, "Captain Rum", 0, "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 278m, 165m, 333.60m },
                    { 25, 25, "Jose Tequila", 0, "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 118m, 51m, 141.60m },
                    { 26, 26, "Chardonnay Wine", 0, "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 217m, 166m, 260.40m },
                    { 27, 27, "Pinot Wine", 0, "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 298m, 136m, 357.60m },
                    { 28, 28, "Moet & Chandon Champagne", 0, "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 143m, 99m, 171.60m },
                    { 29, 29, "Jameson Whiskey", 0, "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 113m, 124m, 135.60m },
                    { 30, 30, "Absolut Vodka", 0, "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 116m, 140m, 139.20m },
                    { 31, 31, "Whole Milk", 1, "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 221m, 163m, 265.20m },
                    { 32, 32, "2% Reduced Fat Milk", 2, "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 270m, 57m, 324.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 103m, 172m, 123.60m },
                    { 34, 34, "Chocolate Milk", 4, "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 260m, 125m, 312.00m },
                    { 35, 35, "Half and Half Cream", 5, "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 284m, 102m, 340.80m },
                    { 36, 36, "Heavy Cream", 6, "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 150m, 153m, 180.00m },
                    { 37, 37, "Unsalted Butter", 7, "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 17m, 155m, 20.40m },
                    { 38, 38, "Salted Butter", 8, "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 137m, 146m, 164.40m },
                    { 39, 39, "Plain Yogurt", 9, "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 74m, 116m, 88.80m },
                    { 40, 40, "Greek Yogurt", 10, "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 50m, 132m, 60.00m },
                    { 41, 41, "Beef Dogs", 11, "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 120m, 76m, 144.00m },
                    { 42, 42, "Pork Sausages", 12, "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 246m, 109m, 295.20m },
                    { 43, 43, "Chicken Sausages", 13, "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 180m, 41m, 216.00m },
                    { 44, 44, "Italian Sausages", 14, "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 9m, 4m, 10.80m },
                    { 45, 45, "Bratwurst Sausages", 15, "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 172m, 79m, 206.40m },
                    { 46, 46, "Chorizo Sausages", 16, "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 164m, 63m, 196.80m },
                    { 47, 47, "Andouille Sausages", 17, "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 60m, 141m, 72.00m },
                    { 48, 48, "Kielbasa Sausages", 18, "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 43m, 111m, 51.60m },
                    { 49, 49, "Vegan Sausages", 19, "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 212m, 104m, 254.40m },
                    { 50, 50, "Maple Sausage", 20, "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 141m, 3m, 169.20m },
                    { 51, 51, "Ultra Detergent", 0, "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 246m, 6m, 295.20m },
                    { 52, 52, "Fabric Sheets", 0, "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 122m, 121m, 146.40m },
                    { 53, 53, "Stain Spray", 0, "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 34m, 9m, 40.80m },
                    { 54, 54, "Color-Safe Bleach", 0, "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 264m, 128m, 316.80m },
                    { 55, 55, "Liquid Softener", 0, "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 231m, 119m, 277.20m },
                    { 56, 56, "Fragrance-Free Pods", 0, "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 93m, 184m, 111.60m },
                    { 57, 57, "Wool Balls", 0, "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 170m, 138m, 204.00m },
                    { 58, 58, "Oxygen Remover", 0, "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 125m, 180m, 150.00m },
                    { 59, 59, "Laundry Spray", 0, "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 142m, 83m, 170.40m },
                    { 60, 60, "Delicate Detergent", 0, "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 25m, 46m, 30.00m },
                    { 61, 61, "Roasted  Nuts", 0, "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 80m, 58m, 96.00m },
                    { 62, 62, "Honey Cashews", 0, "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 135m, 2m, 162.00m },
                    { 63, 63, "Spicy Almonds", 0, "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 40m, 46m, 48.00m },
                    { 64, 64, "BBQ Peanuts", 0, "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 59m, 161m, 70.80m },
                    { 65, 65, "Chocolate Hazelnuts", 0, "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 238m, 165m, 285.60m },
                    { 66, 66, "Sea Pistachios", 0, "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 41m, 15m, 49.20m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 76m, 42m, 91.20m },
                    { 68, 68, "Chili Lime Cashews", 0, "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 176m, 98m, 211.20m },
                    { 69, 69, "Wasabi Almonds", 0, "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 210m, 23m, 252.00m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 285m, 194m, 342.00m },
                    { 71, 71, "Premium Cigarettes", 0, "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 109m, 52m, 130.80m },
                    { 72, 72, "Classic Blend Cigarettes", 0, "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 215m, 35m, 258.00m },
                    { 73, 73, "Slims Cigarettes", 0, "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 231m, 125m, 277.20m },
                    { 74, 74, "Menthol Cigarettes", 0, "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 260m, 102m, 312.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 90m, 117m, 108.00m },
                    { 76, 76, "Menthol Cigarettes", 0, "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 14m, 16m, 16.80m },
                    { 77, 77, "Ultra Cigarettes", 0, "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 163m, 9m, 195.60m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 283m, 31m, 339.60m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 82m, 169m, 98.40m },
                    { 80, 80, "Menthol Green Cigarettes", 0, "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 187m, 3m, 224.40m },
                    { 81, 81, "Whole Bread", 0, "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 168m, 167m, 201.60m },
                    { 82, 82, "French Baguette", 0, "Description about product - French Baguette", true, 9, "French Baguette", 82, 136m, 200m, 163.20m },
                    { 83, 83, "Artisanal Loaf", 0, "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 277m, 171m, 332.40m },
                    { 84, 84, "Multigrain Bread", 0, "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 213m, 160m, 255.60m },
                    { 85, 85, "Rye Bread", 0, "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 226m, 122m, 271.20m },
                    { 86, 86, "Gluten-Free Bread", 0, "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 179m, 147m, 214.80m },
                    { 87, 87, "Cinnamon Bread", 0, "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 4m, 66m, 4.80m },
                    { 88, 88, "Italian Loaf", 0, "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 63m, 166m, 75.60m },
                    { 89, 89, "Pumpernickel Bread", 0, "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 240m, 6m, 288.00m },
                    { 90, 90, "Bagels Pack", 0, "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 63m, 38m, 75.60m },
                    { 91, 91, "Organic Gala Apples", 21, "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 191m, 49m, 229.20m },
                    { 92, 92, "Fresh Strawberries", 22, "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 25m, 130m, 30.00m },
                    { 93, 93, "Green Grapes", 23, "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 148m, 158m, 177.60m },
                    { 94, 94, "Ripe Avocados", 24, "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 162m, 55m, 194.40m },
                    { 95, 95, "Sweet Juicy Oranges", 25, "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 76m, 193m, 91.20m },
                    { 96, 96, "Crisp Apples", 26, "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 233m, 163m, 279.60m },
                    { 97, 97, "Fresh Raspberries", 27, "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 22m, 88m, 26.40m },
                    { 98, 98, "Crisp Apples", 28, "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 172m, 152m, 206.40m },
                    { 99, 99, "Juicy Clementines", 29, "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 164m, 113m, 196.80m },
                    { 100, 100, "Organic Bananas", 30, "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 283m, 133m, 339.60m },
                    { 101, 101, "Plump Blueberries", 31, "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 104m, 121m, 124.80m },
                    { 102, 102, "Ripe Red Tomatoes", 32, "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 83m, 171m, 99.60m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 58m, 4m, 69.60m },
                    { 104, 104, "Crisp Green Cucumbers", 34, "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 255m, 46m, 306.00m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 4m, 90m, 4.80m },
                    { 106, 106, "Sweet Juicy Peaches", 36, "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 76m, 135m, 91.20m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 251m, 43m, 301.20m },
                    { 108, 108, "Ripe Yellow Bananas", 38, "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 108m, 100m, 129.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 38m, 128m, 45.60m },
                    { 110, 110, "Crisp Carrots", 40, "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 45m, 48m, 54.00m },
                    { 111, 111, "Fresh Lemons", 41, "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 95m, 57m, 114.00m },
                    { 112, 112, "Ripe Mangos", 42, "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 269m, 155m, 322.80m },
                    { 113, 113, "Sweet Red Cherries", 43, "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 94m, 11m, 112.80m },
                    { 114, 114, "Crisp Celery Sticks", 44, "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 31m, 132m, 37.20m },
                    { 115, 115, "Juicy Watermelon", 45, "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 231m, 89m, 277.20m },
                    { 116, 116, "Green Zucchini Squash", 46, "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 279m, 89m, 334.80m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 297m, 53m, 356.40m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 126m, 70m, 151.20m },
                    { 119, 119, "Crisp Radishes", 49, "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 104m, 80m, 124.80m },
                    { 120, 120, "Ripe Honeydew Melon", 50, "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 296m, 131m, 355.20m },
                    { 121, 121, "Fresh Green Beans", 51, "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 157m, 195m, 188.40m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 116m, 133m, 139.20m },
                    { 123, 123, "Ripe Nectarines", 53, "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 92m, 55m, 110.40m },
                    { 124, 124, "Sweet Grapes", 54, "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 156m, 170m, 187.20m },
                    { 125, 125, "Crisp Squash", 55, "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 139m, 105m, 166.80m },
                    { 126, 126, "Fresh Asparagus Spears", 56, "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 21m, 83m, 25.20m },
                    { 127, 127, "Juicy Blackberries", 57, "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 241m, 148m, 289.20m },
                    { 128, 128, "Ripe Apricots", 58, "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 298m, 74m, 357.60m },
                    { 129, 129, "Sweet Strawberries", 59, "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 100m, 200m, 120.00m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 32m, 145m, 38.40m },
                    { 131, 131, "Ripe Papaya", 61, "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 273m, 84m, 327.60m },
                    { 132, 132, "Fresh Artichokes", 62, "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 129m, 192m, 154.80m },
                    { 133, 133, "Sweet Cantaloupe", 63, "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 156m, 157m, 187.20m },
                    { 134, 134, "Ripe Pears", 64, "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 22m, 30m, 26.40m },
                    { 135, 135, "Crisp Green Peas", 65, "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 29m, 116m, 34.80m },
                    { 136, 136, "Juicy Grapefruit", 66, "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 298m, 164m, 357.60m },
                    { 137, 137, "Ripe Plums", 67, "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 76m, 81m, 91.20m },
                    { 138, 138, "Crisp Red Radishes", 68, "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 90m, 20m, 108.00m },
                    { 139, 139, "Fresh Beets", 69, "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 287m, 199m, 344.40m },
                    { 140, 140, "Sweet Red Peppers", 70, "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 259m, 20m, 310.80m },
                    { 141, 141, "Ripe Tangerines", 71, "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 179m, 140m, 214.80m },
                    { 142, 142, "Crisp Corn on the Cob", 72, "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 180m, 38m, 216.00m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 252m, 158m, 302.40m },
                    { 144, 144, "Ripe Lychees", 74, "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 254m, 122m, 304.80m },
                    { 145, 145, "Crisp Bok Choy", 75, "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 241m, 9m, 289.20m },
                    { 146, 146, "Juicy Pomegranates", 76, "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 271m, 113m, 325.20m },
                    { 147, 147, "Ripe Persimmons", 77, "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 204m, 184m, 244.80m },
                    { 148, 148, "Sweet Figs", 78, "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 40m, 174m, 48.00m },
                    { 149, 149, "Crisp Jicama", 79, "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 213m, 74m, 255.60m },
                    { 150, 150, "Fresh Baby Spinach", 80, "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 140m, 140m, 168.00m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 6, "444444444444" },
                    { 2, true, 14, "666666666666" },
                    { 3, true, 106, "333333333333" },
                    { 4, true, 16, "888888888888" },
                    { 5, true, 141, "666666666666" },
                    { 6, true, 142, "444444444444" },
                    { 7, true, 14, "888888888888" },
                    { 8, true, 112, "111111111111" },
                    { 9, true, 126, "222222222222" },
                    { 10, true, 109, "222222222222" },
                    { 11, true, 34, "111111111111" },
                    { 12, true, 65, "777777777777" },
                    { 13, true, 141, "111111111111" },
                    { 14, true, 88, "444444444444" },
                    { 15, true, 125, "111111111111" },
                    { 16, true, 106, "222222222222" },
                    { 17, true, 134, "222222222222" },
                    { 18, true, 87, "222222222222" },
                    { 19, true, 45, "888888888888" },
                    { 20, true, 142, "666666666666" },
                    { 21, true, 120, "333333333333" },
                    { 22, true, 89, "777777777777" },
                    { 23, true, 12, "333333333333" },
                    { 24, true, 56, "111111111111" },
                    { 25, true, 100, "555555555555" },
                    { 26, true, 37, "333333333333" },
                    { 27, true, 132, "555555555555" },
                    { 28, true, 71, "999999999999" },
                    { 29, true, 139, "777777777777" },
                    { 30, true, 29, "555555555555" },
                    { 31, true, 64, "666666666666" },
                    { 32, true, 2, "555555555555" },
                    { 33, true, 62, "333333333333" },
                    { 34, true, 6, "111111111111" },
                    { 35, true, 87, "666666666666" },
                    { 36, true, 136, "666666666666" },
                    { 37, true, 29, "999999999999" },
                    { 38, true, 72, "666666666666" },
                    { 39, true, 101, "777777777777" },
                    { 40, true, 113, "999999999999" },
                    { 41, true, 76, "111111111111" },
                    { 42, true, 77, "333333333333" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 104, "222222222222" },
                    { 44, true, 98, "555555555555" },
                    { 45, true, 99, "111111111111" },
                    { 46, true, 86, "111111111111" },
                    { 47, true, 33, "111111111111" },
                    { 48, true, 88, "222222222222" },
                    { 49, true, 94, "555555555555" },
                    { 50, true, 4, "111111111111" },
                    { 51, true, 70, "999999999999" },
                    { 52, true, 124, "444444444444" },
                    { 53, true, 63, "333333333333" },
                    { 54, true, 79, "333333333333" },
                    { 55, true, 91, "999999999999" },
                    { 56, true, 6, "333333333333" },
                    { 57, true, 74, "333333333333" },
                    { 58, true, 43, "444444444444" },
                    { 59, true, 128, "444444444444" },
                    { 60, true, 22, "111111111111" },
                    { 61, true, 134, "111111111111" },
                    { 62, true, 149, "555555555555" },
                    { 63, true, 104, "333333333333" },
                    { 64, true, 97, "444444444444" },
                    { 65, true, 89, "666666666666" },
                    { 66, true, 93, "222222222222" },
                    { 67, true, 121, "777777777777" },
                    { 68, true, 42, "666666666666" },
                    { 69, true, 108, "888888888888" },
                    { 70, true, 66, "222222222222" },
                    { 71, true, 101, "999999999999" },
                    { 72, true, 68, "777777777777" },
                    { 73, true, 19, "666666666666" },
                    { 74, true, 139, "222222222222" },
                    { 75, true, 69, "222222222222" },
                    { 76, true, 98, "333333333333" },
                    { 77, true, 119, "333333333333" },
                    { 78, true, 87, "777777777777" },
                    { 79, true, 11, "555555555555" },
                    { 80, true, 7, "555555555555" },
                    { 81, true, 32, "111111111111" },
                    { 82, true, 92, "999999999999" },
                    { 83, true, 77, "111111111111" },
                    { 84, true, 118, "222222222222" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 20, "555555555555" },
                    { 86, true, 122, "555555555555" },
                    { 87, true, 25, "222222222222" },
                    { 88, true, 17, "888888888888" },
                    { 89, true, 21, "666666666666" },
                    { 90, true, 131, "555555555555" },
                    { 91, true, 75, "444444444444" },
                    { 92, true, 72, "111111111111" },
                    { 93, true, 116, "555555555555" },
                    { 94, true, 90, "111111111111" },
                    { 95, true, 131, "555555555555" },
                    { 96, true, 108, "888888888888" },
                    { 97, true, 101, "888888888888" },
                    { 98, true, 20, "222222222222" },
                    { 99, true, 3, "222222222222" },
                    { 100, true, 101, "555555555555" },
                    { 101, true, 20, "999999999999" },
                    { 102, true, 129, "888888888888" },
                    { 103, true, 17, "888888888888" },
                    { 104, true, 48, "666666666666" },
                    { 105, true, 28, "111111111111" },
                    { 106, true, 77, "333333333333" },
                    { 107, true, 131, "666666666666" },
                    { 108, true, 50, "222222222222" },
                    { 109, true, 74, "777777777777" },
                    { 110, true, 149, "555555555555" },
                    { 111, true, 70, "777777777777" },
                    { 112, true, 32, "555555555555" },
                    { 113, true, 3, "555555555555" },
                    { 114, true, 29, "444444444444" },
                    { 115, true, 21, "666666666666" },
                    { 116, true, 91, "777777777777" },
                    { 117, true, 24, "555555555555" },
                    { 118, true, 47, "444444444444" },
                    { 119, true, 81, "888888888888" },
                    { 120, true, 61, "777777777777" },
                    { 121, true, 115, "888888888888" },
                    { 122, true, 64, "444444444444" },
                    { 123, true, 102, "555555555555" },
                    { 124, true, 70, "888888888888" },
                    { 125, true, 36, "666666666666" },
                    { 126, true, 16, "888888888888" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 44, "111111111111" },
                    { 128, true, 108, "222222222222" },
                    { 129, true, 108, "111111111111" },
                    { 130, true, 36, "666666666666" },
                    { 131, true, 57, "777777777777" },
                    { 132, true, 8, "999999999999" },
                    { 133, true, 48, "222222222222" },
                    { 134, true, 135, "111111111111" },
                    { 135, true, 139, "222222222222" },
                    { 136, true, 59, "666666666666" },
                    { 137, true, 73, "555555555555" },
                    { 138, true, 136, "777777777777" },
                    { 139, true, 145, "444444444444" },
                    { 140, true, 143, "666666666666" },
                    { 141, true, 20, "444444444444" },
                    { 142, true, 139, "666666666666" },
                    { 143, true, 68, "222222222222" },
                    { 144, true, 56, "444444444444" },
                    { 145, true, 11, "444444444444" },
                    { 146, true, 99, "777777777777" },
                    { 147, true, 48, "444444444444" },
                    { 148, true, 80, "333333333333" },
                    { 149, true, 69, "222222222222" },
                    { 150, true, 89, "444444444444" }
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

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "CounterPartyId", "DocumentTypeId", "TotalPurchasePriceWithVAT", "TotalPurchasePriceWithoutVAT", "TotalSalePriceWithVAT", "TotalSalePriceWithoutVAT" },
                values: new object[,]
                {
                    { 1, 1, 1, 70.00m, 58.33m, 100.00m, 83.33m },
                    { 2, 2, 1, 50.00m, 41.67m, 75.00m, 62.50m },
                    { 3, 3, 2, 40.00m, 33.33m, 60.00m, 50.00m },
                    { 4, 4, 2, 100.00m, 83.33m, 150.00m, 125.00m },
                    { 5, 5, 1, 150.00m, 125.00m, 200.00m, 166.67m }
                });

            migrationBuilder.InsertData(
                table: "ProductsOperations",
                columns: new[] { "OperationId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
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
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 3, 25 },
                    { 3, 26 },
                    { 3, 27 },
                    { 3, 28 },
                    { 3, 29 },
                    { 3, 30 },
                    { 4, 31 },
                    { 4, 32 },
                    { 4, 33 },
                    { 4, 34 },
                    { 4, 35 },
                    { 4, 36 },
                    { 4, 37 },
                    { 4, 38 },
                    { 4, 39 },
                    { 4, 40 },
                    { 5, 41 },
                    { 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "ProductsOperations",
                columns: new[] { "OperationId", "ProductId" },
                values: new object[,]
                {
                    { 5, 43 },
                    { 5, 44 },
                    { 5, 45 },
                    { 5, 46 },
                    { 5, 47 },
                    { 5, 48 },
                    { 5, 49 },
                    { 5, 50 }
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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Products");

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
