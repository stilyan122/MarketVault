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
                .Select(e => new ProductServiceModel()
                {

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
