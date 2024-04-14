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

            var newEntity = new FirmServiceModel()
            {
                Name = "NewName",
                Email = "NewEmail",
                PhoneNumber = "NewPhoneNumber",
                ResponsiblePersonName = "NewResponsiblePersonName"
            };

            await this.service.AddAsync(newEntity);

            var newCount = await this.service.GetCountAsync();

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

                Assert.That(newCount - firmsAfterAdding, Is.EqualTo(1));
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

            var all5 = await this.service
                .GetAllByPredicateAsync("Address", "Test")
                .ToListAsync();

            var all6 = await this.service
                .GetAllByPredicateAsync("Phone Number", "08")
                .ToListAsync();

            var all7 = await this.service
                .GetAllByPredicateAsync("Email", "firm")
                .ToListAsync();

            var all8 = await this.service
               .GetAllByPredicateAsync("Responsible Person Name", "Valeria")
               .ToListAsync();

            Assert.Multiple(() =>
            {
                Assert.That(all1.Count == 1);
                Assert.That(all2.Count == 0);
                Assert.That(all3.Count == 0);
                Assert.That(all4.Count == 2);
                Assert.That(all5.Count == 2);
                Assert.That(all6.Count == 2);
                Assert.That(all7.Count == 2);
                Assert.That(all8.Count == 1);
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
                .GetPredicatedCountAsync("Name",
                "Invalid");

            var all1 = await this.service
              .GetPredicatedCountAsync("Name", "Firm1");

            var all2 = await this.service
                .GetPredicatedCountAsync("Name", "FalseFirm");

            var all3 = await this.service
                .GetPredicatedCountAsync("False False", "some firm name...");

            var all4 = await this.service
                .GetPredicatedCountAsync("Name", "Firm");

            var all5 = await this.service
                .GetPredicatedCountAsync("Address", "Test");

            var all6 = await this.service
               .GetPredicatedCountAsync("Phone Number", "08");

            var all7 = await this.service
                .GetPredicatedCountAsync("Email", "firm");

            var all8 = await this.service
               .GetPredicatedCountAsync("Responsible Person Name", "Valeria");

            Assert.Multiple(() =>
            {
                Assert.That(invalidCount, Is.EqualTo(0));
                Assert.That(all1 == 1);
                Assert.That(all2 == 0);
                Assert.That(all3 == 0);
                Assert.That(all4 == 2);
                Assert.That(all5 == 2);
                Assert.That(all6 == 2);
                Assert.That(all7 == 2);
                Assert.That(all8 == 1);
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
               .GetAllByPredicatePagedAsync("Name", "Firm1", 10, 1);

            var all2 = await this.service
                .GetAllByPredicatePagedAsync("Name", "FalseFirm", 10, 1);

            var all3 = await this.service
                .GetAllByPredicatePagedAsync("False False", "some firm name...", 10, 1);

            var all4 = await this.service
                .GetAllByPredicatePagedAsync("Name", "Firm", 10, 1);

            var all5 = await this.service
                .GetAllByPredicatePagedAsync("Address", "Test", 10, 1);

            var all6 = await this.service
              .GetAllByPredicatePagedAsync("Phone Number", "08", 10, 1);

            var all7 = await this.service
                .GetAllByPredicatePagedAsync("Email", "firm", 10, 1);

            var all8 = await this.service
               .GetAllByPredicatePagedAsync("Responsible Person Name", "Valeria", 10, 1);

            Assert.That(invalidCount.Count() == 0);
            Assert.That(all1.Count() == 1);
            Assert.That(all2.Count() == 0);
            Assert.That(all3.Count() == 0);
            Assert.That(all4.Count() == 2);
            Assert.That(all5.Count() == 2);
            Assert.That(all6.Count() == 2);
            Assert.That(all7.Count() == 2);
            Assert.That(all8.Count() == 1);
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

            await this.service.DeleteAsync(new FirmServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();
            var counterPartiesCountAfter = await this.context.CounterParties
                .Where(cp => cp.IsActive)
                .CountAsync();

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

            await this.service.DeleteRangeAsync(new List<FirmServiceModel>()
            {
                new FirmServiceModel()
                {
                    Id = 1
                },
                new FirmServiceModel()
                {
                    Id = 2
                }
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();
            var counterPartiesCountAfter = await this.context.CounterParties
                .Where(cp => cp.IsActive)
                .CountAsync();

            var invalidModel = new FirmServiceModel()
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
                AddressId = 1,
                PhoneNumber = "0891313555",
                Email = "firm1@example.com",
                ResponsiblePersonName = "Mark Tristan"
            };
            var firm2 = new Firm()
            {
                Id = 2,
                Name = "Firm2",
                AddressId = 2,
                PhoneNumber = "0895613255",
                Email = "firm2@example.com",
                ResponsiblePersonName = "Valeria Grand"
            };

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.context.Banks.AddAsync(bank1);
            await this.context.Banks.AddAsync(bank2);
            await this.context.SaveChangesAsync();

            await this.repository.AddAsync(firm1);
            await this.repository.AddAsync(firm2);

            await this.context.CounterParties.AddAsync(counterParty1);
            await this.context.CounterParties.AddAsync(counterParty2);
            await this.context.SaveChangesAsync();
        }
    }
}
