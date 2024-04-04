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
    /// Document Type Service tests class
    /// </summary>
    public class DocumentTypeServiceTests : UnitTestBase
    {
        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<DocumentType> repository = null!;

        /// <summary>
        /// Counter Party Service
        /// </summary>
        private IDocumentTypeService service = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<DocumentType>>>();

            var mockServiceLogger =
                new Mock<ILogger<DocumentTypeService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<DocumentType>(context,
                mockRepositoryLogger.Object);

            this.service = new DocumentTypeService(repository,
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
            var documentType1 = new DocumentType()
            {
                Id = 1,
                Name = "Firm1",
            };
            var documentType2 = new DocumentType()
            {
                Id = 2,
                Name = "Firm2",
            };

            await this.repository.AddAsync(documentType1);
            await this.repository.AddAsync(documentType2);
        }
    }
}
