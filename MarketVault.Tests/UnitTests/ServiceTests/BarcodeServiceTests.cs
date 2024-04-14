namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Barcode Operation Service tests class
    /// </summary>
    [TestFixture]
    public class BarcodeServiceTests : UnitTestBase
    {
        /// <summary>
        /// Barcode Service
        /// </summary>
        private IBarcodeService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Barcode> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Barcode>>>();

            var mockServiceLogger =
                new Mock<ILogger<BarcodeService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Barcode>(context,
                mockRepositoryLogger.Object);

            this.service = new BarcodeService(repository,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var countBefore = await this.repository
                .All()
                .CountAsync();

            var newEntity = new Barcode()
            {
                Value = "1111",
                ProductId = 1
            };

            await this.service.AddAsync(newEntity);

            var countAfter = await this.repository
                .All()
                .CountAsync();

            Assert.That(countAfter - countBefore, Is.EqualTo(1));
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

            await this.context.Products.AddAsync(product1);
            await this.context.Products.AddAsync(product2);
            await this.context.SaveChangesAsync();

            await this.context.ItemGroups.AddAsync(itemGroup1);
            await this.context.ItemGroups.AddAsync(itemGroup2);
            await this.context.SaveChangesAsync();
        }
     }
}
