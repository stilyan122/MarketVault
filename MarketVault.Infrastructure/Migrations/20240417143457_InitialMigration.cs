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
                    { 1, 1, "Chocolate Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8254), "Description about product - Chocolate Chip Cookie Dough Ice Cream", true, 1, "Chocolate Chip Cookie Dough Ice Cream", 1, 299m, 8m, 358.80m },
                    { 2, 2, "Vanilla Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8273), "Description about product - Vanilla Bean Ice Cream", true, 1, "Vanilla Bean Ice Cream", 2, 24m, 177m, 28.80m },
                    { 3, 3, "Strawberry Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8279), "Description about product - Strawberry Swirl Ice Cream", true, 1, "Strawberry Swirl Ice Cream", 3, 47m, 143m, 56.40m },
                    { 4, 4, "Mint Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8283), "Description about product - Mint Chocolate Chip Ice Cream", true, 1, "Mint Chocolate Chip Ice Cream", 4, 79m, 116m, 94.80m },
                    { 5, 5, "Cookies Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8287), "Description about product - Cookies and Cream Ice Cream", true, 1, "Cookies and Cream Ice Cream", 5, 4m, 178m, 4.80m },
                    { 6, 6, "Rocky Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8291), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8292), "Description about product - Rocky Road Ice Cream", true, 1, "Rocky Road Ice Cream", 6, 4m, 49m, 4.80m },
                    { 7, 7, "Neapolitan Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8295), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8296), "Description about product - Neapolitan Ice Cream", true, 1, "Neapolitan Ice Cream", 7, 74m, 80m, 88.80m },
                    { 8, 8, "Butter Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8300), "Description about product - Butter Pecan Ice Cream", true, 1, "Butter Pecan Ice Cream", 8, 273m, 181m, 327.60m },
                    { 9, 9, "Pistachio Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8302), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8303), "Description about product - Pistachio Ice Cream", true, 1, "Pistachio Ice Cream", 9, 194m, 41m, 232.80m },
                    { 10, 10, "Salted Ice Cream", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8308), "Description about product - Salted Caramel Ice Cream", true, 1, "Salted Caramel Ice Cream", 10, 84m, 2m, 100.80m },
                    { 11, 11, "Coca-Cola Classic", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8350), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8351), "Description about product - Coca-Cola Classic", true, 2, "Coca-Cola Classic", 11, 250m, 186m, 300.00m },
                    { 12, 12, "Pepsi Cola", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8355), "Description about product - Pepsi Cola", true, 2, "Pepsi Cola", 12, 196m, 16m, 235.20m },
                    { 13, 13, "Sprite Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8359), "Description about product - Sprite Lemon-Lime Soda", true, 2, "Sprite Lemon-Lime Soda", 13, 230m, 80m, 276.00m },
                    { 14, 14, "Fanta Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8363), "Description about product - Fanta Orange Soda", true, 2, "Fanta Orange Soda", 14, 286m, 101m, 343.20m },
                    { 15, 15, "Mountain Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8366), "Description about product - Mountain Dew Citrus Soda", true, 2, "Mountain Dew Citrus Soda", 15, 35m, 135m, 42.00m },
                    { 16, 16, "Dr. Pepper Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8370), "Description about product - Dr. Pepper Soda", true, 2, "Dr. Pepper Soda", 16, 299m, 119m, 358.80m },
                    { 17, 17, "Canada Ale", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8374), "Description about product - Canada Dry Ginger Ale", true, 2, "Canada Dry Ginger Ale", 17, 121m, 178m, 145.20m },
                    { 18, 18, "7UP Lemon-Lime Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8378), "Description about product - 7UP Lemon-Lime Soda", true, 2, "7UP Lemon-Lime Soda", 18, 170m, 38m, 204.00m },
                    { 19, 19, "Root Beer Soda", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8382), "Description about product - Root Beer Soda", true, 2, "Root Beer Soda", 19, 94m, 107m, 112.80m },
                    { 20, 20, "Red Bull Drink", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8386), "Description about product - Red Bull Energy Drink", true, 2, "Red Bull Energy Drink", 20, 281m, 21m, 337.20m },
                    { 21, 21, "Budweiser Beer", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8390), "Description about product - Budweiser Lager Beer", true, 3, "Budweiser Lager Beer", 21, 245m, 64m, 294.00m },
                    { 22, 22, "Jack Whiskey", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8394), "Description about product - Jack Daniel's Tennessee Whiskey", true, 3, "Jack Daniel's Tennessee Whiskey", 22, 141m, 23m, 169.20m },
                    { 23, 23, "Grey Goose Vodka", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8398), "Description about product - Grey Goose Vodka", true, 3, "Grey Goose Vodka", 23, 33m, 161m, 39.60m },
                    { 24, 24, "Captain Rum", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8402), "Description about product - Captain Morgan Spiced Rum", true, 3, "Captain Morgan Spiced Rum", 24, 232m, 10m, 278.40m },
                    { 25, 25, "Jose Tequila", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8406), "Description about product - Jose Cuervo Tequila", true, 3, "Jose Cuervo Tequila", 25, 74m, 166m, 88.80m },
                    { 26, 26, "Chardonnay Wine", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8410), "Description about product - Chardonnay White Wine", true, 3, "Chardonnay White Wine", 26, 143m, 150m, 171.60m },
                    { 27, 27, "Pinot Wine", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8412), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8414), "Description about product - Pinot Noir Red Wine", true, 3, "Pinot Noir Red Wine", 27, 188m, 7m, 225.60m },
                    { 28, 28, "Moet & Chandon Champagne", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8417), "Description about product - Moet & Chandon Champagne", true, 3, "Moet & Chandon Champagne", 28, 243m, 62m, 291.60m },
                    { 29, 29, "Jameson Whiskey", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8421), "Description about product - Jameson Irish Whiskey", true, 3, "Jameson Irish Whiskey", 29, 290m, 154m, 348.00m },
                    { 30, 30, "Absolut Vodka", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8425), "Description about product - Absolut Citron Vodka", true, 3, "Absolut Citron Vodka", 30, 24m, 93m, 28.80m },
                    { 31, 31, "Whole Milk", 1, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8429), "Description about product - Whole Milk", true, 4, "Whole Milk", 31, 235m, 76m, 282.00m },
                    { 32, 32, "2% Reduced Fat Milk", 2, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8472), "Description about product - 2% Reduced Fat Milk", true, 4, "2% Reduced Fat Milk", 32, 150m, 19m, 180.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 33, 33, "Skim Milk", 3, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8476), "Description about product - Skim Milk", true, 4, "Skim Milk", 33, 142m, 11m, 170.40m },
                    { 34, 34, "Chocolate Milk", 4, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8480), "Description about product - Chocolate Milk", true, 4, "Chocolate Milk", 34, 290m, 116m, 348.00m },
                    { 35, 35, "Half and Half Cream", 5, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8483), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8484), "Description about product - Half and Half Cream", true, 4, "Half and Half Cream", 35, 82m, 109m, 98.40m },
                    { 36, 36, "Heavy Cream", 6, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8486), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8487), "Description about product - Heavy Cream", true, 4, "Heavy Cream", 36, 118m, 67m, 141.60m },
                    { 37, 37, "Unsalted Butter", 7, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8491), "Description about product - Unsalted Butter", true, 4, "Unsalted Butter", 37, 141m, 182m, 169.20m },
                    { 38, 38, "Salted Butter", 8, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8495), "Description about product - Salted Butter", true, 4, "Salted Butter", 38, 92m, 138m, 110.40m },
                    { 39, 39, "Plain Yogurt", 9, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8499), "Description about product - Plain Yogurt", true, 4, "Plain Yogurt", 39, 97m, 134m, 116.40m },
                    { 40, 40, "Greek Yogurt", 10, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8502), "Description about product - Greek Yogurt", true, 4, "Greek Yogurt", 40, 53m, 138m, 63.60m },
                    { 41, 41, "Beef Dogs", 11, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8506), "Description about product - Beef Hot Dogs", true, 5, "Beef Hot Dogs", 41, 247m, 124m, 296.40m },
                    { 42, 42, "Pork Sausages", 12, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8508), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8509), "Description about product - Pork Breakfast Sausages", true, 5, "Pork Breakfast Sausages", 42, 103m, 22m, 123.60m },
                    { 43, 43, "Chicken Sausages", 13, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8513), "Description about product - Chicken Apple Sausages", true, 5, "Chicken Apple Sausages", 43, 73m, 183m, 87.60m },
                    { 44, 44, "Italian Sausages", 14, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8517), "Description about product - Italian Style Sausages", true, 5, "Italian Style Sausages", 44, 266m, 141m, 319.20m },
                    { 45, 45, "Bratwurst Sausages", 15, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8520), "Description about product - Bratwurst Sausages", true, 5, "Bratwurst Sausages", 45, 35m, 175m, 42.00m },
                    { 46, 46, "Chorizo Sausages", 16, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8524), "Description about product - Chorizo Sausages", true, 5, "Chorizo Sausages", 46, 61m, 190m, 73.20m },
                    { 47, 47, "Andouille Sausages", 17, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8527), "Description about product - Andouille Sausages", true, 5, "Andouille Sausages", 47, 108m, 73m, 129.60m },
                    { 48, 48, "Kielbasa Sausages", 18, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8531), "Description about product - Kielbasa Sausages", true, 5, "Kielbasa Sausages", 48, 260m, 145m, 312.00m },
                    { 49, 49, "Vegan Sausages", 19, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8535), "Description about product - Vegan Plant-Based Sausages", true, 5, "Vegan Plant-Based Sausages", 49, 192m, 119m, 230.40m },
                    { 50, 50, "Maple Sausage", 20, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8539), "Description about product - Maple Glazed Sausage Links", true, 5, "Maple Glazed Sausage Links", 50, 16m, 124m, 19.20m },
                    { 51, 51, "Ultra Detergent", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8542), "Description about product - Ultra Fresh Scented Laundry Detergent", true, 6, "Ultra Fresh Scented Laundry Detergent", 51, 144m, 104m, 172.80m },
                    { 52, 52, "Fabric Sheets", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8587), "Description about product - Fabric Softener Sheets", true, 6, "Fabric Softener Sheets", 52, 143m, 98m, 171.60m },
                    { 53, 53, "Stain Spray", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8591), "Description about product - Stain Remover Spray", true, 6, "Stain Remover Spray", 53, 61m, 108m, 73.20m },
                    { 54, 54, "Color-Safe Bleach", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8595), "Description about product - Color-Safe Bleach", true, 6, "Color-Safe Bleach", 54, 193m, 11m, 231.60m },
                    { 55, 55, "Liquid Softener", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8598), "Description about product - Liquid Fabric Softener", true, 6, "Liquid Fabric Softener", 55, 17m, 4m, 20.40m },
                    { 56, 56, "Fragrance-Free Pods", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8602), "Description about product - Fragrance-Free Laundry Pods", true, 6, "Fragrance-Free Laundry Pods", 56, 154m, 181m, 184.80m },
                    { 57, 57, "Wool Balls", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8606), "Description about product - Wool Dryer Balls", true, 6, "Wool Dryer Balls", 57, 72m, 139m, 86.40m },
                    { 58, 58, "Oxygen Remover", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8609), "Description about product - Oxygen Stain Remover", true, 6, "Oxygen Stain Remover", 58, 272m, 175m, 326.40m },
                    { 59, 59, "Laundry Spray", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8613), "Description about product - Laundry Pre-Treatment Spray", true, 6, "Laundry Pre-Treatment Spray", 59, 234m, 60m, 280.80m },
                    { 60, 60, "Delicate Detergent", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8617), "Description about product - Delicate Wash Laundry Detergent", true, 6, "Delicate Wash Laundry Detergent", 60, 101m, 113m, 121.20m },
                    { 61, 61, "Roasted  Nuts", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8620), "Description about product - Roasted Salted Mixed Nuts", true, 7, "Roasted Salted Mixed Nuts", 61, 66m, 67m, 79.20m },
                    { 62, 62, "Honey Cashews", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8624), "Description about product - Honey Glazed Cashews", true, 7, "Honey Glazed Cashews", 62, 129m, 16m, 154.80m },
                    { 63, 63, "Spicy Almonds", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8627), "Description about product - Spicy Cajun Almonds", true, 7, "Spicy Cajun Almonds", 63, 58m, 133m, 69.60m },
                    { 64, 64, "BBQ Peanuts", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8631), "Description about product - BBQ Flavored Peanuts", true, 7, "BBQ Flavored Peanuts", 64, 199m, 2m, 238.80m },
                    { 65, 65, "Chocolate Hazelnuts", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8635), "Description about product - Chocolate Covered Hazelnuts", true, 7, "Chocolate Covered Hazelnuts", 65, 33m, 60m, 39.60m },
                    { 66, 66, "Sea Pistachios", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8640), "Description about product - Sea Salt Pistachios", true, 7, "Sea Salt Pistachios", 66, 104m, 62m, 124.80m },
                    { 67, 67, "Smoked Almond Snack Mix", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8643), "Description about product - Smoked Almond Snack Mix", true, 7, "Smoked Almond Snack Mix", 67, 56m, 63m, 67.20m },
                    { 68, 68, "Chili Lime Cashews", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8647), "Description about product - Chili Lime Cashews", true, 7, "Chili Lime Cashews", 68, 110m, 61m, 132.00m },
                    { 69, 69, "Wasabi Almonds", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8651), "Description about product - Wasabi Soy Almonds", true, 7, "Wasabi Soy Almonds", 69, 69m, 68m, 82.80m },
                    { 70, 70, "Maple Pecan Trail Mix", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8654), "Description about product - Maple Pecan Trail Mix", true, 7, "Maple Pecan Trail Mix", 70, 169m, 143m, 202.80m },
                    { 71, 71, "Premium Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8700), "Description about product - Premium Menthol Cigarettes", true, 8, "Premium Menthol Cigarettes", 71, 226m, 96m, 271.20m },
                    { 72, 72, "Classic Blend Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8704), "Description about product - Classic Tobacco Blend Cigarettes", true, 8, "Classic Tobacco Blend Cigarettes", 72, 184m, 102m, 220.80m },
                    { 73, 73, "Slims Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8708), "Description about product - Slims Light Cigarettes", true, 8, "Slims Light Cigarettes", 73, 20m, 113m, 24.00m },
                    { 74, 74, "Menthol Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8711), "Description about product - Menthol Gold Cigarettes", true, 8, "Menthol Gold Cigarettes", 74, 112m, 182m, 134.40m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 75, 75, "Full Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8713), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8714), "Description about product - Full Flavor Cigarettes", true, 8, "Full Flavor Cigarettes", 75, 165m, 49m, 198.00m },
                    { 76, 76, "Menthol Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8718), "Description about product - Menthol Silver Cigarettes", true, 8, "Menthol Silver Cigarettes", 76, 211m, 96m, 253.20m },
                    { 77, 77, "Ultra Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8722), "Description about product - Ultra Light Cigarettes", true, 8, "Ultra Light Cigarettes", 77, 63m, 163m, 75.60m },
                    { 78, 78, "Regular Filtered Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8726), "Description about product - Regular Filtered Cigarettes", true, 8, "Regular Filtered Cigarettes", 78, 41m, 119m, 49.20m },
                    { 79, 79, "Menthol Blue Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8729), "Description about product - Menthol Blue Cigarettes", true, 8, "Menthol Blue Cigarettes", 79, 286m, 104m, 343.20m },
                    { 80, 80, "Menthol Green Cigarettes", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8733), "Description about product - Menthol Green Cigarettes", true, 8, "Menthol Green Cigarettes", 80, 223m, 196m, 267.60m },
                    { 81, 81, "Whole Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8736), "Description about product - Whole Wheat Sandwich Bread", true, 9, "Whole Wheat Sandwich Bread", 81, 155m, 10m, 186.00m },
                    { 82, 82, "French Baguette", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8740), "Description about product - French Baguette", true, 9, "French Baguette", 82, 6m, 92m, 7.20m },
                    { 83, 83, "Artisanal Loaf", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8744), "Description about product - Artisanal Sourdough Loaf", true, 9, "Artisanal Sourdough Loaf", 83, 28m, 0m, 33.60m },
                    { 84, 84, "Multigrain Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8747), "Description about product - Multigrain Bread", true, 9, "Multigrain Bread", 84, 121m, 54m, 145.20m },
                    { 85, 85, "Rye Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8751), "Description about product - Rye Bread", true, 9, "Rye Bread", 85, 132m, 107m, 158.40m },
                    { 86, 86, "Gluten-Free Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8755), "Description about product - Gluten-Free White Bread", true, 9, "Gluten-Free White Bread", 86, 40m, 173m, 48.00m },
                    { 87, 87, "Cinnamon Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8758), "Description about product - Cinnamon Raisin Bread", true, 9, "Cinnamon Raisin Bread", 87, 34m, 101m, 40.80m },
                    { 88, 88, "Italian Loaf", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8762), "Description about product - Italian Ciabatta Loaf", true, 9, "Italian Ciabatta Loaf", 88, 56m, 121m, 67.20m },
                    { 89, 89, "Pumpernickel Bread", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8765), "Description about product - Pumpernickel Bread", true, 9, "Pumpernickel Bread", 89, 4m, 132m, 4.80m },
                    { 90, 90, "Bagels Pack", 0, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8769), "Description about product - Bagels Assortment Pack", true, 9, "Bagels Assortment Pack", 90, 146m, 173m, 175.20m },
                    { 91, 91, "Organic Gala Apples", 21, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8773), "Description about product - Organic Gala Apples", true, 10, "Organic Gala Apples", 91, 183m, 192m, 219.60m },
                    { 92, 92, "Fresh Strawberries", 22, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8812), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8813), "Description about product - Fresh Strawberries", true, 10, "Fresh Strawberries", 92, 86m, 141m, 103.20m },
                    { 93, 93, "Green Grapes", 23, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8817), "Description about product - Green Seedless Grapes", true, 10, "Green Seedless Grapes", 93, 212m, 21m, 254.40m },
                    { 94, 94, "Ripe Avocados", 24, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8821), "Description about product - Ripe Avocados", true, 10, "Ripe Avocados", 94, 115m, 140m, 138.00m },
                    { 95, 95, "Sweet Juicy Oranges", 25, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8825), "Description about product - Sweet Juicy Oranges", true, 10, "Sweet Juicy Oranges", 95, 12m, 117m, 14.40m },
                    { 96, 96, "Crisp Apples", 26, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8828), "Description about product - Crisp Red Delicious Apples", true, 10, "Crisp Red Delicious Apples", 96, 206m, 120m, 247.20m },
                    { 97, 97, "Fresh Raspberries", 27, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8832), "Description about product - Fresh Raspberries", true, 10, "Fresh Raspberries", 97, 230m, 192m, 276.00m },
                    { 98, 98, "Crisp Apples", 28, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8836), "Description about product - Crisp Green Granny Smith Apples", true, 10, "Crisp Green Granny Smith Apples", 98, 222m, 95m, 266.40m },
                    { 99, 99, "Juicy Clementines", 29, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8840), "Description about product - Juicy Clementines", true, 10, "Juicy Clementines", 99, 269m, 17m, 322.80m },
                    { 100, 100, "Organic Bananas", 30, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8844), "Description about product - Organic Bananas", true, 10, "Organic Bananas", 100, 165m, 146m, 198.00m },
                    { 101, 101, "Plump Blueberries", 31, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8848), "Description about product - Plump Blueberries", true, 10, "Plump Blueberries", 101, 219m, 40m, 262.80m },
                    { 102, 102, "Ripe Red Tomatoes", 32, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8851), "Description about product - Ripe Red Tomatoes", true, 10, "Ripe Red Tomatoes", 102, 286m, 140m, 343.20m },
                    { 103, 103, "Vibrant Red Bell Peppers", 33, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8855), "Description about product - Vibrant Red Bell Peppers", true, 10, "Vibrant Red Bell Peppers", 103, 96m, 2m, 115.20m },
                    { 104, 104, "Crisp Green Cucumbers", 34, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8857), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8858), "Description about product - Crisp Green Cucumbers", true, 10, "Crisp Green Cucumbers", 104, 148m, 193m, 177.60m },
                    { 105, 105, "Fresh Broccoli Crowns", 35, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8862), "Description about product - Fresh Broccoli Crowns", true, 10, "Fresh Broccoli Crowns", 105, 277m, 181m, 332.40m },
                    { 106, 106, "Sweet Juicy Peaches", 36, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8866), "Description about product - Sweet Juicy Peaches", true, 10, "Sweet Juicy Peaches", 106, 137m, 94m, 164.40m },
                    { 107, 107, "Crisp Iceberg Lettuce", 37, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8868), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8869), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 107, 31m, 10m, 37.20m },
                    { 108, 108, "Ripe Yellow Bananas", 38, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8872), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8873), "Description about product - Ripe Yellow Bananas", true, 10, "Ripe Yellow Bananas", 108, 178m, 200m, 213.60m },
                    { 109, 109, "Fresh Spinach Leaves", 39, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8876), "Description about product - Fresh Spinach Leaves", true, 10, "Fresh Spinach Leaves", 109, 275m, 113m, 330.00m },
                    { 110, 110, "Crisp Carrots", 40, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8880), "Description about product - Crisp Carrots", true, 10, "Crisp Carrots", 110, 176m, 42m, 211.20m },
                    { 111, 111, "Fresh Lemons", 41, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8884), "Description about product - Fresh Lemons", true, 10, "Fresh Lemons", 111, 194m, 88m, 232.80m },
                    { 112, 112, "Ripe Mangos", 42, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8887), "Description about product - Ripe Mangos", true, 10, "Ripe Mangos", 112, 93m, 148m, 111.60m },
                    { 113, 113, "Sweet Red Cherries", 43, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8891), "Description about product - Sweet Red Cherries", true, 10, "Sweet Red Cherries", 113, 281m, 106m, 337.20m },
                    { 114, 114, "Crisp Celery Sticks", 44, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8931), "Description about product - Crisp Celery Sticks", true, 10, "Crisp Celery Sticks", 114, 298m, 60m, 357.60m },
                    { 115, 115, "Juicy Watermelon", 45, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8934), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8935), "Description about product - Juicy Watermelon", true, 10, "Juicy Watermelon", 115, 92m, 26m, 110.40m },
                    { 116, 116, "Green Zucchini Squash", 46, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8939), "Description about product - Green Zucchini Squash", true, 10, "Green Zucchini Squash", 116, 74m, 98m, 88.80m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArticleNumber", "CashRegisterName", "CodeForScales", "DateAdded", "DateModified", "Description", "IsActive", "ItemGroupId", "Name", "NomenclatureNumber", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 117, 117, "Sweet Pineapple Chunks", 47, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8942), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8943), "Description about product - Sweet Pineapple Chunks", true, 10, "Sweet Pineapple Chunks", 117, 251m, 14m, 301.20m },
                    { 118, 118, "Fresh Kiwi Fruit", 48, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8946), "Description about product - Fresh Kiwi Fruit", true, 10, "Fresh Kiwi Fruit", 118, 40m, 127m, 48.00m },
                    { 119, 119, "Crisp Radishes", 49, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8949), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8950), "Description about product - Crisp Radishes", true, 10, "Crisp Radishes", 119, 126m, 55m, 151.20m },
                    { 120, 120, "Ripe Honeydew Melon", 50, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8953), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8954), "Description about product - Ripe Honeydew Melon", true, 10, "Ripe Honeydew Melon", 120, 31m, 56m, 37.20m },
                    { 121, 121, "Fresh Green Beans", 51, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8956), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8957), "Description about product - Fresh Green Beans", true, 10, "Fresh Green Beans", 121, 195m, 45m, 234.00m },
                    { 122, 122, "Crisp Iceberg Lettuce", 52, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8960), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8961), "Description about product - Crisp Iceberg Lettuce", true, 10, "Crisp Iceberg Lettuce", 122, 299m, 118m, 358.80m },
                    { 123, 123, "Ripe Nectarines", 53, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8965), "Description about product - Ripe Nectarines", true, 10, "Ripe Nectarines", 123, 114m, 183m, 136.80m },
                    { 124, 124, "Sweet Grapes", 54, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8968), "Description about product - Sweet Red Grapes", true, 10, "Sweet Red Grapes", 124, 244m, 33m, 292.80m },
                    { 125, 125, "Crisp Squash", 55, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8972), "Description about product - Crisp Yellow Squash", true, 10, "Crisp Yellow Squash", 125, 88m, 157m, 105.60m },
                    { 126, 126, "Fresh Asparagus Spears", 56, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8976), "Description about product - Fresh Asparagus Spears", true, 10, "Fresh Asparagus Spears", 126, 59m, 47m, 70.80m },
                    { 127, 127, "Juicy Blackberries", 57, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8979), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8980), "Description about product - Juicy Blackberries", true, 10, "Juicy Blackberries", 127, 55m, 88m, 66.00m },
                    { 128, 128, "Ripe Apricots", 58, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8983), "Description about product - Ripe Apricots", true, 10, "Ripe Apricots", 128, 23m, 115m, 27.60m },
                    { 129, 129, "Sweet Strawberries", 59, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8987), "Description about product - Sweet Strawberries", true, 10, "Sweet Strawberries", 129, 130m, 35m, 156.00m },
                    { 130, 130, "Crisp Cauliflower Florets", 60, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(8992), "Description about product - Crisp Cauliflower Florets", true, 10, "Crisp Cauliflower Florets", 130, 147m, 110m, 176.40m },
                    { 131, 131, "Ripe Papaya", 61, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9078), "Description about product - Ripe Papaya", true, 10, "Ripe Papaya", 131, 169m, 30m, 202.80m },
                    { 132, 132, "Fresh Artichokes", 62, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9082), "Description about product - Fresh Artichokes", true, 10, "Fresh Artichokes", 132, 53m, 186m, 63.60m },
                    { 133, 133, "Sweet Cantaloupe", 63, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9084), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9086), "Description about product - Sweet Cantaloupe", true, 10, "Sweet Cantaloupe", 133, 174m, 35m, 208.80m },
                    { 134, 134, "Ripe Pears", 64, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9089), "Description about product - Ripe Pears", true, 10, "Ripe Pears", 134, 33m, 21m, 39.60m },
                    { 135, 135, "Crisp Green Peas", 65, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9093), "Description about product - Crisp Green Peas", true, 10, "Crisp Green Peas", 135, 230m, 11m, 276.00m },
                    { 136, 136, "Juicy Grapefruit", 66, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9096), "Description about product - Juicy Grapefruit", true, 10, "Juicy Grapefruit", 136, 122m, 92m, 146.40m },
                    { 137, 137, "Ripe Plums", 67, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9100), "Description about product - Ripe Plums", true, 10, "Ripe Plums", 137, 145m, 59m, 174.00m },
                    { 138, 138, "Crisp Red Radishes", 68, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9104), "Description about product - Crisp Red Radishes", true, 10, "Crisp Red Radishes", 138, 270m, 129m, 324.00m },
                    { 139, 139, "Fresh Beets", 69, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9106), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9107), "Description about product - Fresh Beets", true, 10, "Fresh Beets", 139, 48m, 103m, 57.60m },
                    { 140, 140, "Sweet Red Peppers", 70, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9111), "Description about product - Sweet Red Peppers", true, 10, "Sweet Red Peppers", 140, 67m, 150m, 80.40m },
                    { 141, 141, "Ripe Tangerines", 71, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9114), "Description about product - Ripe Tangerines", true, 10, "Ripe Tangerines", 141, 200m, 116m, 240.00m },
                    { 142, 142, "Crisp Corn on the Cob", 72, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9118), "Description about product - Crisp Corn on the Cob", true, 10, "Crisp Corn on the Cob", 142, 82m, 131m, 98.40m },
                    { 143, 143, "Fresh Brussels Sprouts", 73, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9122), "Description about product - Fresh Brussels Sprouts", true, 10, "Fresh Brussels Sprouts", 143, 110m, 81m, 132.00m },
                    { 144, 144, "Ripe Lychees", 74, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9125), "Description about product - Ripe Lychees", true, 10, "Ripe Lychees", 144, 288m, 136m, 345.60m },
                    { 145, 145, "Crisp Bok Choy", 75, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9129), "Description about product - Crisp Bok Choy", true, 10, "Crisp Bok Choy", 145, 17m, 122m, 20.40m },
                    { 146, 146, "Juicy Pomegranates", 76, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9133), "Description about product - Juicy Pomegranates", true, 10, "Juicy Pomegranates", 146, 287m, 131m, 344.40m },
                    { 147, 147, "Ripe Persimmons", 77, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9136), "Description about product - Ripe Persimmons", true, 10, "Ripe Persimmons", 147, 54m, 145m, 64.80m },
                    { 148, 148, "Sweet Figs", 78, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9140), "Description about product - Sweet Figs", true, 10, "Sweet Figs", 148, 131m, 132m, 157.20m },
                    { 149, 149, "Crisp Jicama", 79, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9144), "Description about product - Crisp Jicama", true, 10, "Crisp Jicama", 149, 84m, 124m, 100.80m },
                    { 150, 150, "Fresh Baby Spinach", 80, new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 4, 17, 17, 34, 56, 981, DateTimeKind.Local).AddTicks(9148), "Description about product - Fresh Baby Spinach", true, 10, "Fresh Baby Spinach", 150, 75m, 82m, 90.00m }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, true, 116, "555555555555" },
                    { 2, true, 146, "666666666666" },
                    { 3, true, 115, "111111111111" },
                    { 4, true, 79, "999999999999" },
                    { 5, true, 135, "777777777777" },
                    { 6, true, 26, "777777777777" },
                    { 7, true, 68, "222222222222" },
                    { 8, true, 76, "444444444444" },
                    { 9, true, 59, "555555555555" },
                    { 10, true, 68, "222222222222" },
                    { 11, true, 89, "555555555555" },
                    { 12, true, 124, "555555555555" },
                    { 13, true, 100, "888888888888" },
                    { 14, true, 107, "555555555555" },
                    { 15, true, 5, "999999999999" },
                    { 16, true, 21, "444444444444" },
                    { 17, true, 97, "666666666666" },
                    { 18, true, 90, "666666666666" },
                    { 19, true, 32, "999999999999" },
                    { 20, true, 122, "222222222222" },
                    { 21, true, 59, "666666666666" },
                    { 22, true, 63, "999999999999" },
                    { 23, true, 139, "888888888888" },
                    { 24, true, 76, "222222222222" },
                    { 25, true, 51, "222222222222" },
                    { 26, true, 101, "666666666666" },
                    { 27, true, 141, "777777777777" },
                    { 28, true, 99, "888888888888" },
                    { 29, true, 138, "333333333333" },
                    { 30, true, 132, "222222222222" },
                    { 31, true, 131, "555555555555" },
                    { 32, true, 104, "666666666666" },
                    { 33, true, 77, "555555555555" },
                    { 34, true, 104, "444444444444" },
                    { 35, true, 22, "333333333333" },
                    { 36, true, 137, "666666666666" },
                    { 37, true, 144, "777777777777" },
                    { 38, true, 110, "888888888888" },
                    { 39, true, 60, "777777777777" },
                    { 40, true, 137, "666666666666" },
                    { 41, true, 131, "111111111111" },
                    { 42, true, 12, "999999999999" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, true, 39, "333333333333" },
                    { 44, true, 62, "777777777777" },
                    { 45, true, 117, "222222222222" },
                    { 46, true, 25, "222222222222" },
                    { 47, true, 19, "333333333333" },
                    { 48, true, 131, "999999999999" },
                    { 49, true, 107, "777777777777" },
                    { 50, true, 24, "555555555555" },
                    { 51, true, 143, "444444444444" },
                    { 52, true, 86, "555555555555" },
                    { 53, true, 112, "666666666666" },
                    { 54, true, 42, "111111111111" },
                    { 55, true, 93, "222222222222" },
                    { 56, true, 132, "999999999999" },
                    { 57, true, 145, "333333333333" },
                    { 58, true, 68, "888888888888" },
                    { 59, true, 95, "444444444444" },
                    { 60, true, 108, "666666666666" },
                    { 61, true, 35, "666666666666" },
                    { 62, true, 41, "111111111111" },
                    { 63, true, 134, "555555555555" },
                    { 64, true, 56, "555555555555" },
                    { 65, true, 51, "111111111111" },
                    { 66, true, 106, "333333333333" },
                    { 67, true, 38, "888888888888" },
                    { 68, true, 34, "999999999999" },
                    { 69, true, 116, "777777777777" },
                    { 70, true, 93, "444444444444" },
                    { 71, true, 37, "222222222222" },
                    { 72, true, 85, "999999999999" },
                    { 73, true, 106, "666666666666" },
                    { 74, true, 46, "111111111111" },
                    { 75, true, 89, "333333333333" },
                    { 76, true, 108, "555555555555" },
                    { 77, true, 67, "555555555555" },
                    { 78, true, 6, "888888888888" },
                    { 79, true, 1, "888888888888" },
                    { 80, true, 11, "888888888888" },
                    { 81, true, 67, "111111111111" },
                    { 82, true, 50, "777777777777" },
                    { 83, true, 53, "222222222222" },
                    { 84, true, 98, "888888888888" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 85, true, 91, "555555555555" },
                    { 86, true, 117, "999999999999" },
                    { 87, true, 112, "333333333333" },
                    { 88, true, 59, "444444444444" },
                    { 89, true, 76, "888888888888" },
                    { 90, true, 139, "999999999999" },
                    { 91, true, 108, "222222222222" },
                    { 92, true, 111, "777777777777" },
                    { 93, true, 45, "999999999999" },
                    { 94, true, 145, "333333333333" },
                    { 95, true, 136, "444444444444" },
                    { 96, true, 54, "222222222222" },
                    { 97, true, 70, "444444444444" },
                    { 98, true, 140, "333333333333" },
                    { 99, true, 43, "999999999999" },
                    { 100, true, 21, "777777777777" },
                    { 101, true, 117, "555555555555" },
                    { 102, true, 69, "999999999999" },
                    { 103, true, 69, "333333333333" },
                    { 104, true, 22, "222222222222" },
                    { 105, true, 82, "222222222222" },
                    { 106, true, 1, "222222222222" },
                    { 107, true, 27, "999999999999" },
                    { 108, true, 8, "666666666666" },
                    { 109, true, 140, "888888888888" },
                    { 110, true, 52, "666666666666" },
                    { 111, true, 35, "222222222222" },
                    { 112, true, 13, "888888888888" },
                    { 113, true, 119, "222222222222" },
                    { 114, true, 40, "333333333333" },
                    { 115, true, 42, "999999999999" },
                    { 116, true, 68, "333333333333" },
                    { 117, true, 146, "999999999999" },
                    { 118, true, 32, "111111111111" },
                    { 119, true, 61, "777777777777" },
                    { 120, true, 111, "111111111111" },
                    { 121, true, 14, "333333333333" },
                    { 122, true, 31, "333333333333" },
                    { 123, true, 103, "444444444444" },
                    { 124, true, 119, "777777777777" },
                    { 125, true, 114, "999999999999" },
                    { 126, true, 38, "888888888888" }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "Id", "IsActive", "ProductId", "Value" },
                values: new object[,]
                {
                    { 127, true, 119, "555555555555" },
                    { 128, true, 40, "888888888888" },
                    { 129, true, 8, "444444444444" },
                    { 130, true, 76, "444444444444" },
                    { 131, true, 99, "111111111111" },
                    { 132, true, 64, "777777777777" },
                    { 133, true, 111, "888888888888" },
                    { 134, true, 55, "111111111111" },
                    { 135, true, 131, "666666666666" },
                    { 136, true, 124, "555555555555" },
                    { 137, true, 99, "111111111111" },
                    { 138, true, 150, "222222222222" },
                    { 139, true, 123, "555555555555" },
                    { 140, true, 109, "111111111111" },
                    { 141, true, 53, "888888888888" },
                    { 142, true, 141, "111111111111" },
                    { 143, true, 29, "333333333333" },
                    { 144, true, 64, "444444444444" },
                    { 145, true, 108, "777777777777" },
                    { 146, true, 127, "666666666666" },
                    { 147, true, 90, "777777777777" },
                    { 148, true, 80, "777777777777" },
                    { 149, true, 41, "555555555555" },
                    { 150, true, 39, "999999999999" }
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
