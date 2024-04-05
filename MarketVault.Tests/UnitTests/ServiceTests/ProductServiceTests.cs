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
    /// Product Service test class
    /// </summary
    [TestFixture]
    public class ProductServiceTests : UnitTestBase
    {
        /// <summary>
        /// Product Service
        /// </summary>
        private IProductService service = null!;

        /// <summary>
        /// Repository
        /// </summary>
        private IRepository<Product> repository = null!;

        /// <summary>
        /// Product Measure Service
        /// </summary>
        private IProductMeasureService productMeasureService = null!;

        /// <summary>
        /// SetUp method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            var mockRepositoryLogger =
                new Mock<ILogger<Repository<Product>>>();

            var mockServiceLogger =
                new Mock<ILogger<ProductService>>();

            this.context = DatabaseMock.Mock;

            this.repository = new Repository<Product>(context,
                mockRepositoryLogger.Object);

            this.productMeasureService = new Mock<IProductMeasureService>()
                .Object;

            this.service = new ProductService(repository,
                productMeasureService,
                mockServiceLogger.Object);
        }

        /// <summary>
        /// Add async test methods
        /// </summary>
        /// <returns>(void)</returns>
        [Test]
        public async Task AddAsync_ShouldWorkProperly()
        {
            var invalidProduct = await this.repository.GetByIdAsync(1);

            var ProductBeforeAdding = this.repository.All().Count();

            await this.SeedData();

            var ProductsAfterAdding = this.repository.All().Count();

            var addedProduct1 = await this.repository.GetByIdAsync(1);
            var addedProduct2 = await this.repository.GetByIdAsync(2);

            Assert.Multiple(() =>
            {
                Assert.That(ProductBeforeAdding,
                Is.EqualTo(ProductsAfterAdding - 2));

                Assert.That(invalidProduct,
                    Is.EqualTo(null));

                Assert.That(addedProduct1?.Id,
                    Is.EqualTo(1));

                Assert.That(addedProduct2?.Id,
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

            var validProduct = await this.service.GetByIdAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(1,
                    Is.EqualTo(validProduct.Id));

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
                .GetAllByPredicateAsync("Name", "Name1")
                .ToListAsync();

            var all2 = await this.service
                .GetAllByPredicateAsync("Name", "FalseProduct")
                .ToListAsync();

            var all3 = await this.service
                .GetAllByPredicateAsync("False False", "some Product name...")
                .ToListAsync();

            var all4 = await this.service
                .GetAllByPredicateAsync("Name", "Name")
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

            await this.service.DeleteAsync(new ProductServiceModel()
            {
                Id = 1
            });

            var allAfter = await this.service.GetAllAsync();
            var countAfter = allAfter.Count();

            var invalidModel = new ProductServiceModel()
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
            var nameBefore = "Name1";
            var descriptionBefore = "Description1";
            var articleNumberBefore = 1;
            var nomenclatureNumberBefore = 1;
            var cashRegisterNameBefore = "CashRegisterName1";
            var codeForScalesBefore = 1;

            await this.SeedData();

            var newModel = new ProductServiceModel()
            {
                Id = 1,
                Name = "new",
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = "new",
                ArticleNumber = 100,
                NomenclatureNumber = 100,
                CashRegisterName = "new",
                CodeForScales = 2,
                ItemGroupId = 2,
                MeasureId = 1
            };

            await this.service.UpdateAsync(newModel);

            var updated = await this.service.GetByIdAsync(1);

            var invalidModel = new ProductServiceModel()
            {
                Id = 1000,
                Name = "fake",
                ItemGroupId = 2,
                MeasureId = 2
            };

            Assert.Multiple(() =>
            {
                Assert.That(nameBefore != newModel.Name);
                Assert.That(descriptionBefore != newModel.Description);
                Assert.That(articleNumberBefore != newModel.ArticleNumber);
                Assert.That(nomenclatureNumberBefore != newModel.NomenclatureNumber);
                Assert.That(cashRegisterNameBefore != newModel.CashRegisterName);
                Assert.That(codeForScalesBefore != newModel.CodeForScales);
                Assert.That(updated.Name == newModel.Name);
                Assert.That(updated.Description == newModel.Description);
                Assert.That(updated.ArticleNumber == newModel.ArticleNumber);
                Assert.That(updated.NomenclatureNumber == newModel.NomenclatureNumber);
                Assert.That(updated.CashRegisterName == newModel.CashRegisterName);
                Assert.That(updated.CodeForScales == newModel.CodeForScales);
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

            await this.context.ItemGroups.AddAsync(itemGroup1);
            await this.context.ItemGroups.AddAsync(itemGroup2);
            await this.context.SaveChangesAsync();

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

            await this.repository.AddAsync(product1);
            await this.repository.AddAsync(product2);
        }
    }
}
