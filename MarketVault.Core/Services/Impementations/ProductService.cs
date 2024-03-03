namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Modes;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ProductService : IProductService
    {
        private readonly IRepository<Product> repository = null!;

        public ProductService(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(ProductServiceModel product)
        {
            var entity = new Product()
            {

            };

            await this.repository.AddAsync(entity);
        }

        public async Task DeleteAsync(ProductServiceModel product)
        {
            var entity = new Product()
            {

            };

            await this.repository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<ProductServiceModel>> GetAllAsync()
        {
            var entities = await this.repository
                .All()
                .Include(p => p.ItemGroup)
                .Include(p => p.Barcodes)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .Select(e => new ProductServiceModel()
                {
                    Id = e.Id,
                    ArticleNumber = e.ArticleNumber,
                    DateAdded = e.DateAdded,
                    CashRegisterName = e.CashRegisterName,
                    CodeForScales = e.CodeForScales,
                    DateModified = e.DateModified,
                    Description = e.Description,
                    ItemGroupName = e.ItemGroup.Name,
                    Measure = e.ProductsMeasures.First().Measure.Name,
                    Barcodes = e.Barcodes.Select(b => b.Value).ToList(),
                    Name = e.Name,
                    NomenclatureNumber = e.NomenclatureNumber,
                    PurchasePrice = e.PurchasePrice,
                    Quantity = e.Quantity,
                    SalePrice = e.SalePrice,
                })
                .ToListAsync();

            return entities;
        }

        public async Task UpdateAsync(ProductServiceModel product)
        {
            var entity = new Product()
            {

            };

            await this.repository.UpdateAsync(entity);
        }
    }
}
