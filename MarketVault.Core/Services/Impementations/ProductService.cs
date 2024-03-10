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

        /// <summary>
        /// Default constructor, injection of Product repository (DI)
        /// </summary>
        /// <param name="repository">Product repository</param>
        public ProductService(IRepository<Product> repository)
        {
            this.repository = repository;
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
        /// <returns></returns>
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
        /// Update product method (Asynchronous)
        /// </summary>
        /// <param name="product">Product to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(ProductServiceModel product)
        {
            var entity = new Product()
            {

            };

            await this.repository.UpdateAsync(entity);
        }
    }
}
