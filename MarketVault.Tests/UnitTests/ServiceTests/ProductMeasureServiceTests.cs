namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Product Measure Service tests class
    /// </summary>
    [TestFixture]
    public class ProductMeasureServiceTests : UnitTestBase
    {
        /// <summary>
        /// ProductMeasure Service
        /// </summary>
        private IProductMeasureService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<ProductMeasure> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<ProductMeasure>>>();

            var mockServiceLogger =
                new Mock<ILogger<ProductMeasureService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<ProductMeasure>(context,
                mockRepositoryLogger.Object);

            this.service = new ProductMeasureService(repository,
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

            var productMeasureBeforeAdding = 
                this.repository.All().Count();

            var productMeasure1 = new ProductMeasureServiceModel()
            {
                MeasureId = 1,
                ProductId = 1
            };
            var productMeasure2 = new ProductMeasureServiceModel()
            {
                MeasureId = 2,
                ProductId = 2
            };

            await this.service.AddAsync(productMeasure1);
            await this.service.AddAsync(productMeasure2);

            var productMeasuresAfterAdding = 
                this.repository.All().Count();

            Assert.Multiple(() =>
            {
                Assert.That(productMeasureBeforeAdding,
                Is.EqualTo(productMeasuresAfterAdding - 2));
            });
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

            var measure1 = new Measure()
            {
                Id = 1,
                CanBeDecimal = true,
                Name = "Measure1"
            };
            var measure2 = new Measure()
            {
                Id = 2,
                CanBeDecimal = false,
                Name = "Measure2",
            };

            await this.context.ItemGroups.AddAsync(itemGroup1);
            await this.context.ItemGroups.AddAsync(itemGroup2);
            await this.context.SaveChangesAsync();

            await this.context.Measures.AddAsync(measure1);
            await this.context.Measures.AddAsync(measure2);
            await this.context.SaveChangesAsync();

            await this.context.Products.AddAsync(product1);
            await this.context.Products.AddAsync(product2);
            await this.context.SaveChangesAsync();
        }
    }
}
