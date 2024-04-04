namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Measure Service tests class
    /// </summary>
    [TestFixture]
    public class MeasureServiceTests : UnitTestBase
    {
        /// <summary>
        /// Measure Service
        /// </summary>
        private IMeasureService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Measure> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Measure>>>();

            var mockServiceLogger =
                new Mock<ILogger<MeasureService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Measure>(context,
                mockRepositoryLogger.Object);

            this.service = new MeasureService(repository,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Get all async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAllAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var all = await this.service.GetAllAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all.Count() == 2);
                Assert.That(all.Where(a => a.Id == 1).Count() == 1);
                Assert.That(all.Where(a => a.Id == 2).Count() == 1);
            });
        }

        /// <summary>
        /// Private method for seeding data
        /// </summary>
        /// <returns>(void)</returns>
        private async Task SeedData()
        {
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

            await this.repository.AddAsync(measure1);
            await this.repository.AddAsync(measure2);
        }
    }
}
