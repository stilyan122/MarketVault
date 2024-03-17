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
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(878), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 188m, 89m, 225.60m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(896), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 211m, 38m, 253.20m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(900), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(901), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 10m, 160m, 12.00m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(905), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 105m, 170m, 126.00m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(909), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 277m, 98m, 332.40m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(912), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(914), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 279m, 74m, 334.80m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(918), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 230m, 39m, 276.00m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(921), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 245m, 49m, 294.00m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(925), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 241m, 179m, 289.20m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(928), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(929), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 140m, 168m, 168.00m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(932), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 11m, 96m, 13.20m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(936), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 181m, 168m, 217.20m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(940), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 79m, 173m, 94.80m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(943), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 163m, 155m, 195.60m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(993), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 152m, 49m, 182.40m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(998), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 27m, 55m, 32.40m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1002), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 248m, 140m, 297.60m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1006), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 81m, 87m, 97.20m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1009), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 238m, 6m, 285.60m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1013), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 95m, 127m, 114.00m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1016), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 277m, 51m, 332.40m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1020), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 205m, 113m, 246.00m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1024), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 263m, 90m, 315.60m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1027), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 221m, 76m, 265.20m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1031), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 271m, 133m, 325.20m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1034), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 172m, 109m, 206.40m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1038), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 141m, 12m, 169.20m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1041), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 274m, 21m, 328.80m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1045), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 272m, 77m, 326.40m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1049), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 118m, 159m, 141.60m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1052), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 66m, 103m, 79.20m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1056), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 4m, 68m, 4.80m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1061), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 211m, 69m, 253.20m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1065), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 160m, 90m, 192.00m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1293), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1295), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 218m, 3m, 261.60m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1300), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1301), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 64m, 197m, 76.80m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1304), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1305), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 70m, 164m, 84.00m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1309), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 217m, 54m, 260.40m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1311), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1312), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 124m, 140m, 148.80m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1315), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1316), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 133m, 100m, 159.60m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1320), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 277m, 91m, 332.40m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1323), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 160m, 158m, 192.00m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1327), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 109m, 52m, 130.80m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1330), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1331), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 78m, 133m, 93.60m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1333), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1335), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 91m, 2m, 109.20m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1338), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 246m, 112m, 295.20m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1341), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1342), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 256m, 39m, 307.20m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1346), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 287m, 57m, 344.40m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1348), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1349), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 101m, 114m, 121.20m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1353), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 81m, 171m, 97.20m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1355), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1356), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 170m, 177m, 204.00m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1360), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 66m, 48m, 79.20m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1363), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1364), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 8m, 7m, 9.60m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1367), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 57m, 93m, 68.40m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1371), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 133m, 170m, 159.60m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1374), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 243m, 21m, 291.60m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1434), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 200m, 18m, 240.00m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1438), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 105m, 105m, 126.00m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1441), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 8m, 16m, 9.60m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1445), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 97m, 90m, 116.40m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1448), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 29m, 14m, 34.80m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1452), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 244m, 140m, 292.80m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1456), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 3m, 20m, 3.60m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1459), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 40m, 147m, 48.00m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1463), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 193m, 196m, 231.60m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1467), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1468), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 56m, 37m, 67.20m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1471), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1472), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 206m, 196m, 247.20m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1475), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 215m, 83m, 258.00m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1479), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 126m, 171m, 151.20m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1483), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 69m, 144m, 82.80m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1486), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 103m, 187m, 123.60m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1490), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 94m, 62m, 112.80m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1493), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1494), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 150m, 101m, 180.00m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1496), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1497), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 7m, 65m, 8.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1715), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 6m, 192m, 7.20m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1725), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 36m, 50m, 43.20m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1729), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1731), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 214m, 130m, 256.80m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1737), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 183m, 177m, 219.60m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1741), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 26m, 95m, 31.20m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1743), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1744), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 227m, 129m, 272.40m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1748), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 122m, 111m, 146.40m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1751), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1752), "Description about product - French Baguette", true, 9, "French Baguette", 82, 196m, 32m, 235.20m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1754), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1755), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 235m, 2m, 282.00m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1759), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 152m, 112m, 182.40m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1763), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 8m, 55m, 9.60m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1765), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1766), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 54m, 29m, 64.80m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1769), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1770), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 39m, 191m, 46.80m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1774), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 94m, 147m, 112.80m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1777), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 219m, 120m, 262.80m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1780), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 104m, 144m, 124.80m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1784), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 136m, 173m, 163.20m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1787), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1788), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 2m, 197m, 2.40m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1792), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 94m, 120m, 112.80m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1795), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 248m, 90m, 297.60m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1798), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1799), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 294m, 173m, 352.80m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1802), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 81m, 116m, 97.20m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1862), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 10m, 6m, 12.00m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1866), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 267m, 181m, 320.40m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1869), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 107m, 193m, 128.40m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1872), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1873), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 232m, 143m, 278.40m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1877), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 66m, 118m, 79.20m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1880), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 252m, 75m, 302.40m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1883), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1884), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 229m, 79m, 274.80m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1888), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 265m, 142m, 318.00m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1891), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 27m, 169m, 32.40m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1894), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1895), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 206m, 131m, 247.20m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1899), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 184m, 158m, 220.80m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1901), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1902), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 233m, 54m, 279.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1905), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1907), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 278m, 190m, 333.60m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1910), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 99m, 109m, 118.80m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1913), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1914), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 27m, 133m, 32.40m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1918), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 286m, 136m, 343.20m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1921), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 263m, 186m, 315.60m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1925), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 209m, 49m, 250.80m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1929), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 212m, 167m, 254.40m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1931), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1932), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 132m, 31m, 158.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1936), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 206m, 71m, 247.20m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1939), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 274m, 11m, 328.80m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1981), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 166m, 85m, 199.20m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1985), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 252m, 76m, 302.40m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1989), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 99m, 110m, 118.80m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1992), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 247m, 88m, 296.40m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1996), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 84m, 164m, 100.80m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(1999), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 159m, 64m, 190.80m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2003), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 291m, 41m, 349.20m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2005), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2006), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 62m, 100m, 74.40m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2010), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 82m, 11m, 98.40m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2013), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 158m, 138m, 189.60m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2017), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 68m, 189m, 81.60m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2022), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2023), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 64m, 175m, 76.80m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2025), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2026), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 282m, 121m, 338.40m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2030), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 134m, 149m, 160.80m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2034), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 171m, 188m, 205.20m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2037), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 135m, 22m, 162.00m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2089), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2091), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 100m, 4m, 120.00m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2095), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 157m, 6m, 188.40m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2099), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 249m, 33m, 298.80m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2102), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 1m, 48m, 1.20m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2106), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 83m, 51m, 99.60m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2110), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 147m, 78m, 176.40m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2114), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 299m, 90m, 358.80m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2116), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2117), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 84m, 140m, 100.80m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2121), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 253m, 52m, 303.60m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2124), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 105m, 36m, 126.00m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2128), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 38m, 29m, 45.60m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2132), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 123m, 166m, 147.60m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2135), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 287m, 61m, 344.40m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2139), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 250m, 32m, 300.00m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2143), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 108m, 88m, 129.60m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(2146), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 251m, 33m, 301.20m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 122, "333333333333" },
                    { 2, true, 19, "999999999999" },
                    { 3, true, 145, "888888888888" },
                    { 4, true, 33, "222222222222" },
                    { 5, true, 20, "999999999999" },
                    { 6, true, 72, "666666666666" },
                    { 7, true, 150, "444444444444" },
                    { 8, true, 32, "666666666666" },
                    { 9, true, 37, "111111111111" },
                    { 10, true, 55, "999999999999" },
                    { 11, true, 142, "111111111111" },
                    { 12, true, 32, "333333333333" },
                    { 13, true, 109, "666666666666" },
                    { 14, true, 140, "555555555555" },
                    { 15, true, 107, "999999999999" },
                    { 16, true, 115, "555555555555" },
                    { 17, true, 104, "999999999999" },
                    { 18, true, 132, "555555555555" },
                    { 19, true, 117, "888888888888" },
                    { 20, true, 81, "666666666666" },
                    { 21, true, 18, "333333333333" },
                    { 22, true, 10, "444444444444" },
                    { 23, true, 36, "555555555555" },
                    { 24, true, 127, "999999999999" },
                    { 25, true, 75, "444444444444" },
                    { 26, true, 61, "888888888888" },
                    { 27, true, 21, "888888888888" },
                    { 28, true, 104, "111111111111" },
                    { 29, true, 4, "333333333333" },
                    { 30, true, 13, "777777777777" },
                    { 31, true, 129, "555555555555" },
                    { 32, true, 53, "666666666666" },
                    { 33, true, 14, "555555555555" },
                    { 34, true, 116, "666666666666" },
                    { 35, true, 17, "666666666666" },
                    { 36, true, 15, "666666666666" },
                    { 37, true, 33, "222222222222" },
                    { 38, true, 16, "111111111111" },
                    { 39, true, 148, "777777777777" },
                    { 40, true, 133, "555555555555" },
                    { 41, true, 71, "444444444444" },
                    { 42, true, 103, "222222222222" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 10, "888888888888" },
                    { 44, true, 77, "888888888888" },
                    { 45, true, 126, "555555555555" },
                    { 46, true, 93, "999999999999" },
                    { 47, true, 74, "111111111111" },
                    { 48, true, 119, "777777777777" },
                    { 49, true, 16, "111111111111" },
                    { 50, true, 75, "555555555555" },
                    { 51, true, 88, "333333333333" },
                    { 52, true, 127, "222222222222" },
                    { 53, true, 99, "777777777777" },
                    { 54, true, 89, "333333333333" },
                    { 55, true, 56, "444444444444" },
                    { 56, true, 30, "333333333333" },
                    { 57, true, 16, "222222222222" },
                    { 58, true, 90, "777777777777" },
                    { 59, true, 112, "111111111111" },
                    { 60, true, 10, "111111111111" },
                    { 61, true, 4, "999999999999" },
                    { 62, true, 106, "555555555555" },
                    { 63, true, 96, "999999999999" },
                    { 64, true, 148, "444444444444" },
                    { 65, true, 93, "333333333333" },
                    { 66, true, 6, "222222222222" },
                    { 67, true, 40, "666666666666" },
                    { 68, true, 113, "333333333333" },
                    { 69, true, 6, "999999999999" },
                    { 70, true, 106, "777777777777" },
                    { 71, true, 1, "333333333333" },
                    { 72, true, 80, "888888888888" },
                    { 73, true, 71, "111111111111" },
                    { 74, true, 18, "111111111111" },
                    { 75, true, 121, "444444444444" },
                    { 76, true, 103, "333333333333" },
                    { 77, true, 41, "999999999999" },
                    { 78, true, 69, "333333333333" },
                    { 79, true, 114, "222222222222" },
                    { 80, true, 88, "555555555555" },
                    { 81, true, 124, "666666666666" },
                    { 82, true, 14, "888888888888" },
                    { 83, true, 10, "999999999999" },
                    { 84, true, 33, "111111111111" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 83, "555555555555" },
                    { 86, true, 70, "222222222222" },
                    { 87, true, 125, "111111111111" },
                    { 88, true, 19, "555555555555" },
                    { 89, true, 97, "999999999999" },
                    { 90, true, 53, "888888888888" },
                    { 91, true, 32, "666666666666" },
                    { 92, true, 98, "333333333333" },
                    { 93, true, 121, "777777777777" },
                    { 94, true, 118, "444444444444" },
                    { 95, true, 4, "999999999999" },
                    { 96, true, 45, "666666666666" },
                    { 97, true, 25, "777777777777" },
                    { 98, true, 60, "444444444444" },
                    { 99, true, 41, "111111111111" },
                    { 100, true, 42, "888888888888" },
                    { 101, true, 18, "999999999999" },
                    { 102, true, 47, "777777777777" },
                    { 103, true, 89, "444444444444" },
                    { 104, true, 97, "222222222222" },
                    { 105, true, 110, "555555555555" },
                    { 106, true, 134, "555555555555" },
                    { 107, true, 146, "666666666666" },
                    { 108, true, 136, "222222222222" },
                    { 109, true, 82, "999999999999" },
                    { 110, true, 123, "555555555555" },
                    { 111, true, 115, "111111111111" },
                    { 112, true, 21, "999999999999" },
                    { 113, true, 2, "111111111111" },
                    { 114, true, 94, "333333333333" },
                    { 115, true, 93, "444444444444" },
                    { 116, true, 14, "222222222222" },
                    { 117, true, 35, "222222222222" },
                    { 118, true, 7, "555555555555" },
                    { 119, true, 61, "222222222222" },
                    { 120, true, 80, "111111111111" },
                    { 121, true, 26, "333333333333" },
                    { 122, true, 45, "888888888888" },
                    { 123, true, 98, "666666666666" },
                    { 124, true, 67, "222222222222" },
                    { 125, true, 48, "111111111111" },
                    { 126, true, 36, "444444444444" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 120, "333333333333" },
                    { 128, true, 67, "999999999999" },
                    { 129, true, 51, "333333333333" },
                    { 130, true, 132, "555555555555" },
                    { 131, true, 8, "777777777777" },
                    { 132, true, 40, "888888888888" },
                    { 133, true, 74, "999999999999" },
                    { 134, true, 53, "333333333333" },
                    { 135, true, 139, "555555555555" },
                    { 136, true, 14, "999999999999" },
                    { 137, true, 55, "111111111111" },
                    { 138, true, 58, "777777777777" },
                    { 139, true, 36, "888888888888" },
                    { 140, true, 55, "888888888888" },
                    { 141, true, 122, "333333333333" },
                    { 142, true, 134, "333333333333" },
                    { 143, true, 148, "777777777777" },
                    { 144, true, 58, "111111111111" },
                    { 145, true, 49, "777777777777" },
                    { 146, true, 25, "555555555555" },
                    { 147, true, 41, "222222222222" },
                    { 148, true, 40, "333333333333" },
                    { 149, true, 22, "111111111111" },
                    { 150, true, 78, "111111111111" }
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
                    { 1, 1, new DateTime(2024, 3, 17, 21, 3, 11, 485, DateTimeKind.Local).AddTicks(9964), 1, 70.00m, 58.33m, 100.00m, 83.33m },
                    { 2, 2, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(8), 1, 50.00m, 41.67m, 75.00m, 62.50m },
                    { 3, 3, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(11), 2, 40.00m, 33.33m, 60.00m, 50.00m },
                    { 4, 4, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(14), 2, 100.00m, 83.33m, 150.00m, 125.00m },
                    { 5, 5, new DateTime(2024, 3, 17, 21, 3, 11, 486, DateTimeKind.Local).AddTicks(16), 1, 150.00m, 125.00m, 200.00m, 166.67m }
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
