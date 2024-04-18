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
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9255), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 196m, 58m, 235.20m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9272), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9273), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 244m, 76m, 292.80m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9278), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 76m, 24m, 91.20m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9283), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 226m, 19m, 271.20m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9287), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 35m, 101m, 42.00m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9292), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 110m, 95m, 132.00m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9296), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 130m, 66m, 156.00m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9299), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 253m, 101m, 303.60m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9303), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 180m, 174m, 216.00m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9336), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 291m, 30m, 349.20m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9340), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 247m, 24m, 296.40m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9344), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 16m, 76m, 19.20m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9348), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 22m, 196m, 26.40m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9351), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 251m, 127m, 301.20m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9354), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9355), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 193m, 157m, 231.60m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9359), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 129m, 109m, 154.80m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9363), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 50m, 40m, 60.00m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9367), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 253m, 100m, 303.60m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9370), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 177m, 131m, 212.40m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9374), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 92m, 200m, 110.40m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9379), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 130m, 193m, 156.00m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9383), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 204m, 120m, 244.80m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9387), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 78m, 97m, 93.60m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9389), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9391), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 63m, 137m, 75.60m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9394), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 175m, 76m, 210.00m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9398), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 151m, 6m, 181.20m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9402), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 253m, 53m, 303.60m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9406), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 162m, 66m, 194.40m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9410), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 15m, 76m, 18.00m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9443), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 2m, 88m, 2.40m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9447), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 142m, 28m, 170.40m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9451), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 77m, 103m, 92.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9455), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 228m, 144m, 273.60m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9458), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9459), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 251m, 190m, 301.20m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9462), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9463), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 188m, 80m, 225.60m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9466), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 253m, 110m, 303.60m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9470), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 35m, 149m, 42.00m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9474), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 160m, 128m, 192.00m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9478), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 262m, 132m, 314.40m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9482), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 241m, 132m, 289.20m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9486), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 199m, 15m, 238.80m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9490), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 129m, 142m, 154.80m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9493), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9495), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 233m, 64m, 279.60m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9498), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 235m, 83m, 282.00m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9502), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 43m, 158m, 51.60m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9506), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 27m, 88m, 32.40m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9509), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9510), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 124m, 36m, 148.80m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9512), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9514), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 242m, 156m, 290.40m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9518), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 179m, 13m, 214.80m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9521), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 68m, 0m, 81.60m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9558), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 149m, 131m, 178.80m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9562), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 243m, 127m, 291.60m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9566), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 259m, 185m, 310.80m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9569), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 22m, 42m, 26.40m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9573), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 132m, 176m, 158.40m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9576), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9577), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 237m, 171m, 284.40m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9580), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 156m, 41m, 187.20m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9584), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 241m, 28m, 289.20m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9587), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9588), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 38m, 31m, 45.60m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9591), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9592), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 182m, 47m, 218.40m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9596), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 236m, 71m, 283.20m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9600), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 238m, 163m, 285.60m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9604), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 47m, 74m, 56.40m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9608), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 151m, 99m, 181.20m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9611), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 235m, 22m, 282.00m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9616), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 135m, 113m, 162.00m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9620), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 30m, 92m, 36.00m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9624), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 132m, 171m, 158.40m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9657), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 83m, 104m, 99.60m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9662), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 2m, 99m, 2.40m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9666), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 241m, 199m, 289.20m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9670), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 213m, 73m, 255.60m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9673), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 143m, 134m, 171.60m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9677), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 189m, 155m, 226.80m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9681), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 196m, 94m, 235.20m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9684), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 278m, 175m, 333.60m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9687), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9688), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 136m, 161m, 163.20m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9692), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 203m, 60m, 243.60m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9696), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 83m, 57m, 99.60m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9700), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 207m, 87m, 248.40m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9704), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 170m, 107m, 204.00m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9706), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9708), "Description about product - French Baguette", true, 9, "French Baguette", 82, 172m, 149m, 206.40m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9711), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 296m, 67m, 355.20m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9715), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 200m, 9m, 240.00m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9718), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9719), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 103m, 168m, 123.60m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9723), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 99m, 113m, 118.80m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9727), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 226m, 29m, 271.20m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9730), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 206m, 129m, 247.20m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9734), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 256m, 67m, 307.20m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9738), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 297m, 195m, 356.40m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9774), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 98m, 19m, 117.60m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9777), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 242m, 20m, 290.40m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9781), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 287m, 51m, 344.40m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9785), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 236m, 121m, 283.20m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9789), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 256m, 82m, 307.20m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9791), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9792), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 18m, 156m, 21.60m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9795), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9796), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 121m, 186m, 145.20m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9800), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 184m, 137m, 220.80m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9802), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9804), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 76m, 136m, 91.20m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9808), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 253m, 146m, 303.60m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9811), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 295m, 70m, 354.00m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9815), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 92m, 73m, 110.40m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9819), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 6m, 143m, 7.20m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9823), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 211m, 23m, 253.20m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9827), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 38m, 13m, 45.60m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9830), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 53m, 58m, 63.60m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9835), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 231m, 82m, 277.20m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9839), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 136m, 106m, 163.20m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9842), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 113m, 59m, 135.60m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9846), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 78m, 131m, 93.60m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9850), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 48m, 131m, 57.60m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9854), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 290m, 188m, 348.00m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9890), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 130m, 199m, 156.00m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9894), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 206m, 54m, 247.20m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9897), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 18m, 168m, 21.60m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9901), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 242m, 89m, 290.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9904), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 130m, 198m, 156.00m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9908), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 108m, 119m, 129.60m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9912), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 45m, 22m, 54.00m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9916), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 157m, 197m, 188.40m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9920), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 209m, 150m, 250.80m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9924), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 183m, 55m, 219.60m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9927), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 207m, 89m, 248.40m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9931), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 252m, 22m, 302.40m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9934), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 218m, 153m, 261.60m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9938), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 290m, 124m, 348.00m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9942), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 21m, 100m, 25.20m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9946), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 34m, 28m, 40.80m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9950), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 141m, 148m, 169.20m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9994), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 28m, 17m, 33.60m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 4, 18, 16, 57, 3, 477, DateTimeKind.Local).AddTicks(9998), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 106m, 167m, 127.20m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(1), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 202m, 73m, 242.40m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(6), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 83m, 95m, 99.60m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(9), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 218m, 97m, 261.60m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(13), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 50m, 86m, 60.00m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(17), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 221m, 88m, 265.20m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(20), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 158m, 3m, 189.60m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(24), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 103m, 67m, 123.60m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(28), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 52m, 19m, 62.40m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(32), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 285m, 144m, 342.00m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(36), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 258m, 114m, 309.60m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(39), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(40), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 183m, 82m, 219.60m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(43), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 202m, 163m, 242.40m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(47), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 163m, 73m, 195.60m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(50), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 118m, 49m, 141.60m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(54), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 111m, 174m, 133.20m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(58), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 241m, 5m, 289.20m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(62), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 295m, 77m, 354.00m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(66), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 101m, 43m, 121.20m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 4, 18, 16, 57, 3, 478, DateTimeKind.Local).AddTicks(69), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 30m, 10m, 36.00m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 52, "111111111111" },
                    { 2, true, 41, "111111111111" },
                    { 3, true, 2, "444444444444" },
                    { 4, true, 13, "777777777777" },
                    { 5, true, 103, "333333333333" },
                    { 6, true, 36, "555555555555" },
                    { 7, true, 64, "999999999999" },
                    { 8, true, 102, "999999999999" },
                    { 9, true, 116, "555555555555" },
                    { 10, true, 73, "333333333333" },
                    { 11, true, 75, "555555555555" },
                    { 12, true, 96, "555555555555" },
                    { 13, true, 48, "666666666666" },
                    { 14, true, 143, "444444444444" },
                    { 15, true, 78, "777777777777" },
                    { 16, true, 21, "111111111111" },
                    { 17, true, 75, "555555555555" },
                    { 18, true, 2, "777777777777" },
                    { 19, true, 8, "222222222222" },
                    { 20, true, 135, "555555555555" },
                    { 21, true, 25, "444444444444" },
                    { 22, true, 59, "222222222222" },
                    { 23, true, 93, "444444444444" },
                    { 24, true, 45, "777777777777" },
                    { 25, true, 105, "111111111111" },
                    { 26, true, 89, "111111111111" },
                    { 27, true, 49, "333333333333" },
                    { 28, true, 107, "333333333333" },
                    { 29, true, 5, "111111111111" },
                    { 30, true, 63, "444444444444" },
                    { 31, true, 67, "444444444444" },
                    { 32, true, 72, "555555555555" },
                    { 33, true, 34, "333333333333" },
                    { 34, true, 12, "777777777777" },
                    { 35, true, 117, "333333333333" },
                    { 36, true, 68, "666666666666" },
                    { 37, true, 117, "111111111111" },
                    { 38, true, 141, "555555555555" },
                    { 39, true, 51, "222222222222" },
                    { 40, true, 107, "444444444444" },
                    { 41, true, 4, "555555555555" },
                    { 42, true, 42, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 62, "333333333333" },
                    { 44, true, 94, "222222222222" },
                    { 45, true, 34, "666666666666" },
                    { 46, true, 141, "333333333333" },
                    { 47, true, 100, "111111111111" },
                    { 48, true, 3, "999999999999" },
                    { 49, true, 108, "555555555555" },
                    { 50, true, 101, "222222222222" },
                    { 51, true, 43, "555555555555" },
                    { 52, true, 108, "111111111111" },
                    { 53, true, 11, "777777777777" },
                    { 54, true, 81, "666666666666" },
                    { 55, true, 10, "666666666666" },
                    { 56, true, 7, "999999999999" },
                    { 57, true, 142, "333333333333" },
                    { 58, true, 45, "777777777777" },
                    { 59, true, 134, "555555555555" },
                    { 60, true, 17, "888888888888" },
                    { 61, true, 1, "111111111111" },
                    { 62, true, 50, "444444444444" },
                    { 63, true, 96, "111111111111" },
                    { 64, true, 69, "666666666666" },
                    { 65, true, 17, "666666666666" },
                    { 66, true, 114, "555555555555" },
                    { 67, true, 41, "777777777777" },
                    { 68, true, 150, "777777777777" },
                    { 69, true, 84, "222222222222" },
                    { 70, true, 103, "222222222222" },
                    { 71, true, 150, "222222222222" },
                    { 72, true, 77, "666666666666" },
                    { 73, true, 24, "777777777777" },
                    { 74, true, 46, "999999999999" },
                    { 75, true, 119, "444444444444" },
                    { 76, true, 149, "222222222222" },
                    { 77, true, 42, "333333333333" },
                    { 78, true, 23, "444444444444" },
                    { 79, true, 122, "333333333333" },
                    { 80, true, 83, "555555555555" },
                    { 81, true, 13, "999999999999" },
                    { 82, true, 134, "888888888888" },
                    { 83, true, 22, "111111111111" },
                    { 84, true, 75, "555555555555" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 78, "222222222222" },
                    { 86, true, 79, "333333333333" },
                    { 87, true, 50, "333333333333" },
                    { 88, true, 61, "888888888888" },
                    { 89, true, 110, "777777777777" },
                    { 90, true, 138, "999999999999" },
                    { 91, true, 139, "444444444444" },
                    { 92, true, 36, "666666666666" },
                    { 93, true, 75, "555555555555" },
                    { 94, true, 46, "666666666666" },
                    { 95, true, 31, "888888888888" },
                    { 96, true, 100, "777777777777" },
                    { 97, true, 62, "888888888888" },
                    { 98, true, 106, "333333333333" },
                    { 99, true, 110, "999999999999" },
                    { 100, true, 146, "777777777777" },
                    { 101, true, 20, "333333333333" },
                    { 102, true, 60, "333333333333" },
                    { 103, true, 6, "444444444444" },
                    { 104, true, 8, "111111111111" },
                    { 105, true, 90, "888888888888" },
                    { 106, true, 31, "555555555555" },
                    { 107, true, 88, "555555555555" },
                    { 108, true, 66, "111111111111" },
                    { 109, true, 73, "444444444444" },
                    { 110, true, 18, "444444444444" },
                    { 111, true, 90, "333333333333" },
                    { 112, true, 56, "555555555555" },
                    { 113, true, 114, "333333333333" },
                    { 114, true, 82, "222222222222" },
                    { 115, true, 80, "222222222222" },
                    { 116, true, 65, "222222222222" },
                    { 117, true, 149, "222222222222" },
                    { 118, true, 121, "222222222222" },
                    { 119, true, 42, "999999999999" },
                    { 120, true, 34, "555555555555" },
                    { 121, true, 141, "111111111111" },
                    { 122, true, 59, "111111111111" },
                    { 123, true, 140, "333333333333" },
                    { 124, true, 99, "222222222222" },
                    { 125, true, 126, "111111111111" },
                    { 126, true, 13, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 57, "111111111111" },
                    { 128, true, 71, "111111111111" },
                    { 129, true, 86, "999999999999" },
                    { 130, true, 10, "999999999999" },
                    { 131, true, 70, "999999999999" },
                    { 132, true, 31, "666666666666" },
                    { 133, true, 89, "888888888888" },
                    { 134, true, 62, "777777777777" },
                    { 135, true, 146, "555555555555" },
                    { 136, true, 130, "333333333333" },
                    { 137, true, 46, "777777777777" },
                    { 138, true, 83, "333333333333" },
                    { 139, true, 119, "111111111111" },
                    { 140, true, 126, "777777777777" },
                    { 141, true, 19, "333333333333" },
                    { 142, true, 42, "111111111111" },
                    { 143, true, 62, "555555555555" },
                    { 144, true, 98, "666666666666" },
                    { 145, true, 73, "888888888888" },
                    { 146, true, 50, "888888888888" },
                    { 147, true, 142, "111111111111" },
                    { 148, true, 73, "999999999999" },
                    { 149, true, 133, "999999999999" },
                    { 150, true, 134, "555555555555" }
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
