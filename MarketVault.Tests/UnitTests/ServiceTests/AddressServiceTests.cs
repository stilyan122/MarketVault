//namespace MarketVault.Tests.UnitTests.ServiceTests
//{
//    using MarketVault.Core.Contracts;
//    using MarketVault.Core.Exceptions;
//    using MarketVault.Core.Implementations;
//    using MarketVault.Core.Models;
//    using MarketVault.Core.Services.Impementations;
//    using MarketVault.Core.Services.Interfaces;
//    using MarketVault.Infrastructure.Data.Models;
//    using MarketVault.Tests.UnitTests.Mocks;
//    using Microsoft.EntityFrameworkCore;
//    using NUnit.Framework;

//    /// <summary>
//    /// Address Service tests class
//    /// </summary>
//    [TestFixture]
//    public class AddressServiceTests
//    {
//        /// <summary>
//        /// Address Service
//        /// </summary>
//        private IAddressService service;

//        /// <summary>
//        /// Repository
//        /// </summary>
//        private IRepository<Address> repository;
    
//        /// <summary>
//        /// SetUp method
//        /// </summary>
//        [SetUp]
//        public void Setup()
//        {
//            this.repository = new Repository<Address>(DatabaseMock.Mock);
//            this.service = new AddressService(repository);
//        }
    
//        /// <summary>
//        /// Add async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task AddAsync_ShouldWorkProperly()
//          {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };
//            var address2 = new AddressServiceModel()
//            {
//                Id = 2,
//                StreetName = "TestStreet2",
//                StreetNumber = "TestNumber2",
//                TownName = "TestTown2"
//            };

//            var invalidAddress = await this.repository.GetByIdAsync(1);

//            var addressesBeforeAdding = this.repository.All().Count();

//            await this.service.AddAsync(address1);

//            var addresses1AfterAdding = this.repository.All().Count();
            
//            await this.service.AddAsync(address2);

//            var addresses2AfterAdding = this.repository.All().Count();

//            var addedAddress1 = await this.repository.GetByIdAsync(1);
//            var addedAddress2 = await this.repository.GetByIdAsync(2);

//            Assert.Multiple(() =>
//            {
//                Assert.That(addressesBeforeAdding,
//                Is.EqualTo(addresses1AfterAdding - 1));

//                Assert.That(addressesBeforeAdding,
//                    Is.EqualTo(addresses2AfterAdding - 2));

//                Assert.That(invalidAddress,
//                    Is.EqualTo(null));

//                Assert.That(addedAddress1?.Id,
//                    Is.EqualTo(address1.Id));

//                Assert.That(addedAddress2?.Id,
//                    Is.EqualTo(address2.Id));
//            });
//        }

//        /// <summary>
//        /// Get by id async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task GetByIdAsync_ShouldWorkProperly()
//        {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };

//            await this.service.AddAsync(address1);

//            var validAddress = await this.service.GetByIdAsync(1);

//            Assert.Multiple(() =>
//            {
//                Assert.That(address1.Id,
//                    Is.EqualTo(validAddress.Id));

//                Assert.ThrowsAsync<EntityNotFoundException>(() =>
//                {
//                    return this.service.GetByIdAsync(-1);
//                });
//            });
//        }

//        /// <summary>
//        /// Get all async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task GetAllAsync_ShouldWorkProperly()
//        {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };
//            var address2 = new AddressServiceModel()
//            {
//                Id = 2,
//                StreetName = "TestStreet2",
//                StreetNumber = "TestNumber2",
//                TownName = "TestTown2"
//            };

//            await this.service.AddAsync(address1);
//            await this.service.AddAsync(address2);

//            var all = await this.service.GetAllAsync();

//            Assert.Multiple(() =>
//            {
//                Assert.That(all.Count() == 2);
//                Assert.That(all.Where(a => a.Id == 1).Count() == 1);
//                Assert.That(all.Where(a => a.Id == 2).Count() == 1);
//            });
//        }

//        /// <summary>
//        /// Get all by predicate async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task GetAllByPredicateAsync_ShouldWorkProperly()
//        {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };
//            var address2 = new AddressServiceModel()
//            {
//                Id = 2,
//                StreetName = "TestStreet2",
//                StreetNumber = "TestNumber2",
//                TownName = "TestTown2"
//            };

//            await this.service.AddAsync(address1);
//            await this.service.AddAsync(address2);

//            var all1 = await this.service
//                .GetAllByPredicateAsync("Town Name", "TestTown1")
//                .ToListAsync();

//            var all2 = await this.service
//                .GetAllByPredicateAsync("Town Name", "FalseTown")
//                .ToListAsync();

//            var all3 = await this.service
//                .GetAllByPredicateAsync("False False", "some town name...")
//                .ToListAsync();

//            var all4 = await this.service
//                .GetAllByPredicateAsync("Town Name", "Town")
//                .ToListAsync();

//            Assert.Multiple(() =>
//            {
//                Assert.That(all1.Count == 1);
//                Assert.That(all2.Count == 0);
//                Assert.That(all3.Count == 0);
//                Assert.That(all4.Count == 2);
//            });
//        }

//        /// <summary>
//        /// Delete async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task DeleteAsync_ShouldWorkProperly()
//        {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };
//            var address2 = new AddressServiceModel()
//            {
//                Id = 2,
//                StreetName = "TestStreet2",
//                StreetNumber = "TestNumber2",
//                TownName = "TestTown2"
//            };

//            await this.service.AddAsync(address1);
//            await this.service.AddAsync(address2);

//            var allBefore = await this.service.GetAllAsync();
//            var countBefore = allBefore.Count();

//            await this.service.DeleteAsync(address1);

//            var allAfter = await this.service.GetAllAsync();
//            var countAfter = allAfter.Count();

//            var invalidModel = new AddressServiceModel()
//            {
//                Id = 1000,
//                StreetName = "fake",
//                StreetNumber = "fake",
//                TownName = "fake"
//            };

//            Assert.Multiple(() =>
//            {
//                Assert.That(countBefore, Is.EqualTo(2));
//                Assert.That(countAfter, Is.EqualTo(1));
//                Assert.That(allBefore.Count(a => a.Id == 1) == 1);
//                Assert.That(allAfter.Any(a => a.Id == 1) == false);
//                Assert.ThrowsAsync<EntityNotFoundException>(() =>
//                {
//                    return this.service.DeleteAsync(invalidModel);
//                });
//            });
//        }

//        /// <summary>
//        /// Update async test methods
//        /// </summary>
//        /// <returns>(void)</returns>
//        [Test]
//        public async Task UpdateAsync_ShouldWorkProperly()
//        {
//            var address1 = new AddressServiceModel()
//            {
//                Id = 1,
//                StreetName = "TestStreet1",
//                StreetNumber = "TestNumber1",
//                TownName = "TestTown1"
//            };
//            var address2 = new AddressServiceModel()
//            {
//                Id = 2,
//                StreetName = "TestStreet2",
//                StreetNumber = "TestNumber2",
//                TownName = "TestTown2"
//            };

//            await this.service.AddAsync(address1);
//            await this.service.AddAsync(address2);

//            var townNameBefore = address1.TownName;
//            var streetNameBefore = address1.StreetName;
//            var streetNumberBefore = address1.StreetNumber;

//            var newModel = new AddressServiceModel()
//            {
//                Id = address1.Id,
//                StreetName = "new",
//                StreetNumber = "new",
//                TownName = "new"
//            };

//            await service.UpdateAsync(newModel);

//            var updated = await service.GetByIdAsync(newModel.Id);

//            var invalidModel = new AddressServiceModel()
//            {
//                Id = 1000,
//                StreetName = "fake",
//                StreetNumber = "fake",
//                TownName = "fake"
//            };

//            Assert.Multiple(() =>
//            {
//                Assert.That(address1.StreetName != newModel.StreetName);
//                Assert.That(address1.StreetNumber != newModel.StreetNumber);
//                Assert.That(address1.TownName != newModel.TownName);
//                Assert.That(updated.StreetName == newModel.StreetName);
//                Assert.That(updated.StreetNumber == newModel.StreetNumber);
//                Assert.That(updated.TownName == newModel.TownName);
//                Assert.ThrowsAsync<EntityNotFoundException>(() =>
//                {
//                    return this.service.UpdateAsync(invalidModel);
//                });
//            });
//        }
//    }
//}
