namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Operation Service tests class
    /// </summary>
    [TestFixture]
    public class OperationServiceTests : UnitTestBase
    {
        /// <summary>
        /// Operation Service
        /// </summary>
        private IOperationService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Operation> repository = null!;

        /// <summary>
        /// Product Operation Service
        /// </summary>
        private IProductOperationService productOperationService = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Operation>>>();

            var mockServiceLogger =
                new Mock<ILogger<OperationService>>();

            var mockProductOperationService = 
                new Mock<IProductOperationService>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Operation>(context,
                mockRepositoryLogger.Object);

            this.productOperationService = mockProductOperationService.Object;

            this.service = new OperationService(repository,
                mockServiceLogger.Object,
                productOperationService);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var operationsBeforeAdding = await this.repository
                .All()
                .CountAsync();
            
            await this.SeedData();

            var operationsAfterAdding = await this.repository
                .All()
                .CountAsync();

            var newEntity = new OperationServiceModel()
            {
                DateMade = DateTime.UtcNow,
                DocumentTypeId = 1,
                CounterPartyId = 1,
                TotalPurchasePriceWithoutVAT = 4,
                TotalPurchasePriceWithVAT = 4,
                TotalSalePriceWithoutVAT = 4,
                TotalSalePriceWithVAT = 4,
                UserId = "2"
            };

            var newServiceModel = new ProductOperationServiceModel()
            {
                DocumentTypeId = 1,
                CounterPartyId = 1,
                OperationId = 3,
                Products = new List<ProductForOperationServiceModel>()
                {
                    new ProductForOperationServiceModel()
                    {
                        PurchasePrice = 12,
                        Quantity = 12,
                        SalePrice = 12,
                        Id = 1
                    },
                    new ProductForOperationServiceModel()
                    {
                        PurchasePrice = 11,
                        Quantity = 11,
                        SalePrice = 11,
                        Id = 2
                    },
                }
            };

            await this.service.AddAsync(newEntity, newServiceModel);

            var newCount = await this.repository
                .All()
                .CountAsync();

            Assert.Multiple(() =>
            {
                Assert.That(operationsAfterAdding - operationsBeforeAdding, Is.EqualTo(2));
                Assert.That(newCount - operationsAfterAdding, Is.EqualTo(1));
            });
        }

        /// <summary>
        /// Get user operations async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetUserOperationsAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var operations = await this.service.GetUserOperationsAsync("1");

            Assert.That(operations.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// Private method for seeding data
        /// </summary>
        /// <returns>(void)</returns>
        private async Task SeedData()
        {
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

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.context.ItemGroups.AddAsync(itemGroup1);
            await this.context.ItemGroups.AddAsync(itemGroup2);
            await this.context.SaveChangesAsync();

            await this.context.Products.AddAsync(product1);
            await this.context.Products.AddAsync(product2);
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

            await this.repository.AddAsync(operation1);
            await this.repository.AddAsync(operation2);

            await this.context.Users.AddAsync(user1);
            await this.context.Users.AddAsync(user2);
        }
    }
}
