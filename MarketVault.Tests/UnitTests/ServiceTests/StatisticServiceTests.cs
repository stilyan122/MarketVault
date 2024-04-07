namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Statistic Service test class
    /// </summary
    [TestFixture]
    public class StatisticServiceTests : UnitTestBase
    {
        /// <summary>
        /// Statistic Service
        /// </summary>
        private IStatisticService service = null!;

        /// <summary>
        /// Address Service
        /// </summary>
        private IAddressService addressService = null!;

        /// <summary>
        /// Bank Service
        /// </summary>
        private IBankService bankService = null!;

        /// <summary>
        /// Firm Service
        /// </summary>
        private IFirmService firmService = null!;

        /// <summary>
        /// Item Group Service
        /// </summary>
        private IItemGroupService itemGroupService = null!;

        /// <summary>
        /// Product Service
        /// </summary>
        private IProductService productService = null!;

        /// <summary>
        /// Counter party Service
        /// </summary>
        private ICounterPartyService counterPartyService = null!;

        /// <summary>
        /// User Service
        /// </summary>
        private IUserService userService = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            var addressServiceMock = new Mock<IAddressService>();

            addressServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(2));

            this.addressService = addressServiceMock.Object;

            var bankServiceMock = new Mock<IBankService>();

            bankServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(2));

            this.bankService = bankServiceMock.Object;

            var firmServiceMock = new Mock<IFirmService>();

            firmServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(2));

            this.firmService = firmServiceMock.Object;

            var itemGroupServiceMock = new Mock<IItemGroupService>();

            itemGroupServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(2));

            this.itemGroupService = itemGroupServiceMock.Object;

            var productServiceMock = new Mock<IProductService>();

            productServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(3));

            this.productService = productServiceMock.Object;

            var counterPartyServiceMock = new Mock<ICounterPartyService>();

            counterPartyServiceMock
                .Setup(a => a.GetCountAsync())
                .Returns(Task.FromResult(2));

            this.counterPartyService = counterPartyServiceMock.Object;

            var userServiceMock = new Mock<IUserService>();

            userServiceMock
                .Setup(a => a.GetUsersCountAsync())
                .Returns(Task.FromResult(2));

            this.userService = userServiceMock.Object;

            this.context = DatabaseMock.Mock;

            this.service = new StatisticService(addressService,
                bankService,
                firmService,
                itemGroupService,
                productService,
                userService,
                counterPartyService);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetStatisticServiceModelAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var serviceModel = await this.service.GetStatisticServiceModelAsync();

            Assert.Multiple(() =>
            {
                Assert.That(serviceModel.TotalUsers == 2);
                Assert.That(serviceModel.TotalBanks == 2);
                Assert.That(serviceModel.TotalProducts == 3);
                Assert.That(serviceModel.TotalAddresses == 2);
                Assert.That(serviceModel.TotalFirms == 2);
                Assert.That(serviceModel.TotalItemGroups == 2);
                Assert.That(serviceModel.TotalCounterParties == 2);
            });
        }

        /// <summary>
        /// Private method for seeding data
        /// </summary>
        /// <returns>(void)</returns>
        private async Task SeedData()
        {
            var barcode1 = new Barcode()
            {
                Id = 1,
                ProductId = 1,
                Value = "1"
            };
            var barcode2 = new Barcode()
            {
                Id = 2,
                ProductId = 2,
                Value = "2"
            };

            var product1 = new Product()
            {
                Id = 1,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description1",
                ArticleNumber = 1,
                CashRegisterName = "CashRegisterName1",
                CodeForScales = 1,
                ItemGroupId = 1,
                Name = "Name1",
                NomenclatureNumber = 1,
                PurchasePrice = 1,
                SalePrice = 1,
                Quantity = 1
            };
            var product2 = new Product()
            {
                Id = 2,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description2",
                ArticleNumber = 2,
                CashRegisterName = "CashRegisterName2",
                CodeForScales = 2,
                ItemGroupId = 2,
                Name = "Name2",
                NomenclatureNumber = 2,
                PurchasePrice = 2,
                SalePrice = 2,
                Quantity = 2
            };
            var product3 = new Product()
            {
                Id = 3,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description3",
                ArticleNumber = 3,
                CashRegisterName = "CashRegisterName3",
                CodeForScales = 3,
                ItemGroupId = 2,
                Name = "Name3",
                NomenclatureNumber = 3,
                PurchasePrice = 3,
                SalePrice = 3,
                Quantity = 3
            };

            var itemGroup1 = new ItemGroup()
            {
                Id = 1,
                Name = "ItemGroup1"
            };
            var itemGroup2 = new ItemGroup()
            {
                Id = 2,
                Name = "ItemGroup2"
            };

            var measure1 = new Measure()
            {
                CanBeDecimal = true,
                Id = 1,
                Name = "Measure1"
            };
            var measure2 = new Measure()
            {
                CanBeDecimal = true,
                Id = 2,
                Name = "Measure2"
            };

            var productMeasure1 = new ProductMeasure()
            {
                ProductId = 1,
                MeasureId = 1
            };
            var productMeasure2 = new ProductMeasure()
            {
                ProductId = 2,
                MeasureId = 2
            };

            var counterParty1 = new CounterParty()
            {
                Id = 1,
                Name = "CounterParty1",
                BankCode = "BankCode1",
                BankIBAN = "BankIBAN1",
                BankId = 1,
                FirmId = 1,
                ValueAddedTaxLawId = "VATLI1",
                VATNumber = "VATNumber1"
            };
            var counterParty2 = new CounterParty()
            {
                Id = 2,
                Name = "CounterParty2",
                BankCode = "BankCode2",
                BankIBAN = "BankIBAN2",
                BankId = 1,
                FirmId = 1,
                ValueAddedTaxLawId = "VATLI2",
                VATNumber = "VATNumber2"
            };

            var address1 = new Address()
            {
                Id = 1,
                StreetName = "TestStreet1",
                StreetNumber = "TestNumber1",
                TownName = "TestTown1"
            };
            var address2 = new Address()
            {
                Id = 2,
                StreetName = "TestStreet2",
                StreetNumber = "TestNumber2",
                TownName = "TestTown2"
            };

            var firm1 = new Firm()
            {
                Id = 1,
                Name = "Firm1",
                AddressId = 1
            };
            var firm2 = new Firm()
            {
                Id = 2,
                Name = "Firm2",
                AddressId = 2
            };

            var bank1 = new Bank()
            {
                Id = 1,
                Name = "Bank1",
                AddressId = 1
            };
            var bank2 = new Bank()
            {
                Id = 2,
                Name = "Bank2",
                AddressId = 2
            };

            var documentType1 = new DocumentType()
            {
                Id = 1,
                Name = "DocumentType1",
            };
            var documentType2 = new DocumentType()
            {
                Id = 2,
                Name = "DocumentType2",
            };

            var user1 = new ApplicationUser()
            {
                Id = "1",
                Email = "email1@gmail.com",
                EmailConfirmed = true,
                FirstName = "User1",
                LastName = "User1",
                PhoneNumber = "0899999999",
                UserName = "User1",
                PasswordHash = "Password1"
            };
            var user2 = new ApplicationUser()
            {
                Id = "2",
                Email = "email2@gmail.com",
                EmailConfirmed = true,
                FirstName = "User2",
                LastName = "User2",
                PhoneNumber = "0899999999",
                UserName = "User2",
                PasswordHash = "Password2"
            };

            var operation1 = new Operation()
            {
                DateMade = DateTime.Now,
                CounterPartyId = 1,
                DocumentTypeId = 1,
                Id = 1,
                TotalPurchasePriceWithoutVAT = 1,
                TotalPurchasePriceWithVAT = 1,
                TotalSalePriceWithoutVAT = 1,
                TotalSalePriceWithVAT = 1,
                UserId = "1",
            };
            var operation2 = new Operation()
            {
                DateMade = DateTime.Now,
                CounterPartyId = 2,
                DocumentTypeId = 2,
                Id = 2,
                TotalPurchasePriceWithoutVAT = 2,
                TotalPurchasePriceWithVAT = 2,
                TotalSalePriceWithoutVAT = 2,
                TotalSalePriceWithVAT = 2,
                UserId = "2",
            };

            var productOperation1 = new ProductOperation()
            {
                ProductId = 1,
                OperationId = 1
            };
            var productOperation2 = new ProductOperation()
            {
                ProductId = 2,
                OperationId = 2
            };

            await this.context.Barcodes.AddAsync(barcode1);
            await this.context.Barcodes.AddAsync(barcode2);
            await this.context.SaveChangesAsync();

            await this.context.ItemGroups.AddAsync(itemGroup1);
            await this.context.ItemGroups.AddAsync(itemGroup2);
            await this.context.SaveChangesAsync();

            await this.context.Measures.AddAsync(measure1);
            await this.context.Measures.AddAsync(measure2);
            await this.context.SaveChangesAsync();

            await this.context.ProductsMeasures.AddAsync(productMeasure1);
            await this.context.ProductsMeasures.AddAsync(productMeasure2);
            await this.context.SaveChangesAsync();

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.context.Firms.AddAsync(firm1);
            await this.context.Firms.AddAsync(firm2);
            await this.context.SaveChangesAsync();

            await this.context.Banks.AddAsync(bank1);
            await this.context.Banks.AddAsync(bank2);
            await this.context.SaveChangesAsync();

            await this.context.DocumentTypes.AddAsync(documentType1);
            await this.context.DocumentTypes.AddAsync(documentType2);
            await this.context.SaveChangesAsync();

            await this.context.CounterParties.AddAsync(counterParty1);
            await this.context.CounterParties.AddAsync(counterParty2);
            await this.context.SaveChangesAsync();

            await this.context.Operations.AddAsync(operation1);
            await this.context.Operations.AddAsync(operation2);
            await this.context.SaveChangesAsync();

            await this.context.Users.AddAsync(user1);
            await this.context.Users.AddAsync(user2);
            await this.context.SaveChangesAsync();

            await this.context.ProductsOperations.AddAsync(productOperation1);
            await this.context.ProductsOperations.AddAsync(productOperation2);
            await this.context.SaveChangesAsync();

            await this.context.Products.AddAsync(product1);
            await this.context.Products.AddAsync(product2);
            await this.context.Products.AddAsync(product3);
            await this.context.SaveChangesAsync();
        }
    }
}
