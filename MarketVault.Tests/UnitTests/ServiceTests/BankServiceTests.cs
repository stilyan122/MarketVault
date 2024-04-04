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
    /// Bank Service tests class
    /// </summary>
    [TestFixture]
    public class BankServiceTests : UnitTestBase
    {
        /// <summary>
        /// Bank Service
        /// </summary>
        private IBankService service = null!;

        /// <summary>
        /// Counter Party Service
        /// </summary>
        private ICounterPartyService counterPartyService = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Bank> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Bank>>>();

            var mockServiceLogger =
                new Mock<ILogger<BankService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Bank>(context,
                mockRepositoryLogger.Object);

            this.counterPartyService = new Mock<ICounterPartyService>()
                .Object;

            this.service = new BankService(repository,
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
            var invalidBank = await this.repository.GetByIdAsync(1);

            var bankBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var banksAfterAdding = this.repository.All().Count();

            var addedBank1 = await this.repository.GetByIdAsync(1);
            var addedBank2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(bankBeforeAdding,
                Is.EqualTo(banksAfterAdding - 2));

                Assert.That(invalidBank,
                    Is.EqualTo(null));

                Assert.That(addedBank1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedBank2?.Id,
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

            var validBank = await this.service.GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validBank.Id));

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
                .GetAllByPredicateAsync("Name", "Bank1")
                .ToListAsync();

            var all2 = await this.service
                .GetAllByPredicateAsync("Name", "FalseBank")
                .ToListAsync();

            var all3 = await this.service
                .GetAllByPredicateAsync("False False", "some bank name...")
                .ToListAsync();

            var all4 = await this.service
                .GetAllByPredicateAsync("Name", "Bank")
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

            await this.service.DeleteAsync(new BankServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();

            var invalidModel = new BankServiceModel()
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
            var nameBefore = "Bank1";

            await this.SeedData();

            var newModel = new BankServiceModel()
            {
                Id = 1,
                Name = "new",
                AddressId = 1
            };

            await this.service.UpdateAsync(newModel);

            var updated = await this.service.GetByIdAsync(1);

            var invalidModel = new BankServiceModel()
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

            await this.repository.AddAsync(bank1);
            await this.repository.AddAsync(bank2);
        }
    }
}
