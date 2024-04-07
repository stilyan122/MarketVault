namespace MarketVault.Tests.UnitTests.RepositoryTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Repository Service test class
    /// </summary
    [TestFixture]
    public class RepositoryTests : UnitTestBase
    {
        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Product> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.context = DatabaseMock.Mock;

            var mockLogger = new Mock<ILogger<Repository<Product>>>()
                .Object;

            this.repository = new Repository<Product>(context,
                mockLogger);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var invalidProduct = await this.repository.GetByIdAsync(1);

            var ProductBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var ProductsAfterAdding = this.repository.All().Count();

            var addedProduct1 = await this.repository.GetByIdAsync(1);
            var addedProduct2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(ProductBeforeAdding,
                Is.EqualTo(ProductsAfterAdding - 2));

                Assert.That(invalidProduct,
                    Is.EqualTo(null));

                Assert.That(addedProduct1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedProduct2?.Id,
                    Is.EqualTo(2));
            });
        }

        /// <summary>
        /// Get by id async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetByIdAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var validProduct = await this.repository.GetByIdAsync(1);
            var invalidProduct = await this.repository.GetByIdAsync(100);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validProduct?.Id));

                Assert.That(invalidProduct,
                    Is.EqualTo(null));
            });
        }

        /// <summary>
        /// Get all async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAll_ShouldWorkProperly()
        {
            await this.SeedData();

            var all = this.repository.All();

            Assert.Multiple(() =>
            {
                Assert.That(all.CountAsync().Result == 2);
                Assert.That(all.Where(a => a.Id == 1).CountAsync().Result == 1);
                Assert.That(all.Where(a => a.Id == 2).CountAsync().Result == 1);
            });
        }

        /// <summary>
        /// Get all async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAllAsReadOnly_ShouldWorkProperly()
        {
            await this.SeedData();

            var all = this.repository.AllAsReadOnly();

            Assert.Multiple(() =>
            {
                Assert.That(all.CountAsync().Result == 2);
                Assert.That(all.Where(a => a.Id == 1).CountAsync().Result == 1);
                Assert.That(all.Where(a => a.Id == 2).CountAsync().Result == 1);
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

            await this.repository.AddAsync(product1);
            await this.repository.AddAsync(product2);
        }
    }
}
