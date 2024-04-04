namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Exceptions;
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
    /// Firm Service tests class
    /// </summary>
    [TestFixture]
    public class FirmServiceTests : UnitTestBase
    {
        /// <summary>
        /// Firm Service
        /// </summary>
        private IFirmService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Firm> repository = null!;

        /// <summary>
        /// Counter Party Service
        /// </summary>
        private ICounterPartyService counterPartyService = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Firm>>>();

            var mockServiceLogger =
                new Mock<ILogger<FirmService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Firm>(context,
                mockRepositoryLogger.Object);

            this.counterPartyService = new Mock<ICounterPartyService>()
                .Object;

            this.service = new FirmService(repository,
                this.counterPartyService,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var invalidFirm = await this.repository.GetByIdAsync(1);

            var firmBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var firmsAfterAdding = this.repository.All().Count();

            var addedFirm1 = await this.repository.GetByIdAsync(1);
            var addedFirm2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(firmBeforeAdding,
                Is.EqualTo(firmsAfterAdding - 2));

                Assert.That(invalidFirm,
                    Is.EqualTo(null));

                Assert.That(addedFirm1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedFirm2?.Id,
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

            var validFirm = await this.service.GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validFirm.Id));

                Assert.ThrowsAsync<EntityNotFoundException>(() =>
                {
                    return this.service.GetByIdAsync(-1);
                });
            });
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
        /// Get count async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetCountAsync_ShouldWorkProperly()
        {
            Assert.That(await
                this.service.GetCountAsync(),
                Is.EqualTo(0));

            await this.SeedData();

            Assert.That(await
                this.service.GetCountAsync(),
                Is.EqualTo(2));
        }

        /// <summary>
        /// Get all by predicate async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAllByPredicateAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var all1 = await this.service
                .GetAllByPredicateAsync("Name", "Firm1")
                .ToListAsync();

            var all2 = await this.service
                .GetAllByPredicateAsync("Name", "FalseFirm")
                .ToListAsync();

            var all3 = await this.service
                .GetAllByPredicateAsync("False False", "some firm name...")
                .ToListAsync();

            var all4 = await this.service
                .GetAllByPredicateAsync("Name", "Firm")
                .ToListAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all1.Count == 1);
                Assert.That(all2.Count == 0);
                Assert.That(all3.Count == 0);
                Assert.That(all4.Count == 2);
            });
        }

        /// <summary>
        /// Delete async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task DeleteAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var allBefore = await this.service.GetAllAsync();
            var countBefore = allBefore.Count();

            await this.service.DeleteAsync(new FirmServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();

            var invalidModel = new FirmServiceModel()
            {
                Id = 1000,
                Name = "FAKE"
            };

            Assert.Multiple(() =>
            {
                Assert.That(countBefore, Is.EqualTo(2));
                Assert.That(countAfter, Is.EqualTo(1));
                Assert.That(allBefore.Count(a => a.Id == 1) == 1);
                Assert.That(allAfter.Any(a => a.Id == 1) == false);
                Assert.ThrowsAsync<EntityNotFoundException>(() =>
                {
                    return this.service.DeleteAsync(invalidModel);
                });
            });
        }

        /// <summary>
        /// Update async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task UpdateAsync_ShouldWorkProperly()
        {
            var nameBefore = "Firm1";

            await this.SeedData();

            var newModel = new FirmServiceModel()
            {
                Id = 1,
                Name = "new",
                AddressId = 1
            };

            await this.service.UpdateAsync(newModel);

            var updated = await this.service.GetByIdAsync(1);

            var invalidModel = new FirmServiceModel()
            {
                Id = 1000,
                Name = "fake"
            };

            Assert.Multiple(() =>
            {
                Assert.That(nameBefore != newModel.Name);
                Assert.That(updated.Name == newModel.Name);
                Assert.ThrowsAsync<EntityNotFoundException>(() =>
                {
                    return this.service.UpdateAsync(invalidModel);
                });
            });
        }

        /// <summary>
        /// Private method for seeding data
        /// </summary>
        /// <returns>(void)</returns>
        private async Task SeedData()
        {
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

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.repository.AddAsync(firm1);
            await this.repository.AddAsync(firm2);
        }
    }
}
