namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Product service
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// Product repository
        /// </summary>
        private readonly IRepository<Product> repository = null!;

        private readonly IRepository<ProductMeasure> productMeasureRepository = null!;

        private readonly IRepository<Measure> measureRepository = null!;

        /// <summary>
        /// Default constructor, injection of Product repository (DI)
        /// </summary>
        /// <param name="repository">Product repository</param>
        public ProductService(IRepository<Product> repository,
            IRepository<ProductMeasure> productMeasureRepository,
            IRepository<Measure> measureRepository)
        {
            this.repository = repository;
            this.productMeasureRepository = productMeasureRepository;
            this.measureRepository = measureRepository;
        }

        /// <summary>
        /// Add product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ProductServiceModel product)
        {
            var entity = new Product()
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
                ItemGroupId = product.ItemGroup.Id,
                DateAdded = product.DateAdded,
                DateModified = product.DateModified,
            };

            await this.repository.AddAsync(entity);
        }
        
        /// <summary>
        /// Delete product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(ProductServiceModel product)
        {
            var entity = new Product()
            {

            };

            await this.repository.DeleteAsync(entity);
        }

        /// <summary>
        /// Get all products method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<ProductServiceModel>></returns>
        public async Task<IEnumerable<ProductServiceModel>> GetAllAsync()
        {
            var entities = await this.repository
                .All()
                .Include(p => p.ItemGroup)
                .Include(p => p.Barcodes)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .Where(p => p.IsActive)
                .AsNoTracking()
                .Select(e => new ProductServiceModel()
                {
                    Id = e.Id,
                    ArticleNumber = e.ArticleNumber,
                    DateAdded = e.DateAdded,
                    CashRegisterName = e.CashRegisterName,
                    CodeForScales = e.CodeForScales,
                    DateModified = e.DateModified,
                    Description = e.Description,
                    ItemGroup = e.ItemGroup,
                    ItemGroupId = e.ItemGroupId,
                    Measure = e.ProductsMeasures.First().Measure,
                    MeasureId = e.ProductsMeasures.First().MeasureId,
                    Barcodes = e.Barcodes.ToList(),
                    Name = e.Name,
                    NomenclatureNumber = e.NomenclatureNumber,
                    PurchasePrice = e.PurchasePrice,
                    Quantity = e.Quantity,
                    SalePrice = e.SalePrice,
                })
                .ToListAsync();

            return entities;
        }

        /// <summary>
        /// Get all products that match a condition (Asynchronous)
        /// </summary>
        /// <param name="condition">Condition for filtering</param>
        /// <returns>Task<IEnumerable<ProductServiceModel>></returns>
        public async Task<IEnumerable<ProductServiceModel>> GetAllByPredicateAsync
            (Predicate<Product> condition)
        {
            var entities = await this.repository
                .All()
                .Include(p => p.ItemGroup)
                .Include(p => p.Barcodes)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .AsNoTracking()
                .Where(p => p.IsActive)
                .ToListAsync();

            var sorted = entities
                .Where(e => condition.Invoke(e))
                .Select(e => new ProductServiceModel()
                {
                    Id = e.Id,
                    ArticleNumber = e.ArticleNumber,
                    DateAdded = e.DateAdded,
                    CashRegisterName = e.CashRegisterName,
                    CodeForScales = e.CodeForScales,
                    DateModified = e.DateModified,
                    Description = e.Description,
                    ItemGroup = e.ItemGroup,
                    ItemGroupId = e.ItemGroupId,
                    Measure = e.ProductsMeasures.First().Measure,
                    MeasureId = e.ProductsMeasures.First().MeasureId,
                    Barcodes = e.Barcodes.ToList(),
                    Name = e.Name,
                    NomenclatureNumber = e.NomenclatureNumber,
                    PurchasePrice = e.PurchasePrice,
                    Quantity = e.Quantity,
                    SalePrice = e.SalePrice,
                });

            return sorted;
        }

        /// <summary>
        /// Get a product by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<ProductServiceModel></returns>
        public async Task<ProductServiceModel> GetByIdAsync(int id)
        {
            var entity = await this.repository
                .All()
                .Include(p => p.ItemGroup)
                .Include(p => p.Barcodes)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .AsNoTracking()
                .Where(p => p.IsActive)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (entity == null)
            {
                throw new ArgumentNullException("Entity is null!");
            }

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
            var entity = new Product()
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
                DateModified = product.DateModified,
            };

            var oldEntity = await this.GetByIdAsync(product.Id);

            var oldProductMeasure = new ProductMeasure()
            {
                ProductId = product.Id,
                MeasureId = oldEntity.MeasureId
            };

            var measure = this.measureRepository
                .All()
                .Where(m => m.IsActive)
                .AsNoTracking()
                .FirstOrDefault(m => m.Id == product.MeasureId) 
                ?? new Measure();

            var productMeasure = new ProductMeasure()
            {
                ProductId = product.Id,
                MeasureId = product.MeasureId
            };

            var productsMeasures = new List<ProductMeasure>()
            {
                productMeasure
            };

            entity.ProductsMeasures = productsMeasures;

            await this.productMeasureRepository.DeleteAsync(oldProductMeasure);

            await this.productMeasureRepository.AddAsync(productMeasure);

            await this.repository.UpdateAsync(entity);
        }
    }
}
