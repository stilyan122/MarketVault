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
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Bank Service tests class
    /// </summary>
    [TestFixture]
    public class BankServiceTests
    {
        /// <summary>
        /// Bank Service
        /// </summary>
        private IBankService service;

        /// <summary>
        /// Counter party Service
        /// </summary>
        private Mock<ICounterPartyService> counterPartyService;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Bank> repository;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.repository = new Repository<Bank>(DatabaseMock.Mock);
            this.counterPartyService = new Mock<ICounterPartyService>();
            this.service = new BankService(repository, 
                counterPartyService.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1"
            };
            var bank2 = new BankServiceModel()
            {
                Id = 2,
                Name = "Bank2"
            };

            var invalidBank = await this.repository.GetByIdAsync(1);

            var banksBeforeAdding = this.repository.All().Count();

            await this.service.AddAsync(bank1);

            var banks1AfterAdding = this.repository.All().Count();

            await this.service.AddAsync(bank2);

            var banks2AfterAdding = this.repository.All().Count();

            var addedBank1 = await this.repository.GetByIdAsync(1);
            var addedBank2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(banksBeforeAdding,
                Is.EqualTo(banks1AfterAdding - 1));

                Assert.That(banksBeforeAdding,
                    Is.EqualTo(banks2AfterAdding - 2));

                Assert.That(invalidBank,
                    Is.EqualTo(null));

                Assert.That(addedBank1?.Id,
                    Is.EqualTo(bank1.Id));

                Assert.That(addedBank2?.Id,
                    Is.EqualTo(bank2.Id));
            });
        }

        /// <summary>
        /// Get by id async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetByIdAsync_ShouldWorkProperly()
        {
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1"
            };

            await this.service.AddAsync(bank1);

            var validBank = await this.service.GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(bank1.Id,
                    Is.EqualTo(validBank.Id));

                Assert.Throws<EntityNotFoundException>(() =>
                {
                    this.service.GetByIdAsync(-1);
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
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1"
            };
            var bank2 = new BankServiceModel()
            {
                Id = 2,
                Name = "Bank2"
            };

            await this.service.AddAsync(bank1);
            await this.service.AddAsync(bank2);

            var all = await this.service.GetAllAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all.Count() == 2);
                Assert.That(all.Where(a => a.Id == 1).Count() == 1);
                Assert.That(all.Where(a => a.Id == 2).Count() == 1);
            });
        }

        /// <summary>
        /// Get all by predicate async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task GetAllByPredicateAsync_ShouldWorkProperly()
        {
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1"
            };
            var bank2 = new BankServiceModel()
            {
                Id = 2,
                Name = "Bank2"
            };

            await this.service.AddAsync(bank1);
            await this.service.AddAsync(bank2);

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
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1"
            };
            var bank2 = new BankServiceModel()
            {
                Id = 2,
                Name = "Bank2"
            };

            await this.service.AddAsync(bank1);
            await this.service.AddAsync(bank2);

            var allBefore = await this.service.GetAllAsync();
            var countBefore = allBefore.Count();

            await this.service.DeleteAsync(bank1);

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();

            var invalidModel = new BankServiceModel()
            {
                Id = 1000,
                Name = "fake name"
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
            var bank1 = new BankServiceModel()
            {
                Id = 1,
                Name = "Bank1",
                AddressId = 1
            };
            var address2 = new BankServiceModel()
            {
                Id = 2,
                Name = "Bank2",
                AddressId = 2
            };

            await this.service.AddAsync(bank1);
            await this.service.AddAsync(address2);

            var nameBefore = bank1.Name;
            var addressBefore = bank1.AddressId;

            var newModel = new BankServiceModel()
            {
                Id = bank1.Id,
                Name = "new",
                AddressId = 0
            };

            await service.UpdateAsync(newModel);

            var updated = await service.GetByIdAsync(newModel.Id);

            var invalidModel = new BankServiceModel()
            {
                Id = 1000,
                Name = "fake",
                AddressId = 1000
            };

            Assert.Multiple(() =>
            {
                Assert.That(bank1.Name != newModel.Name);
                Assert.That(bank1.AddressId != newModel.AddressId);
                Assert.That(updated.Name == newModel.Name);
                Assert.That(updated.AddressId == newModel.AddressId);
                Assert.ThrowsAsync<EntityNotFoundException>(() =>
                {
                    return this.service.UpdateAsync(invalidModel);
                });
            });
        }
    }
}
