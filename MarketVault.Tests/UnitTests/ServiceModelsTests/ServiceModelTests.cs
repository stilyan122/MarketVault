namespace MarketVault.Tests.UnitTests.ServiceModelsTests
{
    using MarketVault.Core.Models;
    using MarketVault.Infrastructure.Data.Models;
    using Newtonsoft.Json;
    using NUnit.Framework;

    /// <summary>
    /// Service model unit tests
    /// </summary>
    [TestFixture]
    public class ServiceModelTests
    {
        /// <summary>
        /// Address Service Model tests
        /// </summary>
        [Test]
        public void AddressServiceModel_Tests()
        {
            var model = new AddressServiceModel()
            {
                Id = 1,
                StreetName = "StreetName",
                TownName = "TownName",
                StreetNumber = "StreetNumber"
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.StreetName == "StreetName");
                Assert.That(model.TownName == "TownName");
                Assert.That(model.StreetNumber == "StreetNumber");
            });
        }

        /// <summary>
        /// Bank Service Model tests
        /// </summary>
        [Test]
        public void BankServiceModel_Tests()
        {
            var address = new Address()
            {
                Id = 1,
                StreetName = "StreetName",
                TownName = "TownName",
                StreetNumber = "StreetNumber"
            }; 

            var model = new BankServiceModel()
            {
                Id = 1,
                AddressId = 1,
                Name = "BankName",
                Address = address
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.AddressId == 1);
                Assert.That(model.Name == "BankName");
                Assert.That(model.Address == address);
            });
        }

        /// <summary>
        /// Counter Party Service Model tests
        /// </summary>
        [Test]
        public void CounterPartyServiceModel_Tests()
        {
            var address = new Address()
            {
                Id = 1,
                StreetName = "StreetName",
                TownName = "TownName",
                StreetNumber = "StreetNumber"
            };

            var bank = new Bank()
            {
                Id = 1,
                AddressId = 1,
                Name = "BankName",
                Address = address
            };

            var firm = new Firm()
            {
                Id = 1,
                AddressId = 1,
                Address = address,
                Email = "FirmEmail",
                Name = "FirmName",
                PhoneNumber = "0897645323",
                ResponsiblePersonName = "FirmPersonName"
            };

            var model = new CounterPartyServiceModel()
            {
                Id = 1,
                Bank = bank,
                BankCode = "BankCode",
                BankIBAN = "BankIBAN",
                ValueAddedTaxLawId = "VATLI",
                BankId = 1,
                Firm = firm,
                FirmId = 1,
                Name = "CounterPartyName",
                VATNumber = "VATNumber"
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.BankCode == "BankCode");
                Assert.That(model.Bank == bank);
                Assert.That(model.BankIBAN == "BankIBAN");
                Assert.That(model.ValueAddedTaxLawId == "VATLI");
                Assert.That(model.BankId == 1);
                Assert.That(model.Firm == firm);
                Assert.That(model.FirmId == 1);
                Assert.That(model.Name == "CounterPartyName");
                Assert.That(model.VATNumber == "VATNumber");
            });
        }

        /// <summary>
        /// Document Type Service Model tests
        /// </summary>
        [Test]
        public void DocumentTypeServiceModel_Tests()
        {
            var model = new DocumentTypeServiceModel()
            {
                Id = 1,
                Name = "DocumentTypeName"
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.Name == "DocumentTypeName");
            });
        }

        /// <summary>
        /// Firm Service Model tests
        /// </summary>
        [Test]
        public void FirmServiceModel_Tests()
        {
            var address = new Address()
            {
                Id = 1,
                StreetName = "StreetName",
                TownName = "TownName",
                StreetNumber = "StreetNumber"
            };

            var model = new FirmServiceModel()
            {
                Id = 1,
                AddressId = 1,
                Name = "FirmName",
                Address = address,
                Email = "FirmEmail",
                PhoneNumber = "0896213645",
                ResponsiblePersonName = "FirmPersonName"
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.AddressId == 1);
                Assert.That(model.Name == "FirmName");
                Assert.That(model.Address == address);
                Assert.That(model.Email == "FirmEmail");
                Assert.That(model.PhoneNumber == "0896213645");
                Assert.That(model.ResponsiblePersonName == "FirmPersonName");
            });
        }

        /// <summary>
        /// Item Group Service Model tests
        /// </summary>
        [Test]
        public void ItemGroupServiceModel_Tests()
        {
            var products = new List<ProductServiceModel>()
            {
                new ProductServiceModel()
                {
                    Id = 1
                },
                new ProductServiceModel()
                {
                    Id = 2
                }
            };

            var model = new ItemGroupServiceModel()
            {
                Id = 1,
                Name = "ItemGroupName",
                Products = products
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.Name == "ItemGroupName");
                Assert.That(model.Products == products);
            });
        }

        /// <summary>
        /// Measure Service Model tests
        /// </summary>
        [Test]
        public void MeasureServiceModel_Tests()
        {
            var model = new MeasureServiceModel()
            {
                Id = 1,
                Value = "Measure"
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.Value == "Measure");
            });
        }

        /// <summary>
        /// Operation Service Model tests
        /// </summary>
        [Test]
        public void OperationServiceModel_Tests()
        {
            var documentType = new DocumentType()
            {
                Id = 1
            };

            var counterParty = new CounterParty()
            {
                Id = 1
            };

            var user = new ApplicationUser()
            {
                Id = "1"
            };

            var date = DateTime.Now;

            var model = new OperationServiceModel()
            {
                Id = 1,
                DateMade = date,
                DocumentType = documentType,
                DocumentTypeId = 1,
                CounterParty = counterParty,
                CounterPartyId = 1,
                ProductsCount = 1,
                TotalPurchasePriceWithoutVAT = 1,
                TotalPurchasePriceWithVAT = 1,
                TotalSalePriceWithoutVAT = 1,
                TotalSalePriceWithVAT = 1,
                UserId = "1",
                User = user
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.DateMade == date);
                Assert.That(model.DocumentTypeId == 1);
                Assert.That(model.DocumentType == documentType);
                Assert.That(model.CounterPartyId == 1);
                Assert.That(model.CounterParty == counterParty);
                Assert.That(model.ProductsCount == 1);
                Assert.That(model.TotalPurchasePriceWithoutVAT == 1);
                Assert.That(model.TotalPurchasePriceWithVAT == 1);
                Assert.That(model.TotalSalePriceWithoutVAT == 1);
                Assert.That(model.TotalSalePriceWithVAT == 1);
                Assert.That(model.UserId == "1");
                Assert.That(model.User == user);
            });
        }

        /// <summary>
        /// Product For Operation Service Model tests
        /// </summary>
        [Test]
        public void ProductForOperationServiceModel_Tests()
        {
            var model = new ProductForOperationServiceModel()
            {
                Id = 1,
                PurchasePrice = 1,
                SalePrice = 1,
                Quantity = 1
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.PurchasePrice == 1);
                Assert.That(model.SalePrice == 1);
                Assert.That(model.Quantity == 1);
            });
        }

        /// <summary>
        /// Product Measure Service Model tests
        /// </summary>
        [Test]
        public void ProductMeasureServiceModel_Tests()
        {
            var model = new ProductMeasureServiceModel()
            {
                MeasureId = 1,
                ProductId = 1
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.MeasureId == 1);
                Assert.That(model.ProductId == 1);
            });
        }

        /// <summary>
        /// Product Operation Service Model tests
        /// </summary>
        [Test]
        public void ProductOperationServiceModel_Tests()
        {
            var products = new List<ProductForOperationServiceModel>()
            {
                new ProductForOperationServiceModel()
                {
                    Id = 1,
                    PurchasePrice = 1,
                    Quantity = 1,
                    SalePrice = 1
                }
            };
            var json = new List<string>();

            foreach (ProductForOperationServiceModel product in products)
            {
                json.Add(JsonConvert.SerializeObject(product));
            }

            var model = new ProductOperationServiceModel()
            {
                OperationId = 1,
                ProductId = 1,
                DocumentTypeId = 1,
                CounterPartyId = 1,
                Id = 1,
                Products = products,
                ProductsJson = json
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.OperationId == 1);
                Assert.That(model.ProductId == 1);
                Assert.That(model.DocumentTypeId == 1);
                Assert.That(model.CounterPartyId == 1);
                Assert.That(model.Id == 1);
                Assert.That(model.Products == products);
                Assert.That(model.ProductsJson == json);
            });
        }

        /// <summary>
        /// Product Service Model tests
        /// </summary>
        [Test]
        public void ProductServiceModel_Tests()
        {
            var itemGroup = new ItemGroup()
            {
                Id = 1,
                Name = "ItemGroup"
            };

            var barcodes = new List<Barcode>()
            {
                new Barcode()
                {
                    Id = 1,
                    Value = "1234567890",
                    ProductId = 1
                }
            };

            var measure = new Measure()
            {
                Id = 1,
                CanBeDecimal = true,
                Name = "Measure"
            };

            var date = DateTime.Now;

            var model = new ProductServiceModel()
            {
                Id = 1,
                ItemGroup = itemGroup,
                ItemGroupId = 1,
                DateAdded = date,
                DateModified = date,
                Description = "Description",
                ArticleNumber = 1,
                Barcodes = barcodes,
                CashRegisterName = "CashRegisterName",
                CodeForScales = 1,
                MeasureId = 1,
                Measure = measure,
                Name = "Name",
                NomenclatureNumber = 1,
                PurchasePrice = 1,
                Quantity = 1,
                SalePrice = 1
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.Id == 1);
                Assert.That(model.ItemGroup == itemGroup);
                Assert.That(model.ItemGroupId == 1);
                Assert.That(model.DateAdded == date);
                Assert.That(model.DateModified == date);
                Assert.That(model.Description == "Description");
                Assert.That(model.ArticleNumber == 1);
                Assert.That(model.Barcodes == barcodes);
                Assert.That(model.CashRegisterName == "CashRegisterName");
                Assert.That(model.CodeForScales == 1);
                Assert.That(model.MeasureId == 1);
                Assert.That(model.Measure == measure);
                Assert.That(model.Name == "Name");
                Assert.That(model.NomenclatureNumber == 1);
                Assert.That(model.PurchasePrice == 1);
                Assert.That(model.SalePrice == 1);
                Assert.That(model.Quantity == 1);
            });
        }

        /// <summary>
        /// Statistic Service Model tests
        /// </summary>
        [Test]
        public void StatisticServiceModel_Tests()
        {
            var model = new StatisticServiceModel()
            {
                TotalAddresses = 1,
                TotalBanks = 1,
                TotalCounterParties = 1,
                TotalFirms = 1,
                TotalItemGroups = 1,
                TotalProducts = 1,
                TotalUsers = 1
            };

            Assert.Multiple(() =>
            {
                Assert.That(model.TotalAddresses == 1);
                Assert.That(model.TotalBanks == 1);
                Assert.That(model.TotalCounterParties == 1);
                Assert.That(model.TotalFirms == 1);
                Assert.That(model.TotalItemGroups == 1);
                Assert.That(model.TotalProducts == 1);
                Assert.That(model.TotalUsers == 1);
            });
        }
    }
}
