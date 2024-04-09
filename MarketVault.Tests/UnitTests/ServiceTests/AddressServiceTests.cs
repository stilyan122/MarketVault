namespace MarketVault.Tests.UnitTests.ServiceTests
{
    using Castle.Core.Logging;
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Data;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Tests.UnitTests.Mocks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Address Service tests class
    /// </summary>
    [TestFixture]
    public class AddressServiceTests : UnitTestBase
    {
        /// <summary>
        /// Address Service
        /// </summary>
        private IAddressService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Address> repository = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger = 
                new Mock<ILogger<Repository<Address>>>();

            var mockServiceLogger =
                new Mock<ILogger<AddressService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Address>(context,
                mockRepositoryLogger.Object);

            this.service = new AddressService(repository,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var invalidAddress = await this.repository.GetByIdAsync(1);

            var addressesBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var addressesAfterAdding = this.repository.All().Count();

            var addedAddress1 = await this.repository.GetByIdAsync(1);
            var addedAddress2 = await this.repository.GetByIdAsync(2);

            var newAddress = new AddressServiceModel()
            {
                StreetName = "NewStreetName",
                StreetNumber = "NewStreetNumber",
                TownName = "NewTownName"
            };

            await this.service.AddAsync(newAddress);

            var newCount = await this.repository
                .All()
                .CountAsync();

            Assert.Multiple(() =>
            {
                Assert.That(addressesBeforeAdding,
                Is.EqualTo(addressesAfterAdding - 2));

                Assert.That(invalidAddress,
                    Is.EqualTo(null));

                Assert.That(addedAddress1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedAddress2?.Id,
                    Is.EqualTo(2));

                Assert.That(newCount,
                    Is.EqualTo(3));
            });
        }

        /// <summary>
        /// Get predicated count async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetPredicatedCountAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var allCount = await this.service
                .GetPredicatedCountAsync("Street Name",
                "Test");

            var invalidCount = await this.service
                .GetPredicatedCountAsync("Street Name",
                "Invalid");

            Assert.Multiple(() =>
            {
                Assert.That(allCount, Is.EqualTo(2));
                Assert.That(invalidCount, Is.EqualTo(0));
            });
        }

        /// <summary>
        /// Get all by predicate paged async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAllByPredicatePagedAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var all1 = await this.service
                .GetAllByPredicatePagedAsync("Street Name", "Test",
                2, 1);

            Assert.That(all1.Count() == 2);
        }

        /// <summary>
        /// Get by id async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetByIdAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var validAddress = await this.service.GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validAddress.Id));

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
                .GetAllByPredicateAsync("Town Name", "TestTown1")
                .ToListAsync();

            var all2 = await this.service
                .GetAllByPredicateAsync("Town Name", "FalseTown")
                .ToListAsync();

            var all3 = await this.service
                .GetAllByPredicateAsync("False False", "some town name...")
                .ToListAsync();

            var all4 = await this.service
                .GetAllByPredicateAsync("Town Name", "Town")
                .ToListAsync();

            var all5 = await this.service
                .GetAllByPredicateAsync("Street Name", "Test")
                .ToListAsync();

            var all6 = await this.service
               .GetAllByPredicateAsync("Street Number", "Test")
               .ToListAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all1.Count == 1);
                Assert.That(all2.Count == 0);
                Assert.That(all3.Count == 0);
                Assert.That(all4.Count == 2);
                Assert.That(all5.Count == 2);
                Assert.That(all6.Count == 2);
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

            await this.service.DeleteAsync(new AddressServiceModel()
            {
                Id = 1
            }); 

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();

            var invalidModel = new AddressServiceModel()
            {
                Id = 1000,
                StreetName = "fake",
                StreetNumber = "fake",
                TownName = "fake"
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
            var townNameBefore = "TestTown1";
            var streetNameBefore = "TestStreet1";
            var streetNumberBefore = "TestNumber1";

            await this.SeedData();

            var newModel = new AddressServiceModel()
            {
                Id = 1,
                StreetName = "new",
                StreetNumber = "new",
                TownName = "new"
            };

            await service.UpdateAsync(newModel);

            var updated = await service.GetByIdAsync(newModel.Id);

            var invalidModel = new AddressServiceModel()
            {
                Id = 1000,
                StreetName = "fake",
                StreetNumber = "fake",
                TownName = "fake"
            };

            Assert.Multiple(() =>
            {
                Assert.That(streetNameBefore != newModel.StreetName);
                Assert.That(streetNumberBefore != newModel.StreetNumber);
                Assert.That(townNameBefore != newModel.TownName);
                Assert.That(updated.StreetName == newModel.StreetName);
                Assert.That(updated.StreetNumber == newModel.StreetNumber);
                Assert.That(updated.TownName == newModel.TownName);
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

            await this.repository.AddAsync(address1);
            await this.repository.AddAsync(address2);
        }
    }
}
