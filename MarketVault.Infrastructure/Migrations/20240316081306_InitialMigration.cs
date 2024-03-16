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
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5048), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 261m, 177m, 313.20m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5063), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 53m, 147m, 63.60m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5068), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 113m, 49m, 135.60m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5072), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 40m, 56m, 48.00m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5076), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 250m, 66m, 300.00m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5081), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 79m, 26m, 94.80m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5084), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 110m, 99m, 132.00m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5088), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 20m, 101m, 24.00m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5092), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 187m, 81m, 224.40m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5097), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 23m, 38m, 27.60m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5100), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 181m, 9m, 217.20m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5104), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 296m, 5m, 355.20m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5132), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 85m, 56m, 102.00m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5136), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 50m, 111m, 60.00m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5139), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5140), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 78m, 140m, 93.60m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5143), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 265m, 24m, 318.00m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5147), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 268m, 26m, 321.60m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5151), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 181m, 107m, 217.20m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5155), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 130m, 21m, 156.00m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5159), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 287m, 104m, 344.40m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5163), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 75m, 122m, 90.00m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5167), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 118m, 152m, 141.60m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5171), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 84m, 26m, 100.80m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5175), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 129m, 1m, 154.80m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5179), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 269m, 39m, 322.80m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5182), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 216m, 31m, 259.20m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5186), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 276m, 24m, 331.20m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5189), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 150m, 80m, 180.00m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5192), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 256m, 93m, 307.20m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5196), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 165m, 171m, 198.00m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5199), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5200), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 114m, 197m, 136.80m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5204), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 61m, 80m, 73.20m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5208), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 7m, 103m, 8.40m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5235), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 93m, 133m, 111.60m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5238), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5239), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 232m, 60m, 278.40m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5243), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 165m, 196m, 198.00m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5246), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 213m, 102m, 255.60m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5250), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 290m, 49m, 348.00m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5253), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 149m, 82m, 178.80m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5257), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 217m, 93m, 260.40m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5261), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 27m, 99m, 32.40m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5263), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5264), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 138m, 100m, 165.60m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5267), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5268), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 269m, 9m, 322.80m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5272), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 24m, 69m, 28.80m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5274), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5275), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 124m, 140m, 148.80m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5279), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 84m, 183m, 100.80m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5282), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 204m, 17m, 244.80m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5286), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 264m, 56m, 316.80m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5289), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 95m, 138m, 114.00m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5293), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 84m, 5m, 100.80m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5297), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 135m, 187m, 162.00m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5301), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 115m, 41m, 138.00m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5304), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 50m, 72m, 60.00m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5308), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 272m, 185m, 326.40m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5334), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 50m, 162m, 60.00m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5338), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 270m, 148m, 324.00m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5341), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 244m, 147m, 292.80m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5345), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 296m, 121m, 355.20m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5348), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 240m, 184m, 288.00m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5352), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 192m, 198m, 230.40m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5355), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 72m, 187m, 86.40m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5359), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 133m, 17m, 159.60m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5361), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5363), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 253m, 14m, 303.60m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5366), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 129m, 105m, 154.80m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5370), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 118m, 137m, 141.60m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5373), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5374), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 136m, 82m, 163.20m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5378), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 210m, 168m, 252.00m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5381), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 76m, 22m, 91.20m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5384), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5385), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 121m, 164m, 145.20m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5388), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 142m, 107m, 170.40m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5392), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 59m, 126m, 70.80m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5395), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 148m, 159m, 177.60m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5423), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 16m, 91m, 19.20m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5427), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 296m, 191m, 355.20m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5429), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5431), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 240m, 39m, 288.00m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5433), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5434), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 162m, 51m, 194.40m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5438), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 273m, 84m, 327.60m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5441), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 102m, 156m, 122.40m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5445), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 222m, 91m, 266.40m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5449), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 82m, 40m, 98.40m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5453), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 157m, 125m, 188.40m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5457), "Description about product - French Baguette", true, 9, "French Baguette", 82, 158m, 133m, 189.60m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5459), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5460), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 176m, 196m, 211.20m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5464), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 2m, 140m, 2.40m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5467), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 93m, 92m, 111.60m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5469), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5471), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 198m, 99m, 237.60m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5474), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 26m, 4m, 31.20m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5477), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 199m, 137m, 238.80m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5481), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 165m, 187m, 198.00m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5483), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5484), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 251m, 106m, 301.20m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5486), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5487), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 148m, 184m, 177.60m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5491), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 260m, 137m, 312.00m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5495), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 113m, 94m, 135.60m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5498), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 191m, 137m, 229.20m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5537), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 190m, 33m, 228.00m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5541), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 94m, 109m, 112.80m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5545), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 130m, 195m, 156.00m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5549), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 253m, 170m, 303.60m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5552), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 25m, 192m, 30.00m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5556), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 260m, 93m, 312.00m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5560), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 200m, 190m, 240.00m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5562), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5563), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 281m, 70m, 337.20m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5567), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 214m, 127m, 256.80m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5570), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 33m, 187m, 39.60m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5574), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 81m, 99m, 97.20m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5576), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5578), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 196m, 160m, 235.20m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5580), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5581), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 99m, 133m, 118.80m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5585), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 188m, 53m, 225.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5588), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 114m, 170m, 136.80m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5592), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 145m, 93m, 174.00m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5594), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5595), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 181m, 199m, 217.20m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5598), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5599), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 241m, 19m, 289.20m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5602), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 108m, 15m, 129.60m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5606), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 42m, 101m, 50.40m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5610), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 172m, 93m, 206.40m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5614), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 20m, 20m, 24.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5641), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 247m, 69m, 296.40m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5645), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 280m, 87m, 336.00m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5648), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 116m, 118m, 139.20m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5652), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 111m, 57m, 133.20m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5656), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 176m, 1m, 211.20m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5659), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 189m, 77m, 226.80m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5664), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 177m, 58m, 212.40m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5668), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 228m, 178m, 273.60m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5672), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 16m, 40m, 19.20m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5675), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 141m, 120m, 169.20m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5678), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 177m, 106m, 212.40m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5681), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5682), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 83m, 156m, 99.60m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5685), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 145m, 155m, 174.00m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5690), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 50m, 26m, 60.00m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5694), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 109m, 120m, 130.80m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5697), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 297m, 48m, 356.40m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5724), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 33m, 89m, 39.60m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5728), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 94m, 41m, 112.80m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5732), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 178m, 70m, 213.60m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5736), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 134m, 80m, 160.80m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5739), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 228m, 91m, 273.60m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5743), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 254m, 140m, 304.80m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5747), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 279m, 48m, 334.80m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5750), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 111m, 30m, 133.20m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5754), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 197m, 78m, 236.40m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5757), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 51m, 175m, 61.20m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5761), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 47m, 38m, 56.40m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5764), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 134m, 105m, 160.80m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5768), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 151m, 57m, 181.20m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5771), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 78m, 173m, 93.60m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5775), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 5m, 158m, 6.00m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5778), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 41m, 1m, 49.20m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5781), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 144m, 125m, 172.80m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(5785), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 135m, 11m, 162.00m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 59, "333333333333" },
                    { 2, true, 1, "111111111111" },
                    { 3, true, 119, "444444444444" },
                    { 4, true, 61, "111111111111" },
                    { 5, true, 125, "999999999999" },
                    { 6, true, 1, "888888888888" },
                    { 7, true, 100, "444444444444" },
                    { 8, true, 62, "888888888888" },
                    { 9, true, 28, "666666666666" },
                    { 10, true, 119, "111111111111" },
                    { 11, true, 144, "111111111111" },
                    { 12, true, 104, "333333333333" },
                    { 13, true, 20, "222222222222" },
                    { 14, true, 82, "888888888888" },
                    { 15, true, 19, "888888888888" },
                    { 16, true, 144, "999999999999" },
                    { 17, true, 92, "999999999999" },
                    { 18, true, 95, "666666666666" },
                    { 19, true, 29, "777777777777" },
                    { 20, true, 35, "111111111111" },
                    { 21, true, 47, "111111111111" },
                    { 22, true, 33, "111111111111" },
                    { 23, true, 135, "666666666666" },
                    { 24, true, 133, "888888888888" },
                    { 25, true, 94, "222222222222" },
                    { 26, true, 38, "333333333333" },
                    { 27, true, 18, "666666666666" },
                    { 28, true, 1, "111111111111" },
                    { 29, true, 114, "222222222222" },
                    { 30, true, 2, "666666666666" },
                    { 31, true, 66, "555555555555" },
                    { 32, true, 132, "444444444444" },
                    { 33, true, 149, "111111111111" },
                    { 34, true, 90, "888888888888" },
                    { 35, true, 29, "333333333333" },
                    { 36, true, 134, "111111111111" },
                    { 37, true, 62, "444444444444" },
                    { 38, true, 131, "555555555555" },
                    { 39, true, 133, "777777777777" },
                    { 40, true, 44, "999999999999" },
                    { 41, true, 104, "777777777777" },
                    { 42, true, 11, "888888888888" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 137, "222222222222" },
                    { 44, true, 91, "999999999999" },
                    { 45, true, 46, "333333333333" },
                    { 46, true, 81, "111111111111" },
                    { 47, true, 47, "333333333333" },
                    { 48, true, 23, "999999999999" },
                    { 49, true, 123, "555555555555" },
                    { 50, true, 110, "888888888888" },
                    { 51, true, 150, "555555555555" },
                    { 52, true, 102, "111111111111" },
                    { 53, true, 149, "111111111111" },
                    { 54, true, 145, "777777777777" },
                    { 55, true, 101, "333333333333" },
                    { 56, true, 128, "111111111111" },
                    { 57, true, 70, "888888888888" },
                    { 58, true, 75, "444444444444" },
                    { 59, true, 130, "555555555555" },
                    { 60, true, 30, "666666666666" },
                    { 61, true, 105, "777777777777" },
                    { 62, true, 140, "222222222222" },
                    { 63, true, 60, "555555555555" },
                    { 64, true, 38, "111111111111" },
                    { 65, true, 136, "222222222222" },
                    { 66, true, 81, "333333333333" },
                    { 67, true, 37, "111111111111" },
                    { 68, true, 35, "888888888888" },
                    { 69, true, 127, "333333333333" },
                    { 70, true, 143, "666666666666" },
                    { 71, true, 57, "555555555555" },
                    { 72, true, 130, "999999999999" },
                    { 73, true, 65, "111111111111" },
                    { 74, true, 90, "555555555555" },
                    { 75, true, 90, "999999999999" },
                    { 76, true, 82, "888888888888" },
                    { 77, true, 91, "666666666666" },
                    { 78, true, 19, "111111111111" },
                    { 79, true, 116, "666666666666" },
                    { 80, true, 3, "333333333333" },
                    { 81, true, 15, "111111111111" },
                    { 82, true, 118, "333333333333" },
                    { 83, true, 36, "444444444444" },
                    { 84, true, 45, "111111111111" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 16, "555555555555" },
                    { 86, true, 83, "777777777777" },
                    { 87, true, 104, "555555555555" },
                    { 88, true, 100, "999999999999" },
                    { 89, true, 89, "777777777777" },
                    { 90, true, 110, "555555555555" },
                    { 91, true, 44, "111111111111" },
                    { 92, true, 5, "222222222222" },
                    { 93, true, 17, "333333333333" },
                    { 94, true, 142, "222222222222" },
                    { 95, true, 83, "888888888888" },
                    { 96, true, 44, "555555555555" },
                    { 97, true, 138, "444444444444" },
                    { 98, true, 57, "666666666666" },
                    { 99, true, 96, "333333333333" },
                    { 100, true, 64, "999999999999" },
                    { 101, true, 18, "444444444444" },
                    { 102, true, 100, "999999999999" },
                    { 103, true, 127, "111111111111" },
                    { 104, true, 30, "777777777777" },
                    { 105, true, 55, "999999999999" },
                    { 106, true, 28, "777777777777" },
                    { 107, true, 99, "111111111111" },
                    { 108, true, 12, "333333333333" },
                    { 109, true, 56, "999999999999" },
                    { 110, true, 50, "777777777777" },
                    { 111, true, 3, "555555555555" },
                    { 112, true, 120, "888888888888" },
                    { 113, true, 105, "111111111111" },
                    { 114, true, 127, "333333333333" },
                    { 115, true, 110, "777777777777" },
                    { 116, true, 93, "555555555555" },
                    { 117, true, 8, "888888888888" },
                    { 118, true, 51, "444444444444" },
                    { 119, true, 66, "222222222222" },
                    { 120, true, 13, "999999999999" },
                    { 121, true, 10, "444444444444" },
                    { 122, true, 94, "111111111111" },
                    { 123, true, 72, "777777777777" },
                    { 124, true, 125, "222222222222" },
                    { 125, true, 30, "333333333333" },
                    { 126, true, 132, "777777777777" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 118, "333333333333" },
                    { 128, true, 18, "111111111111" },
                    { 129, true, 84, "555555555555" },
                    { 130, true, 16, "666666666666" },
                    { 131, true, 94, "555555555555" },
                    { 132, true, 112, "111111111111" },
                    { 133, true, 20, "444444444444" },
                    { 134, true, 54, "222222222222" },
                    { 135, true, 80, "222222222222" },
                    { 136, true, 142, "777777777777" },
                    { 137, true, 4, "333333333333" },
                    { 138, true, 35, "333333333333" },
                    { 139, true, 47, "555555555555" },
                    { 140, true, 141, "333333333333" },
                    { 141, true, 121, "888888888888" },
                    { 142, true, 46, "888888888888" },
                    { 143, true, 47, "999999999999" },
                    { 144, true, 111, "777777777777" },
                    { 145, true, 30, "777777777777" },
                    { 146, true, 112, "888888888888" },
                    { 147, true, 1, "666666666666" },
                    { 148, true, 135, "333333333333" },
                    { 149, true, 13, "444444444444" },
                    { 150, true, 42, "222222222222" }
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
                    { 1, 1, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4744), 1, 70.00m, 58.33m, 100.00m, 83.33m },
                    { 2, 2, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4784), 1, 50.00m, 41.67m, 75.00m, 62.50m },
                    { 3, 3, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4787), 2, 40.00m, 33.33m, 60.00m, 50.00m },
                    { 4, 4, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4789), 2, 100.00m, 83.33m, 150.00m, 125.00m },
                    { 5, 5, new DateTime(2024, 3, 16, 10, 13, 6, 20, DateTimeKind.Local).AddTicks(4791), 1, 150.00m, 125.00m, 200.00m, 166.67m }
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
