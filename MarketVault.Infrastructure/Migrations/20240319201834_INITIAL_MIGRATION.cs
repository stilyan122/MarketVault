using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketVault.Infrastructure.Migrations
{
    public partial class INITIAL_MIGRATION : Migration
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
                    DateMade = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DateTime when made")
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
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9125), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 149m, 12m, 178.80m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9139), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 90m, 82m, 108.00m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9143), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 201m, 72m, 241.20m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9147), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 57m, 132m, 68.40m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9151), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 199m, 130m, 238.80m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9156), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 255m, 119m, 306.00m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9160), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 236m, 16m, 283.20m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9164), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 225m, 188m, 270.00m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9168), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 33m, 128m, 39.60m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9172), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 2m, 189m, 2.40m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9176), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 77m, 141m, 92.40m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9180), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 14m, 184m, 16.80m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9184), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 246m, 59m, 295.20m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9188), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 152m, 66m, 182.40m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9191), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 272m, 11m, 326.40m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9386), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 101m, 16m, 121.20m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9399), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 279m, 72m, 334.80m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9406), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 53m, 86m, 63.60m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9410), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 43m, 93m, 51.60m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9413), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9414), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 164m, 197m, 196.80m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9417), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 104m, 20m, 124.80m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9421), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 101m, 79m, 121.20m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9425), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 54m, 154m, 64.80m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9429), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 128m, 92m, 153.60m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9433), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 39m, 109m, 46.80m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9436), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 240m, 124m, 288.00m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9440), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 262m, 3m, 314.40m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9444), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 170m, 40m, 204.00m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9447), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 285m, 151m, 342.00m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9450), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 26m, 67m, 31.20m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9454), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 162m, 112m, 194.40m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9458), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 208m, 37m, 249.60m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9462), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 281m, 31m, 337.20m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9466), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 276m, 45m, 331.20m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9470), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 285m, 21m, 342.00m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9644), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 224m, 189m, 268.80m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9653), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 181m, 119m, 217.20m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9657), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 176m, 61m, 211.20m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9660), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9661), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 294m, 76m, 352.80m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9664), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9665), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 138m, 92m, 165.60m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9669), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 93m, 142m, 111.60m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9673), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 66m, 10m, 79.20m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9676), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 28m, 183m, 33.60m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9679), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9680), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 114m, 48m, 136.80m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9684), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 228m, 108m, 273.60m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9688), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 152m, 93m, 182.40m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9692), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 75m, 18m, 90.00m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9695), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 67m, 179m, 80.40m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9699), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 140m, 198m, 168.00m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9702), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 110m, 34m, 132.00m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9706), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 102m, 144m, 122.40m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9710), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 210m, 4m, 252.00m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9712), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9713), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 195m, 165m, 234.00m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9717), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 15m, 91m, 18.00m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9720), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 167m, 70m, 200.40m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9724), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 127m, 127m, 152.40m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(9727), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 287m, 0m, 344.40m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(84), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 257m, 172m, 308.40m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(89), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 80m, 37m, 96.00m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(93), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 45m, 60m, 54.00m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(97), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 132m, 180m, 158.40m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(101), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 225m, 177m, 270.00m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(105), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 288m, 132m, 345.60m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(109), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 179m, 28m, 214.80m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(112), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(113), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 2m, 149m, 2.40m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(119), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 22m, 20m, 26.40m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(123), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 282m, 97m, 338.40m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(127), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 264m, 30m, 316.80m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(129), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(130), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 14m, 190m, 16.80m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(134), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 257m, 35m, 308.40m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(137), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 152m, 52m, 182.40m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(141), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 230m, 72m, 276.00m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(144), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 117m, 158m, 140.40m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(148), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 128m, 82m, 153.60m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(152), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 111m, 119m, 133.20m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(193), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 242m, 102m, 290.40m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(197), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 168m, 73m, 201.60m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(201), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 296m, 82m, 355.20m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(205), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 19m, 182m, 22.80m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(208), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 161m, 54m, 193.20m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(211), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(212), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 18m, 99m, 21.60m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(216), "Description about product - French Baguette", true, 9, "French Baguette", 82, 283m, 176m, 339.60m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(220), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 39m, 98m, 46.80m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(223), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 24m, 192m, 28.80m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(227), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 122m, 158m, 146.40m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(231), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 220m, 96m, 264.00m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(234), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 56m, 6m, 67.20m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(238), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 272m, 51m, 326.40m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(242), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 190m, 7m, 228.00m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(244), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(245), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 174m, 19m, 208.80m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(249), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 160m, 198m, 192.00m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(252), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 2m, 125m, 2.40m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(256), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 1m, 64m, 1.20m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(259), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 277m, 93m, 332.40m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(263), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 61m, 187m, 73.20m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(266), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 271m, 115m, 325.20m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(270), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 137m, 118m, 164.40m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(676), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 230m, 19m, 276.00m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(683), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 224m, 81m, 268.80m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(687), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 258m, 144m, 309.60m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(691), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 14m, 157m, 16.80m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(695), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 71m, 77m, 85.20m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(698), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 160m, 174m, 192.00m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(702), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 170m, 174m, 204.00m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(706), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 253m, 105m, 303.60m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(710), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 263m, 194m, 315.60m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(713), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 230m, 132m, 276.00m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(717), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 18m, 178m, 21.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(721), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 44m, 40m, 52.80m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(724), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 120m, 175m, 144.00m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(728), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 140m, 101m, 168.00m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(732), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 281m, 8m, 337.20m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(735), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 95m, 154m, 114.00m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(738), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 136m, 130m, 163.20m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(742), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 4m, 50m, 4.80m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(745), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 142m, 114m, 170.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(749), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 246m, 136m, 295.20m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(752), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(753), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 269m, 115m, 322.80m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(755), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(756), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 85m, 86m, 102.00m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1128), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 296m, 99m, 355.20m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1134), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 46m, 29m, 55.20m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1138), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 168m, 156m, 201.60m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1142), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 250m, 27m, 300.00m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1144), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1145), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 218m, 174m, 261.60m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1149), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 57m, 142m, 68.40m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1153), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 91m, 95m, 109.20m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1157), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 117m, 119m, 140.40m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1161), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 199m, 0m, 238.80m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1164), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 32m, 168m, 38.40m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1169), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1171), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 202m, 99m, 242.40m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1175), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 94m, 20m, 112.80m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1178), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1179), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 55m, 69m, 66.00m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1183), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 7m, 112m, 8.40m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1186), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 248m, 25m, 297.60m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1190), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 297m, 79m, 356.40m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1548), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 283m, 47m, 339.60m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1556), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 27m, 129m, 32.40m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1560), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 87m, 93m, 104.40m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1563), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1564), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 35m, 176m, 42.00m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1568), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 41m, 180m, 49.20m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1572), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 290m, 6m, 348.00m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1576), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 236m, 59m, 283.20m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1579), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 236m, 179m, 283.20m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1583), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 59m, 196m, 70.80m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1586), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 113m, 199m, 135.60m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1589), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1590), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 298m, 165m, 357.60m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1594), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 293m, 161m, 351.60m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1597), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 229m, 62m, 274.80m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1601), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 76m, 135m, 91.20m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 3, 19, 22, 18, 33, 517, DateTimeKind.Local).AddTicks(1604), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 52m, 22m, 62.40m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 30, "555555555555" },
                    { 2, true, 120, "222222222222" },
                    { 3, true, 119, "222222222222" },
                    { 4, true, 37, "777777777777" },
                    { 5, true, 3, "777777777777" },
                    { 6, true, 88, "888888888888" },
                    { 7, true, 139, "888888888888" },
                    { 8, true, 30, "666666666666" },
                    { 9, true, 77, "111111111111" },
                    { 10, true, 125, "111111111111" },
                    { 11, true, 56, "666666666666" },
                    { 12, true, 78, "333333333333" },
                    { 13, true, 120, "222222222222" },
                    { 14, true, 60, "444444444444" },
                    { 15, true, 48, "111111111111" },
                    { 16, true, 98, "777777777777" },
                    { 17, true, 119, "111111111111" },
                    { 18, true, 80, "555555555555" },
                    { 19, true, 100, "888888888888" },
                    { 20, true, 26, "555555555555" },
                    { 21, true, 2, "666666666666" },
                    { 22, true, 91, "999999999999" },
                    { 23, true, 34, "222222222222" },
                    { 24, true, 52, "111111111111" },
                    { 25, true, 1, "666666666666" },
                    { 26, true, 8, "333333333333" },
                    { 27, true, 19, "555555555555" },
                    { 28, true, 48, "777777777777" },
                    { 29, true, 126, "555555555555" },
                    { 30, true, 96, "333333333333" },
                    { 31, true, 99, "222222222222" },
                    { 32, true, 106, "111111111111" },
                    { 33, true, 131, "999999999999" },
                    { 34, true, 23, "999999999999" },
                    { 35, true, 71, "444444444444" },
                    { 36, true, 23, "333333333333" },
                    { 37, true, 71, "777777777777" },
                    { 38, true, 82, "666666666666" },
                    { 39, true, 33, "555555555555" },
                    { 40, true, 38, "777777777777" },
                    { 41, true, 30, "111111111111" },
                    { 42, true, 95, "111111111111" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 60, "999999999999" },
                    { 44, true, 11, "222222222222" },
                    { 45, true, 1, "111111111111" },
                    { 46, true, 101, "111111111111" },
                    { 47, true, 66, "111111111111" },
                    { 48, true, 119, "999999999999" },
                    { 49, true, 132, "333333333333" },
                    { 50, true, 17, "777777777777" },
                    { 51, true, 90, "888888888888" },
                    { 52, true, 71, "666666666666" },
                    { 53, true, 7, "777777777777" },
                    { 54, true, 24, "555555555555" },
                    { 55, true, 16, "444444444444" },
                    { 56, true, 18, "111111111111" },
                    { 57, true, 122, "777777777777" },
                    { 58, true, 121, "666666666666" },
                    { 59, true, 29, "777777777777" },
                    { 60, true, 106, "888888888888" },
                    { 61, true, 131, "444444444444" },
                    { 62, true, 71, "555555555555" },
                    { 63, true, 61, "666666666666" },
                    { 64, true, 80, "777777777777" },
                    { 65, true, 86, "333333333333" },
                    { 66, true, 41, "333333333333" },
                    { 67, true, 54, "999999999999" },
                    { 68, true, 100, "555555555555" },
                    { 69, true, 139, "666666666666" },
                    { 70, true, 121, "999999999999" },
                    { 71, true, 113, "444444444444" },
                    { 72, true, 14, "222222222222" },
                    { 73, true, 52, "111111111111" },
                    { 74, true, 149, "333333333333" },
                    { 75, true, 15, "777777777777" },
                    { 76, true, 110, "888888888888" },
                    { 77, true, 146, "777777777777" },
                    { 78, true, 102, "666666666666" },
                    { 79, true, 92, "666666666666" },
                    { 80, true, 127, "999999999999" },
                    { 81, true, 98, "999999999999" },
                    { 82, true, 45, "777777777777" },
                    { 83, true, 103, "222222222222" },
                    { 84, true, 149, "666666666666" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 13, "555555555555" },
                    { 86, true, 85, "444444444444" },
                    { 87, true, 148, "555555555555" },
                    { 88, true, 42, "999999999999" },
                    { 89, true, 68, "888888888888" },
                    { 90, true, 44, "999999999999" },
                    { 91, true, 70, "666666666666" },
                    { 92, true, 20, "555555555555" },
                    { 93, true, 22, "444444444444" },
                    { 94, true, 20, "222222222222" },
                    { 95, true, 108, "444444444444" },
                    { 96, true, 45, "888888888888" },
                    { 97, true, 98, "666666666666" },
                    { 98, true, 6, "555555555555" },
                    { 99, true, 104, "333333333333" },
                    { 100, true, 60, "777777777777" },
                    { 101, true, 143, "666666666666" },
                    { 102, true, 43, "777777777777" },
                    { 103, true, 97, "555555555555" },
                    { 104, true, 79, "555555555555" },
                    { 105, true, 18, "333333333333" },
                    { 106, true, 96, "333333333333" },
                    { 107, true, 131, "777777777777" },
                    { 108, true, 70, "333333333333" },
                    { 109, true, 132, "111111111111" },
                    { 110, true, 28, "333333333333" },
                    { 111, true, 54, "555555555555" },
                    { 112, true, 147, "777777777777" },
                    { 113, true, 3, "999999999999" },
                    { 114, true, 40, "555555555555" },
                    { 115, true, 104, "333333333333" },
                    { 116, true, 30, "222222222222" },
                    { 117, true, 110, "888888888888" },
                    { 118, true, 26, "222222222222" },
                    { 119, true, 97, "777777777777" },
                    { 120, true, 120, "333333333333" },
                    { 121, true, 50, "666666666666" },
                    { 122, true, 4, "999999999999" },
                    { 123, true, 104, "666666666666" },
                    { 124, true, 118, "777777777777" },
                    { 125, true, 70, "888888888888" },
                    { 126, true, 92, "555555555555" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 57, "111111111111" },
                    { 128, true, 13, "333333333333" },
                    { 129, true, 13, "111111111111" },
                    { 130, true, 2, "222222222222" },
                    { 131, true, 30, "666666666666" },
                    { 132, true, 27, "444444444444" },
                    { 133, true, 26, "777777777777" },
                    { 134, true, 36, "888888888888" },
                    { 135, true, 6, "888888888888" },
                    { 136, true, 130, "999999999999" },
                    { 137, true, 55, "222222222222" },
                    { 138, true, 128, "333333333333" },
                    { 139, true, 7, "888888888888" },
                    { 140, true, 47, "111111111111" },
                    { 141, true, 139, "333333333333" },
                    { 142, true, 118, "222222222222" },
                    { 143, true, 5, "666666666666" },
                    { 144, true, 93, "999999999999" },
                    { 145, true, 148, "999999999999" },
                    { 146, true, 64, "888888888888" },
                    { 147, true, 48, "111111111111" },
                    { 148, true, 123, "666666666666" },
                    { 149, true, 115, "555555555555" },
                    { 150, true, 112, "888888888888" }
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
                columns: new[] { "Id", "CounterPartyId", "DateMade", "DocumentTypeId", "TotalPurchasePriceWithVAT", "TotalPurchasePriceWithoutVAT", "TotalSalePriceWithVAT", "TotalSalePriceWithoutVAT" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8767), 1, 70.00m, 58.33m, 100.00m, 83.33m },
                    { 2, 2, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8804), 1, 50.00m, 41.67m, 75.00m, 62.50m },
                    { 3, 3, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8807), 2, 40.00m, 33.33m, 60.00m, 50.00m },
                    { 4, 4, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8809), 2, 100.00m, 83.33m, 150.00m, 125.00m },
                    { 5, 5, new DateTime(2024, 3, 19, 22, 18, 33, 516, DateTimeKind.Local).AddTicks(8812), 1, 150.00m, 125.00m, 200.00m, 166.67m }
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
