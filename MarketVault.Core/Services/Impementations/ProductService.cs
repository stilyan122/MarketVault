namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Product service
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// Product repository
        /// </summary>
        private readonly IRepository<Product> repository = null!;

        /// <summary>
        /// ProductMeasure Service
        /// </summary>
        private readonly IProductMeasureService productMeasureService = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<ProductService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Product repository and logger (DI)
        /// </summary>
        /// <param name="repository">Product repository</param>
        /// <param name="productMeasureService">IProductMeasureService</param>
        /// <param name="logger">Logger</param>
        public ProductService(IRepository<Product> repository,
            IProductMeasureService productMeasureService,
            ILogger<ProductService> logger)
        {
            this.repository = repository;
            this.productMeasureService = productMeasureService;
            this.logger = logger;
        }

        /// <summary>
        /// Get all products method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<ProductServiceModel>></returns>
        public async Task<IEnumerable<ProductServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in product service invoked.");

            var entities = await this.repository
                .All()
                .ProjectToProductServiceModel()
                .ToListAsync();

            return entities;
        }

        /// <summary>
        /// Get all products that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<ProductServiceModel></returns>
        public IQueryable<ProductServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            logger.LogInformation("All by predicate async method in product service invoked.");

            var entities = this.repository
                .AllAsReadOnly()
                .AsNoTracking()
                .ProjectToProductServiceModel();

            logger.LogWarning("Potential exception to be thrown");

            try
            {
                entities = sortType switch
                {
                    "Name" => entities.Where(e => e.Name.ToLower().Contains(value.ToLower())),
                    "Cash Register Name" => entities.Where(e => e.CashRegisterName.ToLower().Contains(value.ToLower())),
                    "Article Number" when int.TryParse(value, out var articleNumber) =>
                        entities.Where(e => e.ArticleNumber == articleNumber),
                    "Nomenclature Number" when int.TryParse(value, out var nomenclatureNumber) =>
                        entities.Where(e => e.NomenclatureNumber == nomenclatureNumber),
                    "Sale Price" when decimal.TryParse(value, out var salePrice) =>
                        entities.Where(e => e.SalePrice == salePrice),
                    "Purchase Price" when decimal.TryParse(value, out var purchasePrice) =>
                        entities.Where(e => e.PurchasePrice == purchasePrice),
                    "Item Group Name" => entities.Where(e => e.ItemGroup.Name == value),
                    "Measure Type" => entities.Where(e => e.Measure.Name == value),
                    _ => entities.Where(e => e.Id == 0)
                };

                return entities;
            }
            catch (Exception)
            {
                entities = entities.Where(e => e.Id == 0);
            }

            return entities;
        }

        /// <summary>
        /// Get matching products paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber)
        {
            logger.LogInformation("All by predicate paged async method in product service invoked.");

            var entities = this.GetAllByPredicateAsync(sortType, value);

            return await entities
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        /// <summary>
        /// Method to get count of sorted paginated products
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public async Task<int> GetPredicatedCountAsync(string sortType, string value)
        {
            logger.LogInformation("Predicated count async method in product service invoked.");

            return await this.GetAllByPredicateAsync(sortType, value)
                .CountAsync();
        }

        /// <summary>
        /// Add product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ProductServiceModel product)
        {
            logger.LogInformation("Add async method in product service invoked.");

            var entity = ConvertToEntityModel(product);

            await this.repository.AddAsync(entity);

            entity.NomenclatureNumber = entity.Id;
            entity.ArticleNumber = entity.Id;

            await this.repository.SaveChangesAsync();

            var mappingEntity = new ProductMeasureServiceModel()
            {
                ProductId = entity.Id,
                MeasureId = product.MeasureId
            };

            await this.productMeasureService.AddAsync(mappingEntity);
        }
        
        /// <summary>
        /// Delete product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(ProductServiceModel product)
        {
            logger.LogInformation("Delete async method in product service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeProductStatements()
                .Where(p => p.Id == product.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Product not found");

            entity.IsActive = false;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Get a product by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<ProductServiceModel></returns>
        public async Task<ProductServiceModel> GetByIdAsync(int id)
        {
            logger.LogInformation("Get by id async method in product service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeProductStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new EntityNotFoundException("Product is null!");

            var serviceModel = new ProductServiceModel()
            {
                Id = entity.Id,
                ArticleNumber = entity.ArticleNumber,
                DateAdded = entity.DateAdded,
                CashRegisterName = entity.CashRegisterName,
                CodeForScales = entity.CodeForScales,
                DateModified = entity.DateModified,
                Description = entity.Description,
                ItemGroup = entity.ItemGroup,
                ItemGroupId = entity.ItemGroupId,
                Measure = entity.ProductsMeasures.First().Measure,
                MeasureId = entity.ProductsMeasures.First().MeasureId,
                Barcodes = entity.Barcodes.ToList(),
                Name = entity.Name,
                NomenclatureNumber = entity.NomenclatureNumber,
                PurchasePrice = entity.PurchasePrice,
                Quantity = entity.Quantity,
                SalePrice = entity.SalePrice,
            };

            return serviceModel;
        }

        /// <summary>
        /// Update product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(ProductServiceModel product)
        {
            logger.LogInformation("Update async method in product service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeProductStatements()
                .Where(p => p.Id == product.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Product not found");
            
            entity.CodeForScales = product.CodeForScales;
            entity.Name = product.Name;
            entity.CashRegisterName = product.CashRegisterName;
            entity.NomenclatureNumber = product.NomenclatureNumber;
            entity.PurchasePrice = product.PurchasePrice;
            entity.Quantity = product.Quantity;
            entity.SalePrice = product.SalePrice;
            entity.ArticleNumber = product.ArticleNumber;
            entity.Description = product.Description;
            entity.ItemGroupId = product.ItemGroupId;
            entity.ProductsMeasures.First().MeasureId = product.MeasureId;
            entity.DateModified = DateTime.Now;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Helper private method used for converting to entity model
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private static Product 
            ConvertToEntityModel(ProductServiceModel product)
        {
            return new Product()
            {
                Name = product.Name,
                CashRegisterName = product.CashRegisterName,
                ArticleNumber = product.ArticleNumber,
                NomenclatureNumber = product.NomenclatureNumber,
                CodeForScales = product.CodeForScales,
                PurchasePrice = product.PurchasePrice,
                SalePrice = product.SalePrice,
                Quantity = product.Quantity,
                Description = product.Description,
                ItemGroupId = product.ItemGroupId,
                DateAdded = product.DateAdded,
                DateModified = product.DateModified
            };
        }
    }
}
