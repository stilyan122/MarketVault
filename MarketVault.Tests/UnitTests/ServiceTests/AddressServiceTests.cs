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
    using NUnit.Framework;

    /// <summary>
    /// Address Service tests class
    /// </summary>
    [TestFixture]
    public class AddressServiceTests
    {
        private IAddressService service;
        private IRepository<Address> repository;
    
        /// <summary>
        /// SetUp method
        /// </summary>
        [OneTimeSetUp]
        public void Setup()
        {
            this.repository = new Repository<Address>(DatabaseMock.Mock);
            this.service = new AddressService(repository);
        }
    
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
          {
            var address1 = new AddressServiceModel()
            {
                Id = 1,
                StreetName = "TestStreet1",
                StreetNumber = "TestNumber1",
                TownName = "TestTown1"
            };
            var address2 = new AddressServiceModel()
            {
                Id = 2,
                StreetName = "TestStreet2",
                StreetNumber = "TestNumber2",
                TownName = "TestTown2"
            };

            var invalidAddress = await this.repository.GetByIdAsync(1);

            var addressesBeforeAdding = this.repository.All().Count();

            await this.service.AddAsync(address1);

            var addresses1AfterAdding = this.repository.All().Count();
            
            await this.service.AddAsync(address2);

            var addresses2AfterAdding = this.repository.All().Count();

            var addedAddress1 = await this.repository.GetByIdAsync(1);
            var addedAddress2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(addressesBeforeAdding,
                Is.EqualTo(addresses1AfterAdding - 1));

                Assert.That(addressesBeforeAdding,
                    Is.EqualTo(addresses2AfterAdding - 2));

                Assert.That(invalidAddress,
                    Is.EqualTo(null));

                Assert.That(addedAddress1?.Id,
                    Is.EqualTo(address1.Id));

                Assert.That(addedAddress2?.Id,
                    Is.EqualTo(address2.Id));
            });
        }

        [Test]
        public async Task GetByIdAsync_ShouldWorkProperly()
        {
            var address1 = new AddressServiceModel()
            {
                Id = 1,
                StreetName = "TestStreet1",
                StreetNumber = "TestNumber1",
                TownName = "TestTown1"
            };

            await this.service.AddAsync(address1);

            var validAddress = await this.service.GetByIdAsync(1);

            //Assert.Multiple(() =>
            //{
            //    Assert.That(address1.Id, 
            //        Is.EqualTo(validAddress.Id));

            //    Assert.Throws<EntityNotFoundException>(async Task () =>
            //    {
            //        var invalidAddress = await this.service.GetByIdAsync(1);
            //    });
            //});
        }
    }
}
