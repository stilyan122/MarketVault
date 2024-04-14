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

            var counterParty1 = new CounterPartyServiceModel()
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
            var counterParty2 = new CounterPartyServiceModel()
            {
                Id = 2,
                Name = "CounterParty2",
                BankCode = "BankCode2",
                BankIBAN = "BankIBAN2",
                BankId = 2,
                FirmId = 2,
                ValueAddedTaxLawId = "VATLI2",
                VATNumber = "VATNumber2"
            };

            IEnumerable<CounterPartyServiceModel> counterParties =
                 new List<CounterPartyServiceModel>() { counterParty1, counterParty2 };

            var counterPartyServiceMock = new Mock<ICounterPartyService>();

            counterPartyServiceMock.Setup(p => p.GetAllAsync())
                .Returns(Task.FromResult(counterParties));

            counterPartyServiceMock.Setup(p => p.DeleteAsync(
                It.IsAny<CounterPartyServiceModel>()))
                .Callback<CounterPartyServiceModel>(async model =>
                {
                    var entity = await this.context
                    .CounterParties
                    .FirstOrDefaultAsync(p => p.Id ==
                        model.Id) ?? new CounterParty();

                    entity.IsActive = false;
                    await this.context.SaveChangesAsync();
                });

            this.counterPartyService = counterPartyServiceMock.Object;

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

            var bankBeforeAdding = await this.repository.All().CountAsync();

            await this.SeedData();

            var banksAfterAdding = await this.repository.All().CountAsync();

            var newEntity = new BankServiceModel()
            {
                Name = "NewName"
            };

            await this.service.AddAsync(newEntity);

            var newCount = await this.service.GetCountAsync();

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

                Assert.That(newCount - banksAfterAdding,
                    Is.EqualTo(1));
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

            var all5 = await this.service
                .GetAllByPredicateAsync("Address", "Test")
                .ToListAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all1.Count == 1);
                Assert.That(all2.Count == 0);
                Assert.That(all3.Count == 0);
                Assert.That(all4.Count == 2);
                Assert.That(all5.Count == 2);
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

            var invalidCount = await this.service
                .GetPredicatedCountAsync("Street Name",
                "Invalid");

            var all1 = await this.service
              .GetPredicatedCountAsync("Name", "Bank1");

            var all2 = await this.service
                .GetPredicatedCountAsync("Name", "FalseBank");

            var all3 = await this.service
                .GetPredicatedCountAsync("False False", "some bank name...");

            var all4 = await this.service
                .GetPredicatedCountAsync("Name", "Bank");

            var all5 = await this.service
                .GetPredicatedCountAsync("Address", "Test");


            Assert.Multiple(() =>
            {
                Assert.That(invalidCount, Is.EqualTo(0));
                Assert.That(all1 == 1);
                Assert.That(all2 == 0);
                Assert.That(all3 == 0);
                Assert.That(all4 == 2);
                Assert.That(all5 == 2);
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

            var invalidCount = await this.service
                .GetAllByPredicatePagedAsync("Name",
                "Invalid", 10, 1);

            var all1 = await this.service
              .GetAllByPredicatePagedAsync("Name", "Bank1", 10, 1);

            var all2 = await this.service
                .GetAllByPredicatePagedAsync("Name", "FalseBank", 10, 1);

            var all3 = await this.service
                .GetAllByPredicatePagedAsync("False False", "some bank name...", 10, 1);

            var all4 = await this.service
                .GetAllByPredicatePagedAsync("Name", "Bank", 10, 1);

            var all5 = await this.service
                .GetAllByPredicatePagedAsync("Address", "Test", 10, 1);

            Assert.That(all1.Count() == 1);
            Assert.That(all2.Count() == 0);
            Assert.That(all3.Count() == 0);
            Assert.That(all4.Count() == 2);
            Assert.That(all5.Count() == 2);
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
            var counterPartiesCountBefore = await this.context.CounterParties.CountAsync();

            await this.service.DeleteAsync(new BankServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();
            var counterPartiesCountAfter = await this.context.CounterParties
                .Where(cp => cp.IsActive)
                .CountAsync();

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
                Assert.That(counterPartiesCountBefore - counterPartiesCountAfter == 1);
                Assert.ThrowsAsync<EntityNotFoundException>(() =>
                {
                    return this.service.DeleteAsync(invalidModel);
                });
            });
        }

        /// <summary>
        /// Delete range async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task DeleteRangeAsync_ShouldWorkProperly()
        {
            await this.SeedData();

            var allBefore = await this.service.GetAllAsync();
            var countBefore = allBefore.Count();
            var counterPartiesCountBefore = await this.context.CounterParties.CountAsync();

            await this.service.DeleteRangeAsync(new List<BankServiceModel>()
            { 
                new BankServiceModel()
                {
                    Id = 1
                },
                new BankServiceModel()
                {
                    Id = 2
                }
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();
            var counterPartiesCountAfter = await this.context.CounterParties
                .Where(cp => cp.IsActive)
                .CountAsync();

            var invalidModel = new BankServiceModel()
            {
                Id = 1000,
                Name = "FAKE"
            };

            Assert.Multiple(() =>
            {
                Assert.That(countBefore, Is.EqualTo(2));
                Assert.That(countAfter, Is.EqualTo(0));
                Assert.That(allBefore.Count(a => a.Id == 1) == 1);
                Assert.That(allAfter.Any(a => a.Id == 1 || a.Id == 2) == false);
                Assert.That(counterPartiesCountBefore - counterPartiesCountAfter == 2);
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
                BankId = 2,
                FirmId = 2,
                ValueAddedTaxLawId = "VATLI2",
                VATNumber = "VATNumber2"
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

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.context.Firms.AddAsync(firm1);
            await this.context.Firms.AddAsync(firm2);
            await this.context.SaveChangesAsync();

            await this.repository.AddAsync(bank1);
            await this.repository.AddAsync(bank2);

            await this.context.CounterParties.AddAsync(counterParty1);
            await this.context.CounterParties.AddAsync(counterParty2);
            await this.context.SaveChangesAsync();
        }
    }
}
