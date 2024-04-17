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
    /// Item Group Service tests class
    /// </summary>
    [TestFixture]
    public class ItemGroupServiceTests : UnitTestBase
    {
        /// <summary>
        /// Item Group Service
        /// </summary>
        private IItemGroupService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<ItemGroup> repository = null!;

        /// <summary>
        /// Product Service
        /// </summary>
        private IProductService productService = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<ItemGroup>>>();

            var mockServiceLogger =
                new Mock<ILogger<ItemGroupService>>();

            this.context = DatabaseMock.Mock;

            var product1 = new ProductServiceModel()
            {
                Id = 1,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description1",
                ArticleNumber = 1,
                CashRegisterName = "CashRegisterName1",
                CodeForScales = 1,
                ItemGroupId = 1,
                Name = "Name1",
                NomenclatureNumber = 1,
                PurchasePrice = 1,
                SalePrice = 1,
                Quantity = 1
            };
            var product2 = new ProductServiceModel()
            {
                Id = 2,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description2",
                ArticleNumber = 2,
                CashRegisterName = "CashRegisterName2",
                CodeForScales = 2,
                ItemGroupId = 2,
                Name = "Name2",
                NomenclatureNumber = 2,
                PurchasePrice = 2,
                SalePrice = 2,
                Quantity = 2
            };

            this.repository = new Repository<ItemGroup>(context,
                mockRepositoryLogger.Object);

            IEnumerable<ProductServiceModel> products
                = new List<ProductServiceModel>() { product1, product2 };

            var productServiceMock = new Mock<IProductService>();
            productServiceMock.Setup(p => p.GetAllAsync())
                .Returns(Task.FromResult(products));
            productServiceMock.Setup(p => p.DeleteAsync(
                It.IsAny<ProductServiceModel>()))
                .Callback<ProductServiceModel>(async model =>
                {
                    var entity = await this.context
                    .Products
                    .FirstOrDefaultAsync(p => p.Id ==
                        model.Id) ?? new Product();

                    entity.IsActive = false;
                    await this.context.SaveChangesAsync();
                });

            this.productService = productServiceMock.Object;

            this.service = new ItemGroupService(repository,
                productService,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var invalidItemGroup = await this.repository.GetByIdAsync(1);

            var itemGroupBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var itemGroupsAfterAdding = this.repository.All().Count();

            var addedItemGroup1 = await this.repository.GetByIdAsync(1);
            var addedItemGroup2 = await this.repository.GetByIdAsync(2);

            var newEntity = new ItemGroupServiceModel()
            {
                Name = "NewName"
            };

            await this.service.AddAsync(newEntity);

            var newCount = await this.repository
                .All()
                .CountAsync();

            Assert.Multiple(() =>
            {
                Assert.That(itemGroupBeforeAdding,
                Is.EqualTo(itemGroupsAfterAdding - 2));

                Assert.That(invalidItemGroup,
                    Is.EqualTo(null));

                Assert.That(addedItemGroup1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedItemGroup2?.Id,
                    Is.EqualTo(2));

                Assert.That(newCount,
                    Is.EqualTo(3));
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

            var validItemGroup = await this.service
                .GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validItemGroup.Id));

                Assert.That(1,
                    Is.EqualTo(validItemGroup
                    .Products.Count()));

                Assert.That(1,
                    Is.EqualTo(validItemGroup
                    .Products.First()
                    .Measure.Id));

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
                .GetAllByPredicateAsync("Name", "ItemGroup1")
                .ToListAsync();

            var all2 = await this.service
                .GetAllByPredicateAsync("Name", "FalseItemGroup")
                .ToListAsync();

            var all3 = await this.service
                .GetAllByPredicateAsync("False False", "some itemGroup name...")
                .ToListAsync();

            var all4 = await this.service
                .GetAllByPredicateAsync("Name", "ItemGroup")
                .ToListAsync();

            var all5 = await this.service
                .GetAllByPredicateAsync("Minimum Number of Products in Item Group", "1")
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

            var allCount = await this.service
                .GetPredicatedCountAsync("Name",
                "Item");

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
                .GetAllByPredicatePagedAsync("Name", "Item",
                2, 1);

            Assert.That(all1.Count() == 2);
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
            var productsBefore = await this.context.Products
                .CountAsync();

            await this.service
                .DeleteAsync(new ItemGroupServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();
            var productsAfter = await this.context.Products
                .Where(p => p.IsActive)
                .CountAsync();

            var invalidModel = new ItemGroupServiceModel()
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
                Assert.That(productsBefore-productsAfter == 1);
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
            var nameBefore = "ItemGroup1";

            await this.SeedData();

            var newModel = new ItemGroupServiceModel()
            {
                Id = 1,
                Name = "new"
            };

            await this.service.UpdateAsync(newModel);

            var updated = await this.service.GetByIdAsync(1);

            var invalidModel = new ItemGroupServiceModel()
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
            var barcode1 = new Barcode()
            {
                Id = 1,
                ProductId = 1,
                Value = "1"
            };
            var barcode2 = new Barcode()
            {
                Id = 2,
                ProductId = 2,
                Value = "2"
            };

            var product1 = new Product()
            {
                Id = 1,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description1",
                ArticleNumber = 1,
                CashRegisterName = "CashRegisterName1",
                CodeForScales = 1,
                ItemGroupId = 1,
                Name = "Name1",
                NomenclatureNumber = 1,
                PurchasePrice = 1,
                SalePrice = 1,
                Quantity = 1
            };
            var product2 = new Product()
            {
                Id = 2,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "Description2",
                ArticleNumber = 2,
                CashRegisterName = "CashRegisterName2",
                CodeForScales = 2,
                ItemGroupId = 2,
                Name = "Name2",
                NomenclatureNumber = 2,
                PurchasePrice = 2,
                SalePrice = 2,
                Quantity = 2
            };

            var itemGroup1 = new ItemGroup()
            {
                Id = 1,
                Name = "ItemGroup1"
            };
            var itemGroup2 = new ItemGroup()
            {
                Id = 2,
                Name = "ItemGroup2"
            };

            var measure1 = new Measure()
            {
                CanBeDecimal = true,
                Id = 1,
                Name = "Measure1"
            };
            var measure2 = new Measure()
            {
                CanBeDecimal = true,
                Id = 2,
                Name = "Measure2"
            };

            var productMeasure1 = new ProductMeasure()
            {
                ProductId = 1,
                MeasureId = 1
            };
            var productMeasure2 = new ProductMeasure()
            {
                ProductId = 2,
                MeasureId = 2
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
                BankId = 1,
                FirmId = 1,
                ValueAddedTaxLawId = "VATLI2",
                VATNumber = "VATNumber2"
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

            var documentType1 = new DocumentType()
            {
                Id = 1,
                Name = "DocumentType1",
            };
            var documentType2 = new DocumentType()
            {
                Id = 2,
                Name = "DocumentType2",
            };

            var user1 = new ApplicationUser()
            {
                Id = "1",
                Email = "email1@gmail.com",
                EmailConfirmed = true,
                FirstName = "User1",
                LastName = "User1",
                PhoneNumber = "0899999999",
                UserName = "User1",
                PasswordHash = "Password1"
            };
            var user2 = new ApplicationUser()
            {
                Id = "2",
                Email = "email2@gmail.com",
                EmailConfirmed = true,
                FirstName = "User2",
                LastName = "User2",
                PhoneNumber = "0899999999",
                UserName = "User2",
                PasswordHash = "Password2"
            };

            var operation1 = new Operation()
            {
                DateMade = DateTime.Now,
                CounterPartyId = 1,
                DocumentTypeId = 1,
                Id = 1,
                TotalPurchasePriceWithoutVAT = 1,
                TotalPurchasePriceWithVAT = 1,
                TotalSalePriceWithoutVAT = 1,
                TotalSalePriceWithVAT = 1,
                UserId = "1",
            };
            var operation2 = new Operation()
            {
                DateMade = DateTime.Now,
                CounterPartyId = 2,
                DocumentTypeId = 2,
                Id = 2,
                TotalPurchasePriceWithoutVAT = 2,
                TotalPurchasePriceWithVAT = 2,
                TotalSalePriceWithoutVAT = 2,
                TotalSalePriceWithVAT = 2,
                UserId = "2",
            };

            var productOperation1 = new ProductOperation()
            {
                ProductId = 1,
                OperationId = 1
            };
            var productOperation2 = new ProductOperation()
            {
                ProductId = 2,
                OperationId = 2
            };

            await this.context.Barcodes.AddAsync(barcode1);
            await this.context.Barcodes.AddAsync(barcode2);
            await this.context.SaveChangesAsync();

            await this.repository.AddAsync(itemGroup1);
            await this.repository.AddAsync(itemGroup2);

            await this.context.Measures.AddAsync(measure1);
            await this.context.Measures.AddAsync(measure2);
            await this.context.SaveChangesAsync();

            await this.context.ProductsMeasures.AddAsync(productMeasure1);
            await this.context.ProductsMeasures.AddAsync(productMeasure2);
            await this.context.SaveChangesAsync();

            await this.context.Addresses.AddAsync(address1);
            await this.context.Addresses.AddAsync(address2);
            await this.context.SaveChangesAsync();

            await this.context.Firms.AddAsync(firm1);
            await this.context.Firms.AddAsync(firm2);
            await this.context.SaveChangesAsync();

            await this.context.Banks.AddAsync(bank1);
            await this.context.Banks.AddAsync(bank2);
            await this.context.SaveChangesAsync();

            await this.context.DocumentTypes.AddAsync(documentType1);
            await this.context.DocumentTypes.AddAsync(documentType2);
            await this.context.SaveChangesAsync();

            await this.context.CounterParties.AddAsync(counterParty1);
            await this.context.CounterParties.AddAsync(counterParty2);
            await this.context.SaveChangesAsync();

            await this.context.Operations.AddAsync(operation1);
            await this.context.Operations.AddAsync(operation2);
            await this.context.SaveChangesAsync();

            await this.context.Users.AddAsync(user1);
            await this.context.Users.AddAsync(user2);
            await this.context.SaveChangesAsync();

            await this.context.ProductsOperations.AddAsync(productOperation1);
            await this.context.ProductsOperations.AddAsync(productOperation2);
            await this.context.SaveChangesAsync();

            await this.context.Products.AddAsync(product1);
            await this.context.Products.AddAsync(product2);
            await this.context.SaveChangesAsync();

        }
    }
}
